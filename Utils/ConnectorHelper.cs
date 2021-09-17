using System.Collections.Generic;

namespace DBManager.Utils
{
    public static class ConnectorHelper
    {
        public static string Combine(Dictionary<string, string> parameters)
        {
            string connectionString = "";

            foreach (var key in parameters.Keys)
            {
                connectionString += $"{key}={parameters[key]};";
            }

            return connectionString;
        }
    }
}
