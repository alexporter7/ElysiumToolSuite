namespace ETSCore.Global;

public class NameGlobal {

    public static readonly string ConfigDatabaseFileName   = "config.db";
    public static readonly string ResidentDatabaseFileName = "resident.db";
    public static readonly string CityDatabaseFileName     = "city.db";
    public static readonly string BuildDatabaseFileName    = "build.db";

    public static readonly string DatabaseFileDirectory = ".\\db";
    public static readonly string ConfigDatabasePath    = $"{DatabaseFileDirectory}\\{ConfigDatabaseFileName}";
    public static readonly string ResidentDatabasePath    = $"{DatabaseFileDirectory}\\{ResidentDatabaseFileName}";
    public static readonly string CityDatabasePath    = $"{DatabaseFileDirectory}\\{CityDatabaseFileName}";
    public static readonly string BuildDatabasePath    = $"{DatabaseFileDirectory}\\{BuildDatabaseFileName}";

    public static readonly string DataFileName   = "data.json";
    public static readonly string ConfigFileName = "config.json";

}