using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files.Routing;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetConnectionSettingsTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WhenConnectionExists()
    {
        var connection = new Connection
        {
            Name = "connectionName",
            EngineType = "engineType",
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            }
        };

        FileManager.Save(connection, Router.Init().Connection(connection.Name).SettingsPath());

        var response = Act(connection.Name);

        var dto = ResponseAssert.Ok(response);

        Assert.Equal(connection.Name, dto.Name);
        Assert.Equal(connection.EngineType, dto.EngineType);
        Assert.Equal(connection.ConnectionParameters.First().Key, dto.ConnectionParameters.First().Key);
        Assert.Equal(connection.ConnectionParameters.First().Value, dto.ConnectionParameters.First().Value);
    }

    [Fact]
    public void ReturnsError_WhenConnectionNotExist()
    {
        var connection = new Connection
        {
            Name = "connectionName",
        };

        var response = Act(connection.Name);

        ResponseAssert.Error(response);
    }

    private Response<AddConnectionDto> Act(string connectionName)
    {
        var engineModuleResolver = new MockEngineModuleResolver().GetSuccessful();
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.GetConnectionSettings(connectionName);
    }
}
