﻿using System;
using System.Windows;
using System.Windows.Input;
using E3Series.Wrapper.Demo.Extensions;
using E3Series.Wrapper.Demo.Views;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF;
using E3Series.Wrapper.SelectionDialog.WPF.Commands;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base;
using E3Series.Wrapper.Entities.Extensions;

namespace E3Series.Wrapper.Demo.ViewModels
{
    public class MainViewModel : ViewModelBase<MainWindow>
    {
        private readonly IConnector _connector = new WpfConnector();
        private readonly string[] _appChangedPropertiesNames = {nameof(IsConnected), nameof(IsProjectOpened)};
        private IApplication _app;
        private string _projectName;

        public bool IsConnected => _app?.IsApplicationRunning() ?? false;
        public bool IsProjectOpened => _app?.IsProjectOpened() ?? false;

        public string ProjectName
        {
            get => _projectName;
            set
            {
                _projectName = value;
                RaisePropertyChanged(nameof(ProjectName));
            }
        }

        public ICommand ConnectApplicationCommand { get; private set; }
        public ICommand DisconnectApplicationCommand { get; private set; }
        public ICommand GetJobInfoCommand { get; private set; }

        public MainViewModel()
            : base(new MainWindow())
        {
            CreateCommands();
        }

        private void CreateCommands()
        {
            ConnectApplicationCommand = new RelayCommand(OnConnectApplication,
                () => _app == null);
            DisconnectApplicationCommand = new RelayCommand(OnDisconnectApplication,
                () => _app != null);

            GetJobInfoCommand = new RelayCommand(OnGetJobInfo,
                () => _app != null && IsProjectOpened);
        }

        private void OnGetJobInfo()
        {
            using (var job = _app.CreateJobObject())
            {
                ProjectName = job.Proxy.GetName();

                // Sample working with arrays (use proxy object)
                object ids = null;
                var selectedCount = job.Proxy.GetSelectedDeviceIds(ref ids);
                Console.WriteLine(selectedCount);
                var idsEnumerable = ids.ToIEnumerable(); // using E3Series.Wrapper.Entities.Extensions;
                using (var dev = job.CreateDeviceObject())
                {
                    foreach (var id in idsEnumerable)
                    {
                        dev.Id = id;
                        Console.WriteLine(dev.Name);
                    }
                }
            }
        }

        private void OnConnectApplication()
        {
            _app = _connector.Connect();
            _appChangedPropertiesNames.ForEach(RaisePropertyChanged);

            if (_app == null)
                MessageBox.Show("Unable to connect to E3series COM", "Error");
            else
                _app.Proxy.PutInfo(0, "Successfully connected to E3.series");
        }

        private void OnDisconnectApplication()
        {
            _app.Dispose();
            _app = null;
            _appChangedPropertiesNames.ForEach(RaisePropertyChanged);
            ProjectName = null;
        }
    }
}