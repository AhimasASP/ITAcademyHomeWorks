using System;
using System.Globalization;

namespace HW_04_Task_03
{
    public class Calculator
    {
        public void Calculate(int sum, byte periodInMonth)
        {
            DateTime date = new DateTime(2019, 9, 1);
            decimal currentSum = sum;
            decimal increase;
            decimal capitalization;
            string currency = " BYN";
            
            for (int i = 0; i < periodInMonth; i++)
            {
                date = date.AddMonths(1);
                Console.WriteLine("\nOn the date of " + date.ToString("MMMM yyyy", CultureInfo.CurrentCulture) + 
                                  "\n\n\tIncrease of contribution is:\t" + 
                                  (increase = (capitalization = currentSum * 2 / 100) + currentSum - sum).ToString("0.00") + currency + 
                                  "\n\tThe capitalization is:\t" + (capitalization).ToString("0.00") + currency +
                                  "\n\tCurrent contribution sum is:\t" + (currentSum += (currentSum * 2 / 100)).ToString("0.00") + currency);
            }
        }
    }
}