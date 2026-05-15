using Microsoft.Extensions.Logging;

namespace ETSCore.Types.Config;

public class ConfigManager {

    private static ILoggerFactory LogFactory = LoggerFactory
        .Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private ILogger       Logger;
    
    private Dictionary<string, ConfigOption> ConfigOptions;

    public ConfigManager() {
        Logger = LogFactory.CreateLogger<ConfigManager>();
    }

    public void SetConfigOptions(Dictionary<string, ConfigOption> options) {
        ConfigOptions = options;
    }

    public string GetValue(string optionName) {
        return ConfigOptions[optionName].GetOptionValue();
    }

}