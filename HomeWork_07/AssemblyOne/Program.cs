using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HomeWork_07 main menu!");
            Motorcycle moto = new Motorcycle();

            //public method
            moto.StartEngine();

            //protected method
            //moto.CheckEngine(); - (protected) not available for instance? only for derived classes

            //internal method
            moto.ChangeColor();

            //protected internal method
            moto.Beep();

            //private method
            //moto.ChangeVin(); - (private) available only in body of class or struct in witch it declare

            //private protected
            //moto.ResetVin(); - (private protected) available only in body of class or struct in witch it declare or in body of derived class
        }
    }
}
