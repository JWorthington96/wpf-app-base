using System.Windows;

namespace DrinkingBuddy.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CloseApp(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

    private void RestoreApp(object sender, RoutedEventArgs e)
    {
        var window = Application.Current.MainWindow ?? throw new System.Exception("No main window.");
        if (window.WindowState == WindowState.Maximized)
        {
            window.WindowState = WindowState.Normal;
        }
        else if (window.WindowState == WindowState.Normal)
        {
            window.WindowState = WindowState.Maximized;
        }
    }

    private void MinimiseApp(object sender, RoutedEventArgs e)
    {
        var window = Application.Current.MainWindow ?? throw new System.Exception("No main window.");
        if (window.WindowState != WindowState.Minimized)
        {
            window.WindowState = WindowState.Minimized;
        }
    }
}
