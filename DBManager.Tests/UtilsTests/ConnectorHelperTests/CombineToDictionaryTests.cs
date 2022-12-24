using DBManager.Core.Utils;
using System.Collections.Generic;
using Xunit;

namespace DBManager.Tests.UtilsTests.ConnectorHelperTests;

public class CombineToDictionaryTests
{
    [Fact]
    public void ForParametersInConnectionString_ReturnsCorrectParametersInDictionary()
    {
        const string connectionString = "Url=localhost;Port=3306;Uid=user;Password=pwd123;";

        var result = Act(connectionString);

        Assert.NotNull(result);
        Assert.NotEmpty(result);

        Assert.Equal(4, result.Count);

        Assert.Contains("Url", result.Keys);
        Assert.Contains("localhost", result.Values);

        Assert.Contains("Port", result.Keys);
        Assert.Contains("3306", result.Values);

        Assert.Contains("Uid", result.Keys);
        Assert.Contains("user", result.Values);

        Assert.Contains("Password", result.Keys);
        Assert.Contains("pwd123", result.Values);
    }


    public static Dictionary<string, string> Act(string connectionString)
        => ConnectorHelper.CombineToDictionary(connectionString);
}
