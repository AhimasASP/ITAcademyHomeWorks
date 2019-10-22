using System;

namespace Airport
{
    public class Constants
    {
        private static readonly DateTime curreDateTime = DateTime.Now;
        private static readonly string MainPath = Environment.CurrentDirectory;
        private static readonly string JsonPath = MainPath.Replace("\\bin\\Debug\\netcoreapp3.0", "\\JSON\\");
    }
}