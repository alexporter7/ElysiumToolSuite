using System.Data;
using ETSCore.Global;
using ETSCore.Util;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;

namespace ETSCore.Database;

public class ETSDatabaseManager {

    private static ILoggerFactory LogFactory = 
        LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information));
    private static ILogger          Log;
    
    private SqliteConnection ConfigConnection;
    private SqliteConnection ResidentConnection;
    private SqliteConnection CityConnection;
    private SqliteConnection BuildCOnnection;

    public ETSDatabaseManager() {
        Log = LogFactory.CreateLogger<ETSDatabaseManager>();
        Log.LogInformation("ETSDatabase Manager has been initialized");
        LoadConfigDatabase();
        
    }

    private void LoadConfigDatabase() {
        Log.LogInformation($"Attempting to open [{NameGlobal.ConfigDatabaseFileName}]");
        ConfigConnection = new SqliteConnection($"Data Source={NameGlobal.ConfigDatabasePath}");
        ConfigConnection.Open();

        bool configDbExists = DataUtil.CheckTableExists(ConfigConnection, "option");
        if(!configDbExists)
            InitConfigDatabase(ConfigConnection);
        
        
    }

    private void LoadResidentDatabase() {
        Log.LogInformation($"Attemping to open [{NameGlobal.ResidentDatabaseFileName}]");
        ResidentConnection = DataUtil.GetConnection(NameGlobal.ResidentDatabasePath);
    }

    private void InitConfigDatabase(SqliteConnection connection) {
        DataUtil.CreateTable(connection, DatabaseGlobal.CreateConfigTableCommand);
    }


    public SqliteConnection GetConnection() {
        return ConfigConnection;
    }
}