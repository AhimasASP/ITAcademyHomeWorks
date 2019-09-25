using System;
using System.Collections;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //signed simple types
            sbyte sb0 = 127;
            SByte sb1 = -127;
            short sh0 = -32768;
            Int16 sh1 = 32767;
            int i0 = -2147483648;
            Int32 i1 = 2147483647;
            long l0 = -9223372036854775808;
            Int64 l1 = 9223372036854775807;

            //unsigned simple types
            byte b0 = 0;
            Byte b1 = 255;
            ushort ush0 = 0;
            UInt16 ush1 = 65535;
            uint ui0 = 0;
            UInt32 ui1 = 4294967295;
            ulong ul0 = 0;
            UInt64 ul1 = 18446744073709551615;

            //unicode character simple type
            char ch0 = 'a';
            Char ch1 = 'b';

            //simple types with floating-point
            float fl0 = 0;
            Single fl1 = 123456.15F;
            double d0 = 0;
            Double d1 = 123456789.99D;

            //high-precision decimal floating-point simple type
            decimal dec0 = 0;
            Decimal dec1 = 9999999999999999999;

            //boolean simple type
            bool bo0 = false;
            Boolean bo1 = true;

            //reference class types
            object obj0 = new Object();
            Object obj1 = new Object();
            string str0 = "ITAcademy";
            String str1 = "C# the best programming language";

            ArrayList list = new ArrayList() {
                sb0, sb1, sh0, sh1, i0, i1, l0, l1,
                b0, b1, ush0, ush1, ui0, ui1, ul0, ul1,
                ch0, ch1, fl0, fl1, d0, d1, dec0, dec1,
                bo0, bo1, obj0, obj1, str0, str1
            };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].GetType());
            }
        }
    }
}
