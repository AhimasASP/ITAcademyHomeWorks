using System;
using System.IO;
using System.Net;

namespace HW_06_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   
            string srcString = File.ReadAllText(Environment.CurrentDirectory.Replace(@"HW_06_Task_02\bin\Debug\netcoreapp3.0", "") + @"\panagramm.txt");
            StringModifier modifier = new StringModifier(srcString);
            Console.WriteLine("There is source string: " + srcString + "\nThere source string without longest word: " + 
                              modifier.longestWordRemoving() + "\nThere is string with replacement of longest and shortest words: " + modifier.LongestShortestPlaceChanging());

        }
    }
}
