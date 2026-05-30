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
using ETSHub;
using Microsoft.Extensions.Logging;

namespace ResidentManager;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    private ILogger Logger = AppCore.LogFactory.CreateLogger("ResidentManagerWindow");

    public AppCore GlobalAppCore;

    public MainWindow(AppCore appCore) {
        InitializeComponent();
        GlobalAppCore = appCore;
        Logger.LogInformation("Resident Manager window has been initialized");
    }

}