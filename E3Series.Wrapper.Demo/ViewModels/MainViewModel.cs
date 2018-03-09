using System.Windows;
using System.Windows.Input;
using E3Series.Wrapper.Demo.Views;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF;
using E3Series.Wrapper.SelectionDialog.WPF.Commands;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base;

namespace E3Series.Wrapper.Demo.ViewModels
{
    public class MainViewModel : ViewModelBase<MainWindow>
    {
        private readonly IConnector _connector = new WpfConnector();
        private IApplication _app;

        public ICommand ConnectCommand { get; private set; }
        public ICommand DisconnectCommand { get; private set; }

        public MainViewModel() 
            : base(new MainWindow())
        {
            CreateCommands();
        }

        private void CreateCommands()
        {
            ConnectCommand = new RelayCommand(OnConnect,
                () => _app == null);
            DisconnectCommand = new RelayCommand(OnDisconnect,
                () => _app != null);
        }

        private void OnConnect()
        {
            _app = _connector.Connect();

            if (_app == null)
                MessageBox.Show("Unable to connect to E3series COM", "Error");
        }

        private void OnDisconnect()
        {
            _app.Dispose();
            _app = null;
        }
    }
}