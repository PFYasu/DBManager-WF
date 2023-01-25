using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files.Routing;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetConnectionNamesTest : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WithCorrectConnectionNames()
    {
        var firstConnection = new Connection { Name = "MySQLConnection" };
        var secondConnection = new Connection { Name = "PostgreSQLConnection" };
        var thirdConnection = new Connection { Name = "SecondMySQLConnection" };

        FileManager.Save(firstConnection, Router.Init().Connection(firstConnection.Name).SettingsPath());
        FileManager.Save(secondConnection, Router.Init().Connection(secondConnection.Name).SettingsPath());
        FileManager.Save(thirdConnection, Router.Init().Connection(thirdConnection.Name).SettingsPath());

        var response = Act();

        var dto = ResponseAssert.Ok<ConnectionNamesResponseDto>(response);

        Assert.Contains(firstConnection.Name, dto.Names);
        Assert.Contains(secondConnection.Name, dto.Names);
        Assert.Contains(thirdConnection.Name, dto.Names);
    }

    private Response<ConnectionNamesResponseDto> Act()
    {
        var engineModuleResolver = new MockEngineModuleResolver().GetSuccessful();
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.GetConnectionNames();
    }
}
