using ETSCore;
using ETSCore.Database;
using ETSCore.Types;
using ETSCore.Types.Cities.Residents;
using ETSCore.Types.Registration;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace ETSHub;

public class AppCore {

    public static ILoggerFactory LogFactory =
        LoggerFactory.Create(builder => {
            builder
                .SetMinimumLevel(LogLevel.Information)
                .AddSimpleConsole(options => {
                    options.IncludeScopes   = true;
                    options.SingleLine      = true;
                    options.TimestampFormat = "[HH:mm:ss:fffff] ";
                });
        });

    private ILogger Logger = LogFactory.CreateLogger<AppCore>();

    private ETSGlobalCore EtsGlobalCore;

    public WatchDawg<City>     CityWatchDawg;
    public WatchDawg<District> DistrictWatchDawg;
    public WatchDawg<Resident> ResidentWatchDawg;

    public City CurrentCity;

    public AppCore() {
        Logger.LogInformation("AppCore has been initialized");
        EtsGlobalCore = new ETSGlobalCore();

        Logger.LogInformation("Registering WatchDawgs");
        CityWatchDawg     = new WatchDawg<City>();
        DistrictWatchDawg = new WatchDawg<District>();
        ResidentWatchDawg = new WatchDawg<Resident>();
        
        TestData.TestSerialization();
        TestData.TestWatchDawg(this);
        
    }

}