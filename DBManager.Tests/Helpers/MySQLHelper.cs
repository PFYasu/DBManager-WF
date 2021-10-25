using MySqlConnector;
using System.Threading.Tasks;

namespace DBManager.Tests.Helpers
{
    public static class MySQLHelper
    {
        public static async Task RemoveDatabase(MySqlConnection connection, string databaseName)
        {
            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                command.CommandText = $"DROP DATABASE IF EXISTS `{databaseName}`;";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
        }
    }
}
