using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace popup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // utworzenie okna głównego
            var mainWindow = new MainWindow();

            // wyświetlenie okna głównego za pomocą metody Show()
            mainWindow.Show();
        }
    }
}
