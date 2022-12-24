using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DBManager.Tests.PresentersTests.DBManagerPresenterTests;

public class UpdateConnectionTests : DBManagerTestBase
{
    [Fact]
    public void ReturnsError_WhenConnectionWithOldNameNotExist()
    {
        var dto = new UpdateConnectionDto
        {
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            },
            EngineType = "someEngineType",
            Name = NewName,
            OldName = OldName
        };

        var response = Act(dto);

        ResponseAssert.Error(response);

        FileManager.AssertFileNotExist(Router.ToConnection(NewName));
    }

    [Fact]
    public void ReturnsError_WhenOldNameIsNotEqualToNewName_AndConnectionWithNewNameExists()
    {
        var existingConnectionWithOldName = new Connection
        {
            Name = OldName,
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someExistingOldNameConnectionKey", "someExistingOldNameConnectionValue" }
            },
        };

        var existingConnectionWithNewName = new Connection
        {
            Name = NewName,
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someExistingNewNameConnectionKey", "someExistingNewNameConnectionValue" }
            },
        };

        FileManager.Save(existingConnectionWithOldName, Router.ToConnection(existingConnectionWithOldName.Name));
        FileManager.Save(existingConnectionWithNewName, Router.ToConnection(existingConnectionWithNewName.Name));

        var dto = new UpdateConnectionDto
        {
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            },
            EngineType = "someEngineType",
            Name = NewName,
            OldName = OldName
        };

        var response = Act(dto);

        ResponseAssert.Error(response);

        var loadedNewNameExistingConnection = FileManager.AssertFileExists<Connection>(Router.ToConnection(NewName));
        var loadedOldNameExistingConnection = FileManager.AssertFileExists<Connection>(Router.ToConnection(OldName));

        Assert.Equal(
            existingConnectionWithNewName.ConnectionParameters.First().Value, 
            loadedNewNameExistingConnection.ConnectionParameters.First().Value);

        Assert.Equal(
            existingConnectionWithOldName.ConnectionParameters.First().Value,
            loadedOldNameExistingConnection.ConnectionParameters.First().Value);
    }

    [Fact]
    public void ReturnsOk_WhenUpdateWasSuccessful()
    {
        var existingConnection = new Connection
        {
            Name = OldName,
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someExistingConnectionKey", "someExistingConnectionValue" }
            },
        };

        FileManager.Save(existingConnection, Router.ToConnection(existingConnection.Name));

        var dto = new UpdateConnectionDto
        {
            ConnectionParameters = new Dictionary<string, string>
            {
                { "someKey", "someValue" }
            },
            EngineType = "someEngineType",
            Name = NewName,
            OldName = OldName
        };

        var response = Act(dto);

        ResponseAssert.Ok(response);

        FileManager.AssertFileNotExist(Router.ToConnection(OldName));
        var loadedExistingConnection = FileManager.AssertFileExists<Connection>(Router.ToConnection(NewName));

        Assert.Equal(
            dto.ConnectionParameters.First().Value,
            loadedExistingConnection.ConnectionParameters.First().Value);
    }

    private const string OldName = "oldName";
    private const string NewName = "newName";

    private Response Act(UpdateConnectionDto dto)
    {
        var engineModuleResolver = new MockEngineModuleResolver().GetSuccessful();
        var sut = new DBManagerPresenter(FileManager, engineModuleResolver);

        return sut.UpdateConnection(dto);
    }
}
