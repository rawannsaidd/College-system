using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{


    public static string timeConversion(string s)
    {
        string[] rr = s.Split(':');
        int hours = Convert.ToInt32(rr[0]);
        if (s.Contains("AM"))
        {
            if (hours == 12)
                hours = 00;
        }

        else if (s.Contains("PM") && hours != 12)
        {
            hours += 12;
        }

        return $"{hours:D2}:{rr[1]}:{rr[2]}";
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
