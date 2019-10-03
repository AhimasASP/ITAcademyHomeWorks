using System;
using System.Linq;
using System.Text;

namespace HW_05_Task_01
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] randomArray = new int[6];
            int[] userArray = new int[6];
            Console.WriteLine("Hello! Welcome to the Task_01 main menu\n\tFirst RANDOM array is:\n\t");
            ArrayMaker maker = new ArrayMaker();
            userArray = maker.UserArrayMaker(6);
            Console.WriteLine("\nThere is the results:\n\tRandom array: " + maker.ShowArray(randomArray = maker.RandomArrayMaker(6)) + 
                              "\n\tUser array: " + maker.ShowArray(userArray) + 
                              "\n\tResult array: " + maker.ShowArray(maker.ArrayAddition(randomArray, userArray)));
        }
    }
}
