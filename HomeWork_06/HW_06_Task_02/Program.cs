using System;
using System.IO;

namespace HW_06_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   
            string srcString = File.ReadAllText(Environment.CurrentDirectory.Replace(@"HW_06_Task_02\bin\Debug\netcoreapp3.0", "") + @"\panagramm.txt");
            StringModifier modifier = new StringModifier(srcString);
            Console.WriteLine("There is source string: " + srcString + "\nThere source string without longest word: " + modifier.LongestWordRemoving() + 
                              "\nThere is string with replacement of longest and shortest words: " + modifier.LongestShortestPlaceChanging() + 
                              "\nLetters counter is: " + modifier.LettersCounter() + "\nPunctuation counter is: " + modifier.PunctuationCounter() + 
                              "\nSource string to sorted array is: " + modifier.ShowArrayAsString(modifier.StringToSortedArray()));
        }
    }
}
