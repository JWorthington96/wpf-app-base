using WpfAppBase.Views;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace WpfAppBase.Infrastructure;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var bootstrapper = new Bootstrapper();
        bootstrapper.Start();

        MainWindow = new MainWindow();
        MainWindow.Show();
    }
}
