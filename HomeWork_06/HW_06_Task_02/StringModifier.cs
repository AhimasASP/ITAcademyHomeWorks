using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_06_Task_02
{
    public class StringModifier
    {
        StringBuilder builder = new StringBuilder();
        private string[] array;
        string str, shortestWord, longestWord = String.Empty;

        public StringModifier(string str)
        {
            this.shortestWord = str;
            this.str = str;
            this.array = str.Split(' ');
            ShortestLongestFinder();
        }

        private void ShortestLongestFinder()
        {
            foreach (string currentString in array)
            {
                if (PunctuationFilter(currentString).Length > longestWord.Length)
                {
                    longestWord = PunctuationFilter(currentString);
                }

                if (PunctuationFilter(currentString).Length < shortestWord.Length)
                {
                    shortestWord = PunctuationFilter(currentString);
                }
            }
        }

        private string PunctuationFilter(string str)
        {
            Regex regex = new Regex(@"\W+");
            return regex.Replace(str, "");
        }

        public string LongestWordRemoving()
        {
            return str.Replace(longestWord, "");
        }

        public string LongestShortestPlaceChanging()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (PunctuationFilter(array[i]).Equals(longestWord))
                {
                    array[i] = array[i].Replace(PunctuationFilter(array[i]), shortestWord);
                }
                else
                {
                    if (PunctuationFilter(array[i]).Equals(shortestWord))
                    {
                        array[i] = array[i].Replace(PunctuationFilter(array[i]), longestWord);
                    }
                }
                builder.Append(array[i]).Append(' ');
            }
            return builder.ToString().Substring(0, builder.ToString().Length - 1);
        }

        public int LettersCounter()
        {
            return PunctuationFilter(str).Length;
        }

        public int PunctuationCounter()
        {
            string tmpString = str.Replace(" ", "");
            return (tmpString.Length - PunctuationFilter(tmpString).Length);
        }

        public string ShowArrayAsString(string[] arrayToString)
        {
            builder.Clear();
            builder.Append('[');
            foreach (string currentString in arrayToString)
            {
                builder.Append(currentString);
                builder.Append(' ');
            }
            return (builder.ToString().Substring(0, builder.ToString().Length - 1) + ']').ToLower();
        }

        public string[] StringToSortedArray()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (PunctuationFilter(array[j]).Length < PunctuationFilter(array[j + 1]).Length)
                    {
                        string tmpString = PunctuationFilter(array[j + 1]);
                        array[j + 1] = PunctuationFilter(array[j]);
                        array[j] = tmpString;
                    }
                }
            }
            return array;
        }
    }
}