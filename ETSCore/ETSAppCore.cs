using Microsoft.Extensions.Logging;

namespace ETSCore;

public class ETSAppCore {

    public ILoggerFactory Factory = LoggerFactory.Create(builder => {
        builder.SetMinimumLevel(LogLevel.Debug);
        builder.AddSimpleConsole(options => {
            options.IncludeScopes   = true;
            options.SingleLine      = true;
            options.TimestampFormat = "[HH:mm:ss:ffffff] ";
        });
        
    });

    private ILogger Logger;


    public ETSAppCore() {
        Logger = Factory.CreateLogger<ETSAppCore>();
        Logger.LogInformation("ETSAppCore has been initialized");
    }


}