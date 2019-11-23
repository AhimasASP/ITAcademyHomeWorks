using System.Linq;

namespace HW_05_Task_03
{
    public static class ArrayReverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int tmpValue;
            for (int i = 0; i < array.Length / 2; i++)
            {
                tmpValue = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmpValue;
            }
            return array;
        }
    }
}