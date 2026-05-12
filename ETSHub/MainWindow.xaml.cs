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

namespace ETSHub;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    private ETSHubCore EtsHubCore;
    
    public MainWindow() {
        InitializeComponent();
        EtsHubCore = new ETSHubCore();
    }


    private void EtsBuildTools_OnClick(object sender, RoutedEventArgs e) {
        ETSBuildTool.MainWindow EtsBuildToolWindow = new ETSBuildTool.MainWindow();
        EtsBuildToolWindow.Show();
    }

}