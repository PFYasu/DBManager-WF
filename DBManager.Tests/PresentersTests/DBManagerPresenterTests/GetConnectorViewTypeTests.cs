using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetConnectorViewTypeTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WithConnectorViewType()
    {
        const string engineType = "MySQL";

        var engineModuleResolver = new MockEngineModuleResolver()
            .WithEngineType(engineType, connectorViewType: typeof(TestType))
            .GetSuccessful();

        var response = Act(engineType, engineModuleResolver);

        var dto = ResponseAssert.Ok<ConnectorViewTypeResponseDto>(response);

        Assert.Equal(typeof(TestType), dto.ConnectorViewType);
    }

    private class TestType
    {
    }

    private Response<ConnectorViewTypeResponseDto> Act(string engineType, IEngineModuleResolver engineModuleResolver)
    {
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.GetConnectorViewType(engineType);
    }
}
