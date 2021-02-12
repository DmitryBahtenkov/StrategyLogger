using System;

namespace StrategyLogger
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{DateTime.Now} | ERROR: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{DateTime.Now} | INFO: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }
}