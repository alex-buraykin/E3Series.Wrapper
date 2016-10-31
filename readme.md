# E3Series.Wrapper

A toolkit for simplify work with E3.series COM.

[![Release](https://img.shields.io/github/release/alex-buraykin/E3Series.Wrapper.svg?style=flat-square)](https://github.com/alex-buraykin/E3Series.Wrapper/releases/latest)
[![AppVeyor](https://img.shields.io/appveyor/ci/alex-buraykin/E3Series-Wrapper.svg?style=flat-square)](https://ci.appveyor.com/project/alex-buraykin/e3series-wrapper)
[![Issues](https://img.shields.io/github/issues/alex-buraykin/E3Series.Wrapper.svg?style=flat-square)](https://github.com/alex-buraykin/E3Series.Wrapper/issues)

## A short How To

Or, how to create a simple application with toolkit `E3Series.Wrapper`...

```csharp
using System.Windows;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF;

namespace WpfApplication
{
    public partial class MainWindow
    {
        // Connector
        private readonly IConnector _connector = new WpfConnector();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Simply call method Connect()
            var app = _connector.Connect();

            // Done
            if (app != null)
                app.ComObject.PutMessage("E3Series.Wrapper connected!");
        }
    }
}

```
