using System;
using System.Text;

namespace HW_05_Task_01
{
    public class ArrayMaker
    {
        public string ShowArray(int[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var value in array)
            {
                builder.Append(value.ToString());
                builder.Append(", ");
            }
            return new string("[" + builder.ToString().Substring(0, builder.ToString().Length - 2) + "]");
        }

        public int[] RandomArrayMaker(int arrayLength)
        {
            int[] randomArray = new int[arrayLength];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(1, 100);
            }
            return randomArray;
        }

        public int[] UserArrayMaker(int arrayLength)
        {
            int[] userArray = new int[arrayLength];
            for (int i = 0; i < userArray.Length; i++)
            {
                bool isDigit = false;
                while (!isDigit)
                {
                    Console.WriteLine("\nPlease enter value of element number " + (i + 1));
                    try
                    {
                        userArray[i] = Convert.ToInt32(Console.ReadLine());
                        isDigit = true;
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine(new string('-', 47) +
                                          "\n| Error! Please enter the digit format value! |\n" +
                                          new string('-', 47));
                    }
                }
            }
            return userArray;
        }

        public int[] ArrayAddition(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = array1[i] + array2[i];
            }
            return resultArray;
        }
    }
}