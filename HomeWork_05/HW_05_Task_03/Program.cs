using System;
using HW_05_Task_01;

namespace HW_05_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {   ArrayMaker maker = new ArrayMaker();
            //ArrayReverse reverse = new ArrayReverse();
            
            Console.WriteLine("Welcome to HW_05_Task_03 main menu\n\tPlease enter array length");
            int[] srcArray = maker.RandomArrayMaker(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("The source array is:\n" + maker.ShowArray(srcArray) + "\nPress any key to reverse the source array");
            Console.ReadKey();
            Console.WriteLine("The reversed array in:\n" + maker.ShowArray(ArrayReverse.ReverseArray(srcArray)));
            Array.Reverse(srcArray);
        }
    }
}
