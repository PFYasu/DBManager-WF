using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class GetDatabaseNamesTests : DBManagerTestBase
{
    [Fact]
    public async Task ReturnsOk_WhenConnectionExists()
    {
        var connection = new Connection
        {
            Name = "connectionName",
            EngineType = "MySql",
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            }
        };

        var names = new List<string>()
        {
            "Orders",
            "Products"
        };

        var enginePresenter = MockEnginePresenter
             .Init(connection)
             .WithOk_GetDatabaseNames(new DatabaseNamesResponseDto { Names = names })
             .GetSuccessful();

        var engineModuleResolver = new MockEngineModuleResolver()
            .WithEngineType(connection.EngineType)
            .WithEnginePresenter(enginePresenter)
            .GetSuccessful();

        FileManager.Save(connection, Router.ToConnection(connection.Name));

        var response = await Act(connection.Name, engineModuleResolver);

        var dto = ResponseAssert.Ok(response);

        Assert.Equal(2, dto.Names.Count);
        Assert.Equal(dto.Names[0], names[0]);
        Assert.Equal(dto.Names[1], names[1]);
    }

    [Fact]
    public async Task ReturnsError_WhenConnectionNotExist()
    {
        var connection = new Connection
        {
            Name = "connectionName",
        };

        var response = await Act(connection.Name);

        ResponseAssert.Error(response);
    }

    private Task<Response<DatabaseNamesResponseDto>> Act(string connectionName, IEngineModuleResolver engineModuleResolver = null)
    {
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver ?? EngineModuleResolver);

        return sut.GetDatabaseNames(connectionName);
    }
}
