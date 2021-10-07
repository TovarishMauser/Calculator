using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}
