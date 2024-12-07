using System.Windows;

namespace WpfAppBase.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    ///     Constructor for MainWindow.
    /// </summary>
    public MainWindow() => InitializeComponent();
    
    private void TopBarMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var window = Application.Current.MainWindow ?? throw new System.Exception("No main window.");
        if (window.WindowState == WindowState.Maximized)
        {
            window.WindowState = WindowState.Normal;
            RestoreIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
        }
        DragMove();
    }

    private void CloseApp(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

    private void RestoreApp(object sender, RoutedEventArgs e)
    {
        var window = Application.Current.MainWindow ?? throw new System.Exception("No main window.");
        if (window.WindowState == WindowState.Maximized)
        {
            window.WindowState = WindowState.Normal;
            RestoreIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
        }
        else if (window.WindowState == WindowState.Normal)
        {
            window.WindowState = WindowState.Maximized;
            RestoreIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
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
