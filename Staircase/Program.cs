using System;

namespace Staircase
{
    class Result
    {

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 0; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }
}
