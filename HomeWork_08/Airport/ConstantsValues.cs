using System;

namespace Airport
{
    public class ConstantsValues
    {
        private static readonly string MainPath = Environment.CurrentDirectory;
        public static readonly string JsonPath = MainPath.Replace("\\bin\\Debug\\netcoreapp3.0", "\\JSON\\");

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
}