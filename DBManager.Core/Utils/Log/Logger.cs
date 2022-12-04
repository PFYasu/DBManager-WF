using System;
using System.IO;

namespace DBManager.Core.Utils.Log;

public static class Logger
{
    private static object _locker = new();

    public static void Log(LogType logType, string message)
    {
        if (TestDetector.IsTestEnvironment)
            return;

        if (string.IsNullOrEmpty(message))
            return;

        lock (_locker)
        {
            var date = DateTime.UtcNow;

            using (var streamWriter = new StreamWriter(Constants.Logs.LogFileName, append: true))
            {
                streamWriter.WriteLine($"[{logType}] {date}: {message}");
            }
        }
    }
}
