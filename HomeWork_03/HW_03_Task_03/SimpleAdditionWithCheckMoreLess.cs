using System;

namespace HW_03_Task_03
{
    class SimpleAdditionWithCheckMoreLess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the HW_03_Task_03 main menu" +
                              "\nNow you should to enter two simple values for addition operation.");
            DigitAdditionCheckMoreLess additionCheck = new DigitAdditionCheckMoreLess();
            additionCheck.ResultCheckMoreLess('+');
            Console.WriteLine("Excellent! You are right!");
        }
    }
}
