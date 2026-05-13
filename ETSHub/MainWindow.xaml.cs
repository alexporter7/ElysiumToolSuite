using System.Windows;

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


    private void BuildManager_OnClick(object sender, RoutedEventArgs e) {
        BuildManager.MainWindow EtsBuildToolWindow = new BuildManager.MainWindow();
        EtsBuildToolWindow.Show();
    }
    
    private void CityManager_OnClick(object sender, RoutedEventArgs e) {
        // CityManager.MainWindow CityManagerWindow = new CityManager().MainWindow();
        // CityManagerW.Show();
        CityManager.MainWindow CityManagerWindow = new CityManager.MainWindow();
        CityManagerWindow.Show();
    }

}