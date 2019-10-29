using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HomeWork_07 main menu!");
            Motorcycle motorcycle = new Motorcycle();

            //public method
            motorcycle.StartEngine();

            //protected method
            //motorcycle.CheckEngine(); - (protected) not available for instance? only for derived classes

            //internal method
            motorcycle.ChangeColor();

            //protected internal method
            motorcycle.Beep();

            //private method
            //motorcycle.ChangeVin(); - (private) available only in body of class or struct in witch it declare

            //private protected
            //motorcycle.ResetVin(); - (private protected) available only in body of class or struct in witch it declare or in body of derived class

            GarageMadeBike garageBike = new GarageMadeBike();

            garageBike.ResetVin(); // we can get access to private protected method by derived class instance in tha same namespace
        }
    }
}
