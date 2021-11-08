using System;
using System.Collections.Generic;
using System.Linq;

namespace Plus_Minus
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
            double plus = 0;
            double minus = 0;
            double nul = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    plus += 1;
                }
                else if (arr[i] < 0)
                {
                    minus += 1;
                }
                else
                {
                    nul += 1;
                }
            }
            Console.WriteLine(plus / arr.Count);
            Console.WriteLine(minus / arr.Count);
            Console.WriteLine(nul / arr.Count);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
