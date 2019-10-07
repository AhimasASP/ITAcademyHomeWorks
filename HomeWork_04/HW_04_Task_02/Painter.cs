using System;
using System.Text;

namespace HW_04_Task_02
{
    public class Painter
    {
        private StringBuilder builder = new StringBuilder();
        private bool buddyDrawed = false;

        public void BuddyCrashDraw(bool yBig)
        {
            if (!yBig) builder.AppendLine('|' + new string(' ', 18) + '|');
            builder.AppendLine("|  Buddy crushed!  |");
            builder.AppendLine('|' + new string(' ', 18) + '|');
            if (yBig) builder.AppendLine(new string('-', 20));
        }
        public void BuddyDraw(int x, int y)
        {
            if (!((x > 2) && (x < 19)) || !((y > 2) && (y < 19)))
            {
                BuddyCrashDraw(false);
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
                if ((i == 18) && !buddyDrawed)
                {
                    BuddyCrashDraw(true);
                    buddyDrawed = true;
                    i = 20;
                }
                else if (i == 1 || i == 20)
                {
                    insert = new string('-', 18);
                    builder.AppendLine($"-{insert}-");
                }
                else if ((i > (y - 2)) && !buddyDrawed)
                {
                    BuddyDraw(x, y);
                    buddyDrawed = true;
                    i += 2;
                }
                else
                {
                    insert = new string(' ', 18);
                    builder.AppendLine($"|{insert}|");
                }
            }
            buddyDrawed = false;
            Console.Clear();
            Console.WriteLine("X: " + x + "\tY: " + y);
            Console.WriteLine(builder.ToString());
            builder.Clear();
        }
    }
}