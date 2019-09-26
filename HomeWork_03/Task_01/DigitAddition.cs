using System;
using System.Collections.Generic;
using System.Text;

namespace HW_03_Task_01
{
    public class DigitAddition
    {
        public int CheckForDigit()
        {
            int value = 0;
            bool isDigit = false;
            while (isDigit == false)
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    isDigit = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Please enter digit format value!");
                }
            }
            return value;
        }
        public int SimpleAdditionTwoValues()

        {
            int intValue;
            int result;
            Console.WriteLine("\nPlease enter the first value");
            Console.Write((intValue = CheckForDigit()) + " - first value;\nPlease enter the second value\n");
            result = intValue;
            Console.WriteLine((intValue = CheckForDigit()) + " - second value;");
            return result += intValue;
        }
    }
}
