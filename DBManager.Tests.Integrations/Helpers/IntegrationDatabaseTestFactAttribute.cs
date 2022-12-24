using Xunit;

namespace DBManager.Tests.Integrations.Helpers;

internal class IntegrationTestFactAttribute : FactAttribute
{
    internal IntegrationTestFactAttribute()
    {
        var postgreSQLConnectionString = Environment.GetEnvironmentVariable(PostgreSQLHelper.ConnectionStringEnvironmentVariable);
        var postgreSQLEscapeDatabase = Environment.GetEnvironmentVariable(PostgreSQLHelper.EscapeDatabaseEnvironmentVariable);
        var mySqlConnectionString = Environment.GetEnvironmentVariable(MySqlHelper.ConnectionStringEnvironmentVariable);

        if (string.IsNullOrEmpty(postgreSQLConnectionString) 
            || string.IsNullOrEmpty(postgreSQLEscapeDatabase)
            || string.IsNullOrEmpty(mySqlConnectionString))
        {
            Skip = "This test uses real database servers. Set " +
                $"{PostgreSQLHelper.ConnectionStringEnvironmentVariable} and " +
                $"{PostgreSQLHelper.EscapeDatabaseEnvironmentVariable} and " +
                $"{MySqlHelper.ConnectionStringEnvironmentVariable} environment variables to run.";
        }
    }
}
