using ETSCore;
using ETSCore.Database;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace ETSHub;



public class ETSHubCore {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private ILogger       Logger = LogFactory.CreateLogger<ETSHubCore>();

    private ETSGlobalCore      EtsGlobalCore;
    private ETSDatabaseManager DatabaseManager;

    public ETSHubCore() {
        Logger.LogInformation("ETSHubCore has been initialized");
        EtsGlobalCore   = new ETSGlobalCore();
        DatabaseManager = new ETSDatabaseManager();
    }

}