using System;
using System.Threading;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const ushort maxSpeed = 300;
        private string vinCode = "ZFA22500000089618";
        protected int odometer = 30_000;
        internal string color = "red";


        public void StartEngine()
        {
            Console.WriteLine("Orom-Dom-Dom");
        }

        protected void CheckEngine()
        {
            Console.WriteLine("Start diagnostics...");
            Thread.Sleep(2000);
            Console.WriteLine("All systems OK!");
        }

        protected internal void Beep()
        {
            Console.WriteLine("\aBEEEEEEEEEP!");
        }

        internal void ChangeColor(string color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    default : Console.WriteLine("It is a wrong color!");
                        break;
            }
            Console.WriteLine("Current color is " + color);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}