using System;

namespace HW_03_Task_02
{
    class SimpleAdditionWithCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the HW_03_Task_02 main menu" +
                              "\nNow you should to enter two simple values for addition operation.");
            DigitAdditionCheck additionCheck = new DigitAdditionCheck();
            additionCheck.ResultCheck('+');
            Console.WriteLine("Great! You are very smart!");
        }
    }
}
