using System;
using HW_03_Task_01;

namespace HW_03_Task_02
{
    class DigitAdditionCheck : DigitAddition
    {
        public void ResultCheck(char sign)
        {
            int result = SimpleAdditionTwoValues(sign);
            Console.WriteLine("Please enter the answer.");
            int answer = Convert.ToInt32(Console.ReadLine());
            while (answer != result)
            {
                Console.WriteLine("Answer is wrong! Please try again.");
                answer = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
