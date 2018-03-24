using System.ComponentModel;
using E3Series.Wrapper.SelectionDialog.WPF.Views.Interfaces;

namespace E3Series.Wrapper.SelectionDialog.WPF.ViewModels.Base
{
    /// <inheritdoc />
    /// <summary>
    /// Base class for ViewModels
    /// </summary>
    /// <typeparam name="TViewType"></typeparam>
    public class ViewModelBase<TViewType> : INotifyPropertyChanged where TViewType : IDialogView
    {
        private readonly TViewType _view;

        public event PropertyChangedEventHandler PropertyChanged;

        public TViewType View => _view;

        public ViewModelBase(TViewType view)
        {
            _view = view;
            _view.DataContext = this;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}