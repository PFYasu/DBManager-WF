using DBManager.Core;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DBManager
{
    public static class EngineModules
    {
        private static readonly Lazy<Dictionary<string, EngineModuleAttribute>> _attributes
            = new Lazy<Dictionary<string, EngineModuleAttribute>>(GetAttributes);

        public static Dictionary<string, EngineModuleAttribute> Attributes = _attributes.Value;

        private static Dictionary<string, EngineModuleAttribute> GetAttributes()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var files = Directory.GetFiles(path, Constants.EngineModules.AssemblyNamePattern, SearchOption.AllDirectories);

            var attributes = new Dictionary<string, EngineModuleAttribute>();

            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(file);
                var engineModuleAttributes = assembly.GetCustomAttributes<EngineModuleAttribute>();

                foreach (var engineModuleAttribute in engineModuleAttributes)
                {
                    if (engineModuleAttribute != null)
                        attributes.Add(engineModuleAttribute.EngineType, engineModuleAttribute);
                }
            }

            return attributes;
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var dllName = new AssemblyName(args.Name).Name;
            var fullDllName = $"{dllName}.dll";
            var currentDirectoryPath = Directory.GetCurrentDirectory();

            var dllPaths = Directory.GetFiles(currentDirectoryPath, fullDllName, SearchOption.AllDirectories);
            var dllPath = dllPaths.FirstOrDefault();

            return dllPath == null
                ? null
                : Assembly.LoadFile(dllPath);
        }
    }
}
