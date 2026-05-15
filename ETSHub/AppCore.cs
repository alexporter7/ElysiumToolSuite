using ETSCore;
using ETSCore.Database;
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
    //private ETSDatabaseManager DatabaseManager;

    public AppCore() {
        Logger.LogInformation("AppCore has been initialized");
        EtsGlobalCore = new ETSGlobalCore();
        //DatabaseManager = new ETSDatabaseManager();
    }

}