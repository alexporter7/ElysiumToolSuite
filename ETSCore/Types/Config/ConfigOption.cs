namespace ETSCore.Types.Config;

public class ConfigOption {

    private string Name;
    private string      Value;

    public ConfigOption(string name, string value) {
        Name  = name;
        Value = value;
    }

    public string GetOptionName() {
        return Name;
    }

    public string GetOptionValue() {
        return Value;
    }

}