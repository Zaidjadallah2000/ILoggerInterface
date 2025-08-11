using System;
namespace ILoggerInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger filelogger = new FileLogger();
            filelogger.Log("This Is File Logger");
            ILogger consolelogger = new ConsoleLogger();
            consolelogger.Log("This Is Console Logger");

        }

       
    }
}