using Npgsql;
using System.Threading.Tasks;

namespace DBManager.Tests.Helpers
{
    public static class PostgreSQLHelper
    {
        public async static Task RemoveDatabase(NpgsqlConnection connection, string databaseName)
        {
            using (var command = connection.CreateCommand())
            {
                await connection.OpenAsync();

                await connection.ChangeDatabaseAsync(ConnectionParameters.PostgreSQL.EscapeDatabase);

                command.CommandText =
                    $"SELECT " +
                        $"pg_terminate_backend(pg_stat_activity.pid) " +
                    $"FROM pg_stat_activity " +
                    $"WHERE " +
                    $"pg_stat_activity.datname = '{databaseName}' " +
                    $"AND pid<> pg_backend_pid();";
                await command.ExecuteNonQueryAsync();

                command.CommandText = $"DROP DATABASE IF EXISTS {databaseName};";
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
        }
    }
}
