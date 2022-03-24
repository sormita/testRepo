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


namespace PracticeAlgorithm
{
    class TimeConversionResult
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static void timeConversion(string s)
        {
            string time = "";
            string Temp = "";
            int count = 0;
            List<string> strList = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {                
                if (s[i] != ':')
                {
                    Temp = Temp + s[i];                    
                    continue;
                }
                else if (s[i] == ':')
                {
                    count = count + 1;                    
                }
                strList.Add(Temp);
                Temp = "";
                if (count == 2)
                {                    
                    strList.Add(s.Substring(i + 1));
                }

            }

            string lstString = strList[strList.Count()-1];
            for(int j = 0; j < lstString.Length; j++)
            {
                int num;
                //Need to complete this part
            }

            //Splitting of string is complete
            for (int k = 0; k < strList.Count(); k++)
            {
                Console.WriteLine(strList[k]);
            }

            //return "";
        }

    }

    class TimeConversionSolution
    {
        public static void TimeMain()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = "07:05:45PM";

            //string result = TimeConversionResult.timeConversion(s);
            TimeConversionResult.timeConversion(s);


            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

