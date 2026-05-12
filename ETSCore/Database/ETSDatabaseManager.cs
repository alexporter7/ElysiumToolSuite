using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace ETSCore.Database;

public class ETSDatabaseManager {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private static ILogger          Log;
    private        SqliteConnection ConfigConnection;

    public ETSDatabaseManager() {
        Log = LogFactory.CreateLogger<ETSDatabaseManager>();
        Log.LogInformation("ETSDatabase Manager has been initialized");
        LoadConfigDatabase();
        
    }

    private void LoadConfigDatabase() {
        Log.LogInformation("Attempting to open config.db");
        ConfigConnection = new SqliteConnection("Data Source=config.db");
        ConfigConnection.Open();

        var OptionTableCommand = @"SELECT name
                                 FROM sqlite_master
                                 WHERE type='table'
                                     AND name='option'";
        using var command = new SqliteCommand(OptionTableCommand, ConfigConnection);
        //command.ExecuteNonQuery();
        var reader = command.ExecuteReader();
        if(!reader.HasRows)
            InitConfigDatabase();
        
        
    }

    private void InitConfigDatabase() {
        
    }


    public SqliteConnection GetConnection() {
        return ConfigConnection;
    }
}