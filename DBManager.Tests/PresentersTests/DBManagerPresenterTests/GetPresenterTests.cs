using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetPresenterTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WhenConnectionExists()
    {
        var connection = new Connection
        {
            Name = "connectionName",
            EngineType = "engineType"
        };

        var enginePresenter = MockEnginePresenter
            .Init(connection)
            .GetSuccessful();

        var engineModuleResolver = new MockEngineModuleResolver()
            .WithEngineType(connection.EngineType)
            .WithEnginePresenter(enginePresenter)
            .GetSuccessful();

        FileManager.Save(connection, Router.ToConnection(connection.Name));

        var response = Act(connection.Name, engineModuleResolver);

        var dto = ResponseAssert.Ok(response);

        Assert.Equal(connection.Name, dto.Presenter.ConnectionName);
        Assert.Equal(connection.EngineType, dto.Presenter.EngineType);
    }

    [Fact]
    public void ReturnsError_WhenSpecifiedEngineTypeIsNotImplemented()
    {
        var connection = new Connection
        {
            Name = "connectionName",
            EngineType = "unknownEngineType"
        };

        var engineModuleResolver = new MockEngineModuleResolver()
            .GetSuccessful();

        FileManager.Save(connection, Router.ToConnection(connection.Name));

        var response = Act(connection.Name, engineModuleResolver);

        ResponseAssert.Error(response);
    }

    private Response<PresenterResponseDto> Act(string connectionName, IEngineModuleResolver engineModuleResolver)
    {
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.GetPresenter(connectionName);
    }
}
