using System;

namespace DBManager.Core.Utils.Log
{
    public static class TestDetector
    {
        public static readonly bool IsTestEnvironment = false;

        static TestDetector()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                var assemblyName = assembly.FullName.ToLowerInvariant();

                if (assemblyName.StartsWith(Constants.Logs.TestAssemblyPrefix))
                {
                    IsTestEnvironment = true;
                    break;
                }
            }
        }
    }
}
