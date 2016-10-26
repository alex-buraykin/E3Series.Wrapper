using System.Windows;
using E3Series.Wrapper.Demo.ViewModels;

namespace E3Series.Wrapper.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var entryPoint = new MainViewModel();
            entryPoint.View.Show();
        }
    }
}
