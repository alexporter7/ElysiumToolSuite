using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ETSCore;
using Microsoft.Extensions.Logging;

namespace ElysiumToolSuite;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    public  ETSAppCore EtsAppCore;
    private ILogger    Logger;

    public MainWindow() {
        InitializeComponent();
        EtsAppCore = new ETSAppCore();
        Logger     = EtsAppCore.Factory.CreateLogger("ElysiumToolSuiteWindow");
        Logger.LogInformation("The ETS Main WPF Application has initialized");
    }

    private void MenuItem_OnClick(object sender, RoutedEventArgs e) {
        if (sender.GetType() != typeof(MenuItem)) {
            Logger.LogError(
                $"Unexpected type passed in, should be type [MenuItem] instead was given [{sender.GetType()}]");
            return;
        }

        MenuItem menuItem = (MenuItem)sender;
        Logger.LogDebug($"[{e.RoutedEvent.Name}] Event fired from [{menuItem.Name}] [{e.Source.GetType()}]");
    }

    private void FileMenuItem_OnClick(object sender, RoutedEventArgs e) {
        MenuItem_OnClick(sender, e);
    }

    private void EditMenuItem_OnClick(object sender, RoutedEventArgs e) {
        MenuItem_OnClick(sender, e);
    }

    private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
        //TODO: debug message
    }

}