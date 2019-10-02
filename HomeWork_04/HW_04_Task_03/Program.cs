using System;

namespace HW_04_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("\tHello! Welcome to IT-Bank Calculator.\nResults of calculation:\n");
            calculator.Calculate(1000, 12);
            Console.WriteLine(new string('-', 100) + "\n\tTHANKS FOR CHOOSING US");
        }
    }
}
