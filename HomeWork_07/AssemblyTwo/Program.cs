using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now we can see the derived class instance");
            SportBike sportBike = new SportBike();
            sportBike.StartEngine();
            sportBike.CheckEngine(); // we can get access to base protected method by instance of derived class
            sportBike.Beep(); // easy access to protected internal method of base class
            sportBike.ChangeColor(); // no access to internal base class method
            sportBike.ChangeVin(); // no access to private method of base class
            sportBike.ResetVin(); // no access to private protected method of base class for derived class in another namespace
        }
    }
}
