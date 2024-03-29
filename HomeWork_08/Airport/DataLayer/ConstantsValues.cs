﻿using System;

namespace Airport
{
    public class ConstantsValues
    {
        public const string PassportPattern = @"[a-z A-Z]{2}[0-9]{7}";
        public const int AcceptedWeight = 20;
        public const string ErrorMessage = "Falure! Please enter the right choice!";
        private static readonly string MainPath = Environment.CurrentDirectory;
        public static readonly string JsonPath = MainPath.Replace("\\bin\\Debug\\netcoreapp3.0", "\\JSON\\");

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
}