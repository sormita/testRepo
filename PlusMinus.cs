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
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {

            int pos_num = 0;
            int neg_num = 0;
            int zero_num = 0;
            for (int i = 0; i < arr.Count; i++)
            {

                if (arr.ElementAt(i) > 0)
                {
                    pos_num = pos_num + 1;
                }
                else if (arr.ElementAt(i) < 0)
                {
                    neg_num = neg_num + 1;
                }
                else
                {
                    zero_num = zero_num + 1;
                }

            }


            if (pos_num > 0)
            {
                decimal pos_ratio = Convert.ToDecimal(pos_num) / Convert.ToDecimal(arr.Count);
                pos_ratio.ToString("N6");
                Console.WriteLine(pos_ratio.ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");
            }


            if (neg_num > 0)
            {
                decimal neg_ratio = Convert.ToDecimal(neg_num) / Convert.ToDecimal(arr.Count);
                neg_ratio.ToString("N6");
                Console.WriteLine(neg_ratio.ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");
            }


            if (zero_num > 0)
            {
                decimal zero_ratio = Convert.ToDecimal(zero_num) / Convert.ToDecimal(arr.Count);
                zero_ratio.ToString("N6");
                Console.WriteLine(zero_ratio.ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");
            }


        }

    }

    class Solution
    {
        public static void PlusMinusMain(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}

