using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit casting

            int a = 255;
            byte b;
            b = (byte)a;

            long l = 123456789L;
            int i;
            i = (int)l;

            double d = 3.14F;
            float f;
            f = (float)d;

            Console.WriteLine("Expliocit casting: " + "\n" + i + "\n" + b + "\n" + f);
            Console.ReadKey();

            //implicit casting

            short s = 256;
            long k = 0;
            k = s;

            byte u = 255;
            int z = 0;
            z = u;




        }
    }
}
