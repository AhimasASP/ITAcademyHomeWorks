using System;

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
        public int SimpleAdditionTwoValues(char sign)
        {
            int intValue;
            Console.WriteLine("\nPlease enter the first value");
            Console.Write((intValue = CheckForDigit()) + " - first value;\nPlease enter the second value\n");
            int result = intValue;
            Console.WriteLine((intValue = CheckForDigit()) + " - second value;");
            switch (sign)
            {
                case '+':
                    result +=intValue;
                    break;
                case '-':
                    result -= intValue;
                    break;
                case '*':
                    result *= intValue;
                    break;
                case '/':
                    result /= intValue;
                    break;
            }
            return result;
        }
    }
}
