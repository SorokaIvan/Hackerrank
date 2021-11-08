using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Breaking_the_Records
{
    class Result
    {

        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);

            int max = scores[0];
            int min = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    result[0] += 1;
                }
                else if (scores[i] < min)
                {
                    min = scores[i];
                    result[1] += 1;
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

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.breakingRecords(scores);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
