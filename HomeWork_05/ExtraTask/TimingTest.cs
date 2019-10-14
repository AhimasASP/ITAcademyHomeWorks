using System;
using System.Diagnostics;
using HW_05_Task_01;
using HW_05_Task_03;

namespace ExtraTask
{
    public class TimingTest
    {
        ArrayMaker maker = new ArrayMaker();
        public void Test(int length)
        {
            int[] array = maker.RandomArrayMaker(length);
            Console.WriteLine("\nTest of reverse methods for array with " + length + " values:");
            var timer = Stopwatch.StartNew();
            Array.Reverse(array);
            Console.WriteLine("\n\tMSCoreLib method timing: " + timer.Elapsed.TotalMilliseconds);
            timer.Stop();

            timer.Start();
            ArrayReverse.ReverseArray(array);
            timer.Stop();
            Console.WriteLine("\n\tUser method timing: " + timer.Elapsed.TotalMilliseconds);
        }
    }
}