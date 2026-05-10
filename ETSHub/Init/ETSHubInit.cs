using Microsoft.Extensions.Logging;

namespace ETSHub.Init;

public class ETSHubInit {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));

    private static ILogger Log = LogFactory.CreateLogger<ETSHubInit>();
    
    //logger
    //config database
    //data database

    private static void LoadConfigDatabase() {
        
    }

}