using System;
using HW_03_Task_03;

namespace HW_03_Task_04
{
    class MathOperationWithCheckMoreLess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the HW_04_Task_03 main menu" +
                              "\nNow you should to choose the math operation and enter two simple " +
                              "values for math operation.\nPlease choose the MATH operation from next variants:" +
                              "\n\t\"+\" - for addition;\n\t\"-\" - for substraction;\n\t\"*\" - for multiplication;\n\t\"/\" - for division.");
            char sign;
            MathOperationType mathType = new MathOperationType();
            sign = mathType.ChexkMathType();
            DigitAdditionCheckMoreLess additionCheck = new DigitAdditionCheckMoreLess();
            additionCheck.ResultCheckMoreLess(sign);
            Console.WriteLine("Excellent! You are right!");
        }
    }
}
