using System;

namespace HW_03_Task_01
{
    class SimpleAddition
    {
        public static int SimpleAdditionTwoValues()

        {
            string stringValue;
            int intValue;

            Console.WriteLine("\tWelcome to the HW_03_Task_01 main menue" +
                              "\nNow you should to enter two simple values for addition operation." +
                              "\nPlease enter the first value");

            stringValue = Console.ReadLine();
            Console.WriteLine(stringValue + " - first value;\nPlease enter the second value");
            intValue = Convert.ToInt32(stringValue);
            stringValue = Console.ReadLine();
            Console.WriteLine(stringValue + " - second value;");
            intValue += Convert.ToInt32(stringValue);
            return intValue;
        }
        static void Main(string[] args)
        {
            int value = SimpleAdditionTwoValues();
            Console.WriteLine("Result of simple addition is: " + value);
        }
    }
}
