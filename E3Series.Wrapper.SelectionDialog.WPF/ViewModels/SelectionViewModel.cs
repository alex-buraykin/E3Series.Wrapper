using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF.Commands;
using E3Series.Wrapper.SelectionDialog.WPF.Models;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base;
using E3Series.Wrapper.SelectionDialog.WPF.Views;
using E3Series.Wrapper.SelectionDialog.WPF.Views.Interfaces;

namespace E3Series.Wrapper.SelectionDialog.WPF.ViewModels
{
    internal class SelectionViewModel : ViewModelBase<SelectionWindow>, IConnectorSelectionDialog
    {
        #region Private Fields

        private ICommand _cancelCommand;
        private ICommand _okCommand;

        #endregion
        
        #region Public Fields

        /// <summary>
        /// Selected E3.series instance on form
        /// </summary>
        public RunningApplication SelectedProcess { get; set; }

        /// <summary>
        /// List of running E3.series instances
        /// </summary>
        public ObservableCollection<RunningApplication> Processes { get; private set; }

        #endregion
        
        #region Constructor

        public SelectionViewModel() : base(new SelectionWindow())
        {
            Processes = new ObservableCollection<RunningApplication>();
        }

        #endregion

        #region IConnectorSelectionDialog Members

        public bool ShowDialog(Dictionary<int, object> processes, out object selectedProcess)
        {
            foreach (var process in processes)
                Processes.Add(new RunningApplication(process));

            var result = View.ShowDialog() == true;
            selectedProcess = SelectedProcess.ComObject;
            return result;
        }

        #endregion

        #region Commands

        public ICommand CancelCommand
        {
            get
            {
                return _cancelCommand ??
                       (_cancelCommand = new RelayCommand(() =>
                           {
                               (View as IDialogView).DialogResult = false;
                           }));
            }
        }

        public ICommand OkCommand
        {
            get
            {
                return _okCommand ?? (_okCommand = new RelayCommand(() =>
                {
                    (View as IDialogView).DialogResult = true;
                }, () => SelectedProcess != null));
            }
        }

        #endregion
    }
}