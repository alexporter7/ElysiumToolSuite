using Microsoft.Extensions.Logging;

namespace ETSCore.Util;

public class LogUtil {

    public static ILoggerFactory CreateLogFactory() {
        return LoggerFactory.Create(builder => {
            builder
                .SetMinimumLevel(LogLevel.Information)
                .AddSimpleConsole(options => {
                    options.IncludeScopes   = true;
                    options.SingleLine      = true;
                    options.TimestampFormat = "hh:mm:ss";
                });
        });
    }

}