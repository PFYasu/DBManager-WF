using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Presenters;
using DBManager.Tests.Assertion;
using DBManager.Tests.Mocks;
using DBManager.Utils.Files.Routing;
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

        FileManager.AssertFileNotExist(Router.Init().Connection(NewName).SettingsPath());
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

        FileManager.Save(existingConnectionWithOldName, Router.Init().Connection(existingConnectionWithOldName.Name).SettingsPath());
        FileManager.Save(existingConnectionWithNewName, Router.Init().Connection(existingConnectionWithNewName.Name).SettingsPath());

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

        var loadedNewNameExistingConnection = FileManager.AssertFileExists<Connection>(Router.Init().Connection(NewName).SettingsPath());
        var loadedOldNameExistingConnection = FileManager.AssertFileExists<Connection>(Router.Init().Connection(OldName).SettingsPath());

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

        FileManager.Save(existingConnection, Router.Init().Connection(existingConnection.Name).SettingsPath());

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

        FileManager.AssertFileNotExist(Router.Init().Connection(OldName).SettingsPath());
        var loadedExistingConnection = FileManager.AssertFileExists<Connection>(Router.Init().Connection(NewName).SettingsPath());

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
