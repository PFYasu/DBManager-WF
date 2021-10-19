using DBManager.Utils;
using System.Collections.Generic;

namespace DBManager.Tests.Helpers
{
    public static class ConnectionParameters
    {
        public static class MySql
        {
            public static readonly Dictionary<string, string> ConnectionParameters = new Dictionary<string, string>
            {
                { "Server", "localhost" },
                { "Port", "3306" },
                { "Uid", "root"},
                { "Pwd", "password" }
            };

            public static readonly string ConnectionString = ConnectorHelper.Combine(ConnectionParameters);
        }

        public static class PostgreSQL
        {
            public static readonly Dictionary<string, string> ConnectionParameters = new Dictionary<string, string>
            {
                { "Server", "localhost" },
                { "Port", "5432" },
                { "Uid", "postgres" },
                { "Pwd", "password" }
            };

            public static readonly string ConnectionString = ConnectorHelper.Combine(ConnectionParameters);

            public const string EscapeDatabase = "postgres";
        }
    }
}
