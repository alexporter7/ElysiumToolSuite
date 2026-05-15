using Microsoft.Extensions.Logging;

namespace ETSCore.Types.Config;

public class ConfigManager {
    private ILogger       Logger;
    
    private Dictionary<string, ConfigOption> ConfigOptions;

    public ConfigManager() {
        Logger = ETSGlobalCore.LogFactory.CreateLogger<ConfigManager>();
        Logger.LogInformation("ConfigManager has been initialized");
    }

    public void SetConfigOptions(Dictionary<string, ConfigOption> options) {
        ConfigOptions = options;
    }

    public string GetValue(string optionName) {
        Logger.LogInformation($"Requesting config value for option [{optionName}]");
        return ConfigOptions[optionName].GetOptionValue();
    }

}