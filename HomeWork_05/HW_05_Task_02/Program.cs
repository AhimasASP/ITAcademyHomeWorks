using System;
using HW_05_Task_01;

namespace HW_05_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   ArrayModifier modifier = new ArrayModifier();
            ArrayMaker printer = new ArrayMaker();
            int[] array;
            int insertingPosition;
            int insertingValue;
            Console.WriteLine("Hello! Welcome to HW_06_Task_02 main menu\n\tPlease enter the array values");
            array = modifier.ArrayCreation(new Random().Next(5, 15));
            Console.WriteLine(printer.ShowArray(array));
            Console.WriteLine("Please enter position of inserting element");
            Int32.TryParse(Console.ReadLine(), out insertingPosition);
            Console.WriteLine("\nPlease enter inserting element value");
            Int32.TryParse(Console.ReadLine(), out insertingValue);
            Console.WriteLine("The modified array is: " + printer.ShowArray(modifier.ModifyArray(array, insertingPosition, insertingValue)));
        }
    }
}
