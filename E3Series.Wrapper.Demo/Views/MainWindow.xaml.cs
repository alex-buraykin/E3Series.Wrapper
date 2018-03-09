using System.Windows;
using E3Series.Wrapper.SelectionDialog.WPF.Views.Interfaces;

namespace E3Series.Wrapper.Demo.Views
{
    /// <inheritdoc cref="IDialogView" />
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IDialogView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
