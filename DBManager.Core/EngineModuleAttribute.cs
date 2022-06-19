using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters.Engines;
using System;
using System.Windows.Forms;

namespace DBManager.Core
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class EngineModuleAttribute : Attribute
    {
        public string EngineType { get; private set; }
        public Type Model { get; set; }
        public Type Presenter { get; set; }
        public Type ConnectorView { get; set; }

        public EngineModuleAttribute(
            string engineType,
            Type model,
            Type presenter,
            Type connectorView)
        {
            if (typeof(IEngineModel).IsAssignableFrom(model) == false)
                throw new ArgumentException($"{typeof(Type)} does not implement a {nameof(IEngineModel)} interface.");
            
            if (typeof(IEnginePresenter).IsAssignableFrom(presenter) == false)
                throw new ArgumentException($"{nameof(Type)} does not implement a {nameof(IEnginePresenter)} interface.");

            if (typeof(Form).IsAssignableFrom(connectorView) == false)
                throw new ArgumentException($"{nameof(Type)} does not inherit from {nameof(Form)} class.");

            EngineType = engineType;
            Model = model;
            Presenter = presenter;
            ConnectorView = connectorView;
        }
    }
}