using E3Series.Wrapper.Demo.Views;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base;

namespace E3Series.Wrapper.Demo.ViewModels
{
    public class MainViewModel : ViewModelBase<MainWindow>
    {
        #region Constructor

        public MainViewModel() : base(new MainWindow())
        {
        }

        #endregion
    }
}