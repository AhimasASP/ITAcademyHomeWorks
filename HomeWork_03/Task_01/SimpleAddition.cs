using System;

namespace HW_03_Task_01
{
    class SimpleAddition
    {

        static void Main(string[] args)
        {
            DigitAddition addition = new DigitAddition();
            Console.WriteLine("\tWelcome to the HW_03_Task_01 main menu" +
                              "\nNow you should to enter two simple values for addition operation.");
            int value = addition.SimpleAdditionTwoValues('+');
            Console.WriteLine("Result of simple addition is: " + value);
        }
    }
}

