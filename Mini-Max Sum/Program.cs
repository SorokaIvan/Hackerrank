using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            List<long> result = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    sum += arr[j];
                }
                result.Add(sum - arr[i]);
            }

            long max = result[0];
            long min = result[0];

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > max)
                {
                    max = result[i];
                }
                else if (result[i] < min)
                {
                    min = result[i];
                }
            }
            Console.WriteLine($"{min} {max}");
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
