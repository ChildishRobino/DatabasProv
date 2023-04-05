using CaseManagerApp.MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace CaseManagerApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {




        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
