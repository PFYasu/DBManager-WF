using DBManager.Core;
using DBManager.EngineModule.SQLite;

// Information about DBManager compatible assembly
[assembly: EngineModule("SQLite", typeof(SQLiteModel), typeof(SQLitePresenter), typeof(SQLiteConnectorView))]
