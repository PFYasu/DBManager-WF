using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBManager.Core.Utils
{
    public static class ConnectorHelper
    {
        public static string CombineToConnectionString(Dictionary<string, string> parameters)
        {
            var connectionStringBuilder = new StringBuilder();

            foreach (var key in parameters.Keys)
            {
                connectionStringBuilder.Append($"{key}={parameters[key]};");
            }

            return connectionStringBuilder.ToString();
        }

        public static Dictionary<string, string> CombineToDictionary(string connectionString)
        {
            var splittedValues = connectionString.Split(";");

            var parameters = new Dictionary<string, string>();

            foreach (var splittedValue in splittedValues)
            {
                if (string.IsNullOrEmpty(splittedValue))
                    continue;

                var keyValue = splittedValue.Split('=');

                parameters[keyValue.First()] = keyValue.Last();
            }

            return parameters;
        }
    }
}
