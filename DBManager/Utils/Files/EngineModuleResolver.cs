using DBManager.Core;
using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters.Engines;
using DBManager.Core.Utils.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DBManager.Utils.Files;

public interface IEngineModuleResolver
{
    IEnginePresenter CreateEnginePresenter(Connection connection, DataTransferMethods dataTransferMethods);
    Type GetConnectorViewType(string engineType);
    List<string> GetEngineModuleNames();
}

public class EngineModuleResolver : IEngineModuleResolver
{
    private readonly Dictionary<string, EngineModuleAttribute> _engineModuleAttributes = new();

    public EngineModuleResolver()
    {
        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var files = Directory.GetFiles(path, Constants.EngineModules.AssemblyNamePattern, SearchOption.AllDirectories);

        foreach (var file in files)
        {
            var assembly = Assembly.LoadFile(file);
            var engineModuleAttributes = assembly.GetCustomAttributes<EngineModuleAttribute>();

            foreach (var engineModuleAttribute in engineModuleAttributes)
            {
                if (engineModuleAttribute == null)
                    continue;

                _engineModuleAttributes.Add(engineModuleAttribute.EngineType, engineModuleAttribute);
                Logger.Log(LogType.Information, $"Found {engineModuleAttribute.EngineType} engine type.");
            }
        }
    }

    public IEnginePresenter CreateEnginePresenter(Connection connection, DataTransferMethods dataTransferMethods)
    {
        var engineModuleAttribute = _engineModuleAttributes[connection.EngineType];

        var model = (IEngineModel)Activator.CreateInstance(
            engineModuleAttribute.Model,
            connection);

        var presenter = (IEnginePresenter)Activator.CreateInstance(
            engineModuleAttribute.Presenter,
            model,
            dataTransferMethods);

        return presenter;
    }

    public Type GetConnectorViewType(string engineType)
    {
        var engineModuleAttribute = _engineModuleAttributes[engineType];

        return engineModuleAttribute.ConnectorView;
    }

    public List<string> GetEngineModuleNames()
        => _engineModuleAttributes.Keys.ToList();
}
