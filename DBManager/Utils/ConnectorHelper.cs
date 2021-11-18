using System.Collections.Generic;
using System.Text;

namespace DBManager.Utils
{
    public static class ConnectorHelper
    {
        public static string Combine(Dictionary<string, string> parameters)
        {
            var connectionStringBuilder = new StringBuilder();

            foreach (var key in parameters.Keys)
            {
                connectionStringBuilder.Append($"{key}={parameters[key]};");
            }

            return connectionStringBuilder.ToString();
        }
    }
}
