using System.Windows;
using Microsoft.Extensions.Logging;

namespace ETSHub;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    public AppCore AppCore;
    
    public MainWindow() {
        InitializeComponent();
        AppCore = new AppCore();
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