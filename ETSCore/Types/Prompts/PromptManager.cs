using ETSCore.Enums;

namespace ETSCore.Types;

public class PromptManager {

    private List<PromptEntry> PromptEntries = [];
    private PromptEntry       CurrentPrompt;

    public PromptManager() {
        
    }
    
    public PromptManager(List<PromptEntry> entries) {
        PromptEntries = entries;
    }

    public void AddPrompt(PromptEntry prompt) {
        PromptEntries.Add(prompt);
    }

    public ActionStatus ExecutePrompt() {
        if (PromptEntries.Count == 0)
            return ActionStatus.Success;
        return ActionStatus.Success;
    }

}