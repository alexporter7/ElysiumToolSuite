using ETSCore.Enums;

namespace ETSCore.Types;

public class PromptEntry {

    private AIModel          Model;
    private PromptEntryState EntryState;
    private string           Context;
    private string           Prompt;

    public ActionStatus QueryPrompt() {
        return ActionStatus.Success;
    }

}