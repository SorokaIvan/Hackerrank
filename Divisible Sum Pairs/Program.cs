using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Divisible_Sum_Pairs
{
    class Result
    {

        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         */

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                int x = i + 1;
                for (; x < ar.Count; x++)
                {
                    if ((ar[i] + ar[x]) % k == 0)
                    {
                        result += 1;
                    }
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

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.divisibleSumPairs(n, k, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
