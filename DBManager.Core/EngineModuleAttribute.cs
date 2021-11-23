using System;

namespace DBManager.Core
{
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
            EngineType = engineType;
            Model = model;
            Presenter = presenter;
            ConnectorView = connectorView;
        }
    }
}