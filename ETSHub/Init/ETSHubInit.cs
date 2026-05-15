using Microsoft.Extensions.Logging;

namespace ETSHub.Init;

public class ETSHubInit {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder
                                        .SetMinimumLevel(LogLevel.Information)
                                               .AddSimpleConsole(options => {
            options.IncludeScopes   = true;
            options.SingleLine      = true;
            options.TimestampFormat = "hh:mm:ss";
        }));

    private static ILogger Logger = LogFactory.CreateLogger<ETSHubInit>();
    
    //logger
    //config database
    //data database

    private static void LoadConfigDatabase() {
        Logger.LogInformation("Loading configuration databases", "LoadConfigDatabase");
        
    }

}