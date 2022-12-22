using DBManager.Core;
using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters.Engines;
using System;

namespace DBManager.Utils;

public interface IDBManagerActivator
{
    IEnginePresenter ActivateEnginePresenter(
        EngineModuleAttribute engineModuleAttribute, 
        Connection connection,
        DataTransferMethods dataTransferMethods);
}

public class DBManagerActivator : IDBManagerActivator
{
    public IEnginePresenter ActivateEnginePresenter(
        EngineModuleAttribute engineModuleAttribute, 
        Connection connection,
        DataTransferMethods dataTransferMethods)
    {
        var model = (IEngineModel)Activator.CreateInstance(
            engineModuleAttribute.Model,
            connection);

        var presenter = (IEnginePresenter)Activator.CreateInstance(
            engineModuleAttribute.Presenter,
            model,
            dataTransferMethods);

        return presenter;
    }
}
