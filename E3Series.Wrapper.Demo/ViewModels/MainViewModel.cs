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
        #region Private Fields

        private readonly IConnector _connector = new WpfConnector();
        private ICommand _connectCommand;
        private IApplication _app;
        private ICommand _disconnectCommand;

        #endregion

        #region Constructor

        public MainViewModel() : base(new MainWindow())
        {
        }

        #endregion

        #region Commands

        public ICommand ConnectCommand
        {
            get
            {
                return _connectCommand ??
                       (_connectCommand = new RelayCommand(() => { _app = _connector.Connect(); }, () => _app == null));
            }
        }

        public ICommand DisconnectCommand
        {
            get
            {
                return _disconnectCommand ??
                       (_disconnectCommand = new RelayCommand(() =>
                       {
                           _app.Dispose();
                           _app = null;
                       }, () => _app != null));
            }
        }

        #endregion
    }
}