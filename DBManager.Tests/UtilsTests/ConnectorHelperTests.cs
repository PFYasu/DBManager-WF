using DBManager.Utils;
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

            var results = ConnectorHelper.Combine(parameters);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
            Assert.Contains("Url=localhost;", results);
            Assert.Contains("Port=3306;", results);
            Assert.Contains("Uid=user;", results);
            Assert.Contains("Password=pwd123;", results);
        }
    }
}
