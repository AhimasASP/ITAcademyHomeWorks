using System;
using Microsoft.VisualBasic;

namespace HW_04_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 122; i > 96; i--)
            {
                Console.WriteLine(Strings.ChrW(i));
            }
        }
    }
}
