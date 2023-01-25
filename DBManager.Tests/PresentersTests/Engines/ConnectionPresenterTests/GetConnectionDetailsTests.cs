using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters.Engines;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using DBManager.Utils.Files.Routing;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.Engines.ConnectionPresenterTests;

public class GetConnectionDetailsTests : DBManagerTestBase
{
    [Fact]
    public async Task ReturnsError_WhenConnectionDoesNotExist()
    {
        var response = await Act("not-exist-connection-name");

        ResponseAssert.Error(response);
    }

    [Fact]
    public async Task ReturnsError_WhenEnginePresenterIsNotActivated()
    {
        var engineModuleResolver = new MockEngineModuleResolver()
            .GetSuccessful();

        FileManager.Save(SomeConnection, Router.Init().Connection(SomeConnection.Name).SettingsPath());

        var response = await Act(SomeConnection.Name, engineModuleResolver);

        ResponseAssert.Error(response);
    }

    [Fact]
    public async Task ReturnsOk_WithConnectionDetails()
    {
        var enginePresenter = MockEnginePresenter
            .Init(SomeConnection)
            .WithOk_GetConnectionDetails(new ConnectionDetailsResponseDto { Name = SomeConnection.Name, EngineType = SomeConnection.EngineType })
            .GetSuccessful();

        var engineModuleResolver = new MockEngineModuleResolver()
            .WithEngineType(SomeConnection.EngineType)
            .WithEnginePresenter(enginePresenter)
            .GetSuccessful();

        FileManager.Save(SomeConnection, Router.Init().Connection(SomeConnection.Name).SettingsPath());

        var response = await Act(SomeConnection.Name, engineModuleResolver);

        var dto = ResponseAssert.Ok(response);

        Assert.Equal(SomeConnection.Name, dto.Name);
        Assert.Equal(SomeConnection.EngineType, dto.EngineType);
    }

    private static Connection SomeConnection => new()
    {
        Name = "ConnectionV1",
        EngineType = "MySQL"
    };
    

    private Task<Response<ConnectionDetailsResponseDto>> Act(
        string connectionName, 
        IEngineModuleResolver engineModuleResolver = null)
    {
        engineModuleResolver ??= EngineModuleResolver;

        var sut = new ConnectionPresenter(FileManager, engineModuleResolver);
        return sut.GetConnectionDetails(connectionName);
    }
}
