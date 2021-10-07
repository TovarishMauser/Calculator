using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Calculator : IAdditional
    {
        int firstNum;
        int secondNum;
        ILogger logger { get; }

        public Calculator(ILogger logger)
        {
            try
            {
                logger.Event("Начало работы!");
                firstNum = Convert.ToInt32(Console.ReadLine());
                secondNum = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Additional()
        {
            try
            {
                Console.WriteLine(firstNum + secondNum);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
        }
    }
}
