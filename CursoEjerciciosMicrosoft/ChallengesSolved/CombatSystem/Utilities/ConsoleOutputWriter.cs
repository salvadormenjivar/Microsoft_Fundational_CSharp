using System;

namespace CombatSystem.Utilities
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}