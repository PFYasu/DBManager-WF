using DBManager.Core.Models;
using DBManager.Core.Presenters.Engines;
using DBManager.Utils.Files;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DBManager.Tests.Mocks;

public class MockEngineModuleResolver
{
    private readonly List<IEnginePresenter> _enginePresenters = new();
    private readonly Dictionary<string, EngineModule> _engineModules = new();

    public MockEngineModuleResolver WithEnginePresenter(IEnginePresenter enginePresenter)
    {
        _enginePresenters.Add(enginePresenter);

        return this;
    }

    public MockEngineModuleResolver WithEngineType(string engineType, Type connectorViewType = null)
    {
        _engineModules.Add(engineType, new EngineModule
        {
            ConnectorViewType = connectorViewType
        });

        return this;
    }

    public IEngineModuleResolver GetSuccessful()
    {
        var mock = new Mock<IEngineModuleResolver>();

        mock.Setup(x => x.CreateEnginePresenter(It.Is<Connection>(o => _engineModules.ContainsKey(o.EngineType))))
            .Returns((Connection connection) =>
            {
                return _enginePresenters.SingleOrDefault(x => x.ConnectionName == connection.Name);
            });

        mock.Setup(x => x.CreateEnginePresenter(
                It.Is<Connection>(o => _engineModules.ContainsKey(o.EngineType) == false)))
            .Throws<InvalidOperationException>();

        mock.Setup(x => x.GetEngineModuleNames())
            .Returns(_engineModules.Keys.ToList());

        mock.Setup(x => x.GetConnectorViewType(It.Is<string>(o => _engineModules.ContainsKey(o))))
            .Returns((string engineType) =>
            {
                return _engineModules[engineType].ConnectorViewType;
            });

        mock.Setup(x => x.GetConnectorViewType(It.Is<string>(o => _engineModules.ContainsKey(o) == false)))
            .Throws<InvalidOperationException>();

        return mock.Object;
    }

    private class EngineModule
    {
        public Type ConnectorViewType { get; set; }
    }
}
