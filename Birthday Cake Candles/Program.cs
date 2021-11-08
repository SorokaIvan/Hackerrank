﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles[0];
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] > max)
                {
                    max = candles[i];
                }
            }
            int result = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] == max)
                {
                    result += 1;
                }
            }
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}