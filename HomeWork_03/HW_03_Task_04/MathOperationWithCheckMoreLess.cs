using System;
using HW_03_Task_03;

namespace HW_03_Task_04
{
    class MathOperationWithCheckMoreLess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the HW_04_Task_03 main menu" +
                              "\nNow you should to enter two simple values for addition operation.");
            DigitAdditionCheckMoreLess additionCheck = new DigitAdditionCheckMoreLess();
            additionCheck.ResultCheckMoreLess('+');
            Console.WriteLine("Excellent! You are right!");
        }
    }
}
