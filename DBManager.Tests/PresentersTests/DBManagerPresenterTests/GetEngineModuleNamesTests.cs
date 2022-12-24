using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetEngineModuleNamesTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsOk_WithCorrectEngineModuleNames()
    {
        const string firstEngineType = "MySQL";
        const string secondEngineType = "PostgreSQL";

        var engineModuleResolver = new MockEngineModuleResolver()
            .WithEngineType(firstEngineType)
            .WithEngineType(secondEngineType)
            .GetSuccessful();
            
        var response = Act(engineModuleResolver);

        var dto = ResponseAssert.Ok(response);

        Assert.Contains(firstEngineType, dto.Names);
        Assert.Contains(secondEngineType, dto.Names);
    }

    private Response<EngineModuleNamesResponseDto> Act(IEngineModuleResolver engineModuleResolver)
    {
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.GetEngineModuleNames();
    }
}
