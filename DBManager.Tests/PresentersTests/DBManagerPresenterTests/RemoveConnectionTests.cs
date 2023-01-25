using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files.Routing;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class RemoveConnectionTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WhenConnectionExists()
    {
        var connection = new Connection
        {
            Name = "connectionName",
        };

        FileManager.Save(connection, Router.Init().Connection(connection.Name).SettingsPath());

        var response = Act(connection.Name);

        ResponseAssert.Ok(response);

        FileManager.AssertFileNotExist(Router.Init().Connection(connection.Name).SettingsPath());
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

    private Response Act(string connectionName)
    {
        var engineModuleResolver = new MockEngineModuleResolver().GetSuccessful();
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.RemoveConnection(connectionName);
    }
}
