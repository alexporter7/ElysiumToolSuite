namespace ETSCore.Global;

public class DatabaseGlobal {

    public static readonly string CreateConfigTableCommand = @"CREATE TABLE IF NOT EXISTS option (
    id BLOB PRIMARY KEY,
    option_name TEXT NOT NULL,
    option_value TEXT NOT NULL);";

}