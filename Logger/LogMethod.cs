using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class LogMethod
    {
        private static readonly object logLock = new object();

        public static void LogError(Exception ex)
        {
            string logFileName = $"Log_{DateTime.Now:yyyyMMdd}.txt";
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logFileName);
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {ex.ToString()}";
            WriteLog(logFilePath, logMessage);
        }

        public static void LogAction(string actionMessage)
        {
            string logFileName = $"Log_{DateTime.Now:yyyyMMdd}.txt";
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logFileName);
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ACTION: {actionMessage}";
            WriteLog(logFilePath, logMessage);
        }

        private static void WriteLog(string logFilePath, string logMessage)
        {
            lock (logLock)
            {
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
        }
    }
}
