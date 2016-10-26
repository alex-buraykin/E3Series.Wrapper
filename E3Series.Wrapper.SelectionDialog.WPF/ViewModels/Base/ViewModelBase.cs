using System.ComponentModel;
using E3Series.Wrapper.SelectionDialog.WPF.Views.Interfaces;

namespace E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base
{
    /// <summary>
    /// Base class for ViewModels
    /// </summary>
    /// <typeparam name="TViewType"></typeparam>
    public class ViewModelBase<TViewType> : INotifyPropertyChanged where TViewType : IDialogView
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Private Fields

        private readonly TViewType _view;

        #endregion

        #region Public Fields

        public TViewType View
        {
            get { return _view; }
        }

        #endregion

        #region Constructor

        public ViewModelBase(TViewType view)
        {
            _view = view;
            _view.DataContext = this;
        }

        #endregion

        #region Public Methods

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}