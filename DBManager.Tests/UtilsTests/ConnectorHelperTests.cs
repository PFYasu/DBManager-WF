using DBManager.Core.Utils;
using System.Collections.Generic;
using Xunit;

namespace DBManager.Tests.UtilsTests
{
    public class ConnectorHelperTests
    {
        [Fact]
        public void ForParametersInDictionary_ReturnsCorrectConnectionString()
        {
            var parameters = new Dictionary<string, string>
            {
                { "Url", "localhost" },
                { "Port", "3306" },
                { "Uid", "user" },
                { "Password", "pwd123" }
            };

            var result = Act(parameters);

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Contains("Url=localhost;", result);
            Assert.Contains("Port=3306;", result);
            Assert.Contains("Uid=user;", result);
            Assert.Contains("Password=pwd123;", result);
        }


        public string Act(Dictionary<string, string> parameters)
        {
            var result = ConnectorHelper.Combine(parameters);

            return result;
        }
    }
}
