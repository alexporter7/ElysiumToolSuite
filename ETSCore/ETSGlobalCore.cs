using Microsoft.Extensions.Logging;

namespace ETSCore;

public class ETSGlobalCore {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private static ILogger Log;

    public ETSGlobalCore() {
        Log = LogFactory.CreateLogger<ETSGlobalCore>();
        Log.LogInformation("ETSGlobalCore has been initialized");
    }

}