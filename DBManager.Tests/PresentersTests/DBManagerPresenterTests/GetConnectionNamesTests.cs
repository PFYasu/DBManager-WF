using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
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

        FileManager.Save(firstConnection, Router.ToConnection(firstConnection.Name));
        FileManager.Save(secondConnection, Router.ToConnection(secondConnection.Name));
        FileManager.Save(thirdConnection, Router.ToConnection(thirdConnection.Name));

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
