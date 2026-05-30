using Microsoft.Extensions.Logging;

namespace ETSCore.Types.Registration;

public class WatchDawg<T> {

    private ILogger               Logger         = ETSGlobalCore.LogFactory.CreateLogger<WatchDawg<T>>();
    private Dictionary<string, T> DawgDictionary = [];

    public WatchDawg() {
        Logger.LogInformation($"WatchDawg for [{typeof(T)}] has been initialized");
    }

    public bool AddEntry(string key, T entry) {
        if (DawgDictionary.ContainsKey(key)) {
            Logger.LogError($"[{typeof(T)}] Tried adding entry with a key that already exists. Key: [{key}]");
            return false;
        }
        
        Logger.LogInformation($"[{typeof(T)}] Added entry for key [{key}]");
        DawgDictionary.Add(key, entry);
        return true;

    }

    public T GetEntry(string key) {
        Logger.LogInformation($"[{typeof(T)}] Retrieving entry for key [{key}]");
        return DawgDictionary[key];
    }

}