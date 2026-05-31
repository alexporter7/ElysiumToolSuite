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

namespace ETSConfig;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    public  ETSAppCore AppCore;
    private ILogger    Logger;
    
    public MainWindow(ETSAppCore appCore) {
        InitializeComponent();
        AppCore = appCore;
        Logger  = appCore.Factory.CreateLogger("ETSConfigMainWindow");
        Logger.LogInformation("ETSConfig MainWindow has initialized");
    }

}