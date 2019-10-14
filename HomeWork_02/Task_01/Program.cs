using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 123456789123.12D;
            int i = 2147483647;
            int j;
            short s;
            byte b;
            float f;
            object o;

            //explicit casting - possible distortion of value!

            s = (short)i;
            b = (byte)i;
            f = (float)d;

            
            //implicit casting - safe casting method

            b = 255;
            f = 123456.5F;
            i = b;
            s = b;
            d = f;

            //Boxing

            o = i;

            //Unboxing

            j = (int)o;
        }
    }
}
