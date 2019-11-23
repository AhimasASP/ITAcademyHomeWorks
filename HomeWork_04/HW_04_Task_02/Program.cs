using System;

namespace HW_04_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Painter painter = new Painter();
            int x = 10, y = 10;
            var key = ' ';
            while (key != 'E')
            {
                painter.Print(x, y);
                key = Convert.ToChar(Console.ReadKey().Key);
               // Console.WriteLine(new string('\n', 100));
                switch (key)
                {
                    case 'W':
                        y -= 1;
                        break;
                    case 'S':
                        y += 1;
                        break;
                    case 'A':
                        x -= 1;
                        break;
                    case 'D':
                        x += 1;
                        break;
                }
            }
        }
    }
}
