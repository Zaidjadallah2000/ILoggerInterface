using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerInterface
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileLogger.txt");
            var mess = $"{DateTime.Now} {message} {Environment.NewLine}";
            File.AppendAllText(filePath, mess);
        }
    }
}
