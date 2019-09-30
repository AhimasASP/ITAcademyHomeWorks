using System;
using System.Text;

namespace HW_04_Task_02
{
    public class Painter
    {
        private StringBuilder builder = new StringBuilder();
        private bool baddyDrawed = false;
        public void BaddyDraw(int x, int y)
        {
            if (!((x > 2) && (x < 19)) || !((y > 2) && (y < 19)))
            {
                builder.AppendLine('|' + new string(' ', 18) + '|');
                builder.AppendLine("|  Baddy crushed!  |");
                builder.AppendLine('|' + new string(' ', 18) + '|');
            }
            else
            {
                var leftIndent = '|' + new string(' ', x - 3);
                var rightIndent = new string(' ', 18 - x) + '|';
                builder.AppendLine(leftIndent + " o " + rightIndent);
                builder.AppendLine(leftIndent + "-O-" + rightIndent);
                builder.AppendLine(leftIndent + "/ \\" + rightIndent);

            }
        }
        public void Print(int x, int y)
        {
            string insert = null;
            for (int i = 1; i <= 20; i++)
            {
                if (i == 1 || i == 20)
                {
                    insert = new string('-', 18);
                    builder.AppendLine($"-{insert}-");
                }
                else
                {
                    if (i > (y - 2) && !baddyDrawed)
                    {
                        if (y >= 18)
                        {
                            i = 20;
                        }
                        BaddyDraw(x, y);
                        baddyDrawed = true;
                        i += 2;
                    }
                    else
                    {
                        insert = new string(' ', 18);
                        builder.AppendLine($"|{insert}|");
                    }
                }
            }
            baddyDrawed = false;
            Console.Clear();
            Console.WriteLine("X: " + x + "\tY: " + y);
            Console.WriteLine(builder.ToString());
            builder.Clear();
        }
    }
}