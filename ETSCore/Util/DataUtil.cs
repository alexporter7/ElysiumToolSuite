using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace ETSCore.Util;

public class DataUtil {

    private static ILoggerFactory LogFactory =
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));

    private static ILogger Log = LogFactory.CreateLogger<DataUtil>();

    public static SqliteConnection GetConnection(string dbPath) {
        return new SqliteConnection($"Data Source={dbPath}");
    }

    public static bool CheckTableExists(SqliteConnection connection, string tableName) {
        Log.LogInformation($"Checking if [{tableName}] exists");
        var tableCommand = @"SELECT name
                                 FROM sqlite_master
                                 WHERE type='table'
                                     AND name='";
        tableCommand += tableName;
        tableCommand += "'";
        
        using var command = new SqliteCommand(tableCommand, connection);
        var       reader  = command.ExecuteReader();
        if (!reader.HasRows)
            return false;
        return true;
    }

    public static bool CreateTable(SqliteConnection connection, string tableCommand) {
        Log.LogInformation($"Processing request to create table using command [{tableCommand}]");
        
        string tableName = tableCommand.Substring(13).Substring(0, tableCommand.IndexOf("("));
        Log.LogInformation($"Table name identified as [{tableName}]");

        if (CheckTableExists(connection, tableName)) {
            Log.LogInformation($"Table with name [{tableName}] already exists");
            return false;
        }
        
        using var command = new SqliteCommand(tableCommand, connection);
        var       reader  = command.ExecuteReader();
        
        Log.LogInformation($"Validating table [{tableName}] exists");

        if (!CheckTableExists(connection, tableName)) {
            Log.LogError($"Table [{tableName}] was attempted to be created but failed");
            return false;
        }
        
        Log.LogInformation($"Table [{tableName}] has been validated and is now in the database");
        
        return true;
    }

}