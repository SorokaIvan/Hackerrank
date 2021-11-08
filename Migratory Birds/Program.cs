using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Migratory_Birds
{
    class Result
    {

        /*
         * Complete the 'migratoryBirds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int migratoryBirds(List<int> arr)
        {
            int[] birds = new int[6];
            for (int i = 0; i < arr.Count; i++)
            {
                birds[arr[i]] += 1;
            }
            int index = 0;
            int max = 0;
            for (int i = 1; i < birds.Length; i++)
            {
                if (birds[i] > max)
                {
                    index = i;
                    max = birds[i];
                }
            }
            return index;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.migratoryBirds(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
