using DBManager.Core;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DBManager
{
    public static class EngineModules
    {
        private static readonly Lazy<Dictionary<string, EngineModuleAttribute>> attributes
            = new Lazy<Dictionary<string, EngineModuleAttribute>>(GetAttributes);

        public static Dictionary<string, EngineModuleAttribute> Attributes = attributes.Value;

        private static Dictionary<string, EngineModuleAttribute> GetAttributes()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var files = Directory.GetFiles(path, Constants.EngineModules.AssemblyNamePattern);

            var attributes = new Dictionary<string, EngineModuleAttribute>();

            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(file);
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    var attribute = Attribute.GetCustomAttribute(type, typeof(EngineModuleAttribute));

                    if (attribute != null)
                    {
                        var engineModuleAttribute = attribute as EngineModuleAttribute;
                        attributes.Add(engineModuleAttribute.EngineType, engineModuleAttribute);
                    }
                }
            }

            return attributes;
        }
    }
}
