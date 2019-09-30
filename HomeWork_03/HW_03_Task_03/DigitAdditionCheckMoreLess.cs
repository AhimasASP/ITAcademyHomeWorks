using System;
using HW_03_Task_01;

namespace HW_03_Task_03
{
    public class DigitAdditionCheckMoreLess : DigitAddition
    {
        public void ResultCheckMoreLess(char sign)
        {
            int result = SimpleAdditionTwoValues(sign);
            bool isDigit = false;
            Console.WriteLine("Please enter the answer.");
            while (!isDigit)
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    while (answer != result)
                    {
                        Console.WriteLine("Answer is wrong!");
                        Console.WriteLine(answer < result
                            ? "Here the hint:\n\t The correct answer is more then your variant"
                            : "Here the hint:\n\t The correct answer is less then your variant");
                        Console.WriteLine("Please, try again!");
                        answer = Convert.ToInt32(Console.ReadLine());
                        isDigit = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Please enter digit format answer!");
                }
            }
        }
    }
}