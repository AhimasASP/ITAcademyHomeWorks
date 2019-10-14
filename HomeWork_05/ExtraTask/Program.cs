using System;
using System.Diagnostics;
using HW_05_Task_01;
using HW_05_Task_03;

namespace ExtraTask
{
    class Program
    {
        static void Main(string[] args)
        {   TimingTest test = new TimingTest();
            Console.WriteLine("Timing test of reverse methods");
            test.Test(1000);
            test.Test(10_000);
            test.Test(100_000);
        }
    }
}
