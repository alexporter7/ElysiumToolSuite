using Microsoft.Extensions.Logging;

namespace ETSCore.Types.Registration;

public class WatchDawg<T> {

    private ILogger               Logger         = ETSGlobalCore.LogFactory.CreateLogger<WatchDawg<T>>();
    private Dictionary<string, T> DawgDictionary = [];

    public WatchDawg() {
        Logger.LogInformation($"WatchDawg for [{typeof(T)}] has been initialized");
    }

}