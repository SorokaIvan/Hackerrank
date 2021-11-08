using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Simple_Array_Sum
{
    class Result
    {

        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum = sum + ar[i];
            }
            return sum;
        }

    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.SimpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
