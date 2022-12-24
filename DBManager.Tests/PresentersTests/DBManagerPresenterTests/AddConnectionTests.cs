using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Utils.Files;
using System.Collections.Generic;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class AddConnectionTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsError_WhenConnectionWithSpecificNameAlreadyExists()
    {
        const string connectionName = "ConnectionName";

        var connection = new Connection { Name = connectionName };

        var dto = new AddConnectionDto
        {
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            },
            EngineType = "someEngineType",
            Name = "ConnectionName"
        };

        FileManager.Save(connection, Router.ToConnection(connection.Name));

        var response = Act(dto);

        ResponseAssert.Error(response);
    }

    [Fact]
    public void ReturnsOk_WhenConnectionHasUniqueName()
    {
        const string connectionName = "ConnectionName";

        var dto = new AddConnectionDto
        {
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            },
            EngineType = "someEngineType",
            Name = connectionName
        };

        var response = Act(dto);

        ResponseAssert.Ok(response);

        FileManager.AssertFileExists<Connection>(Router.ToConnection(connectionName));
    }

    private Response Act(AddConnectionDto dto)
    {
        var sut = new DBManagerPresenter(FileManager, EngineModuleResolver);

        return sut.AddConnection(dto);
    }
}
