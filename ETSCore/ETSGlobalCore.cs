using Microsoft.Extensions.Logging;

namespace ETSCore;

public class ETSGlobalCore {

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
    
    private static ILogger Log;

    public ETSGlobalCore() {
        Log = LogFactory.CreateLogger<ETSGlobalCore>();
        Log.LogInformation("ETSGlobalCore has been initialized");
    }

}