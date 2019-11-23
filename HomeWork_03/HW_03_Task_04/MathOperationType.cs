using System;

namespace HW_03_Task_04
{
    class MathOperationType
    {
        public char ChexkMathType()
        { char sign = ' ';
            bool isMathSign = false;
            while (!isMathSign)
            { sign = Convert.ToChar(Console.ReadLine()[0]);
                if (sign.Equals('+') || sign.Equals('-') || sign.Equals('*') || sign.Equals('/')) isMathSign = true;
                else Console.WriteLine("Your choice incorrect, please try again.");
            }
            switch (sign)
            {
                case '+': Console.WriteLine("Initialization addition operation.");
                    break;
                case '-': Console.WriteLine("Initialization substraction operation.");
                    break;
                case '*': Console.WriteLine("Initialization multiplication operation.");
                    break;
                case '/': Console.WriteLine("Initialization division operation.");
                    break;
            }
            return sign;
        }
    }
}
