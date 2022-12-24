using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using Moq;

namespace DBManager.Tests.Mocks;

public class MockEnginePresenter
{
    private readonly Mock<IEnginePresenter> _mock = new();

    private MockEnginePresenter(Connection connection)
    {
        _mock.Setup(x => x.EngineType).Returns(connection.EngineType);
        _mock.Setup(x => x.ConnectionName).Returns(connection.Name);
    }

    public static MockEnginePresenter Init(Connection connection) => new(connection);

    public MockEnginePresenter WithOk_GetDatabaseNames(DatabaseNamesResponseDto dto)
    {
        _mock.Setup(x => x.GetDatabaseNames())
            .ReturnsAsync(Response<DatabaseNamesResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetDatabaseNames(string errorMessage)
    {
        _mock.Setup(x => x.GetDatabaseNames())
            .ReturnsAsync(Response<DatabaseNamesResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_GetTableNames(TableNamesResponseDto dto)
    {
        _mock.Setup(x => x.GetTableNames(It.IsAny<string>()))
            .ReturnsAsync(Response<TableNamesResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetTableNames(string errorMessage)
    {
        _mock.Setup(x => x.GetTableNames(It.IsAny<string>()))
            .ReturnsAsync(Response<TableNamesResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_SendQuery(QueryResponseDto dto)
    {
        _mock.Setup(x => x.SendQuery(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(Response<QueryResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_SendQuery(string errorMessage)
    {
        _mock.Setup(x => x.SendQuery(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(Response<QueryResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_GetTableDetails(TableDetailsResponseDto dto)
    {
        _mock.Setup(x => x.GetTableDetails(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(Response<TableDetailsResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetTableDetails(string errorMessage)
    {
        _mock.Setup(x => x.GetTableDetails(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(Response<TableDetailsResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_GetDatabaseDetails(DatabaseDetailsResponseDto dto)
    {
        _mock.Setup(x => x.GetDatabaseDetails(It.IsAny<string>()))
            .ReturnsAsync(Response<DatabaseDetailsResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetDatabaseDetails(string errorMessage)
    {
        _mock.Setup(x => x.GetDatabaseDetails(It.IsAny<string>()))
            .ReturnsAsync(Response<DatabaseDetailsResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_GetDatabaseTableColumns(DatabaseTableColumnsResponseDto dto)
    {
        _mock.Setup(x => x.GetDatabaseTableColumns(It.IsAny<string>()))
            .ReturnsAsync(Response<DatabaseTableColumnsResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetDatabaseTableColumns(string errorMessage)
    {
        _mock.Setup(x => x.GetDatabaseTableColumns(It.IsAny<string>()))
            .ReturnsAsync(Response<DatabaseTableColumnsResponseDto>.Error(errorMessage));

        return this;
    }

    public MockEnginePresenter WithOk_GetConnectionDetails(ConnectionDetailsResponseDto dto)
    {
        _mock.Setup(x => x.GetConnectionDetails())
            .ReturnsAsync(Response<ConnectionDetailsResponseDto>.Ok(dto));

        return this;
    }

    public MockEnginePresenter WithError_GetConnectionDetails(string errorMessage)
    {
        _mock.Setup(x => x.GetConnectionDetails())
            .ReturnsAsync(Response<ConnectionDetailsResponseDto>.Error(errorMessage));

        return this;
    }

    public IEnginePresenter GetSuccessful() => _mock.Object;
}
