using System;

namespace HW_05_Task_02
{
    public class ArrayModifier
    {
        public int[] ArrayCreation(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < (arrayLength - 1); i++)
            {
                Console.WriteLine("Please enter value of element number " + (i + 1));
                Int32.TryParse(Console.ReadLine(), out array[i]);
            }
            return array;
        }

        public int[] ModifyArray(int[] array, int positionNumber, int insertingValue)
        {
            for (int i = array.Length - 1; i > positionNumber; i--)
            {
                array[i] = array[i - 1];
            }
            array[positionNumber] = insertingValue;
            return array;
        }
    }
}