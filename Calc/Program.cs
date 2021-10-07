using System;

namespace Calc
{
    class Program
    {
        static ILogger logger { get; set; }
        static void Main(string[] args)
        {
            logger = new Logger();

            Calculator calc = new Calculator(logger);

            calc.Additional();
        }
    }
}
