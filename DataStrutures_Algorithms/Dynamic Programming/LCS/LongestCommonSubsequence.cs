using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrutures_Algorithms.Dynamic_Programming.LCS
{
    class LongestCommonSubsequence : IAlgorithm
    {
        char[] A;
        char[] B;
        int result = 0;
        int[,] DP;
        public void Execute()
        {
            ReadInput();
            ProcessInput();
            DisplayOutput();
        }

        private void ProcessInput()
        {
            result = LCS(0,0,0);
        }

        public void ReadInput()
        {
            Console.Write($"Input String A:");
            this.A = Console.ReadLine().ToCharArray();
            Console.Write($"Input String B:");
            this.B = Console.ReadLine().ToCharArray();
            InitilizeDP(A.Length, B.Length);
        }

        private void InitilizeDP(int row, int column, int initialVal = -1 )
        {
            DP = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    DP[i,j] = initialVal;
                }
            }
        }

        public void DisplayOutput()
        {
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Printing DP: ");
            PrintDP();
        }

        private void PrintDP()
        {
            for (int i = 0; i < DP.GetLength(0); i++)
            {
                for (int j = 0; j < DP.GetLength(1); j++)
                {
                    Console.Write("{0} \t", DP[i, j]);
                }
                Console.WriteLine();
            }
        }

        private int LCS(int i, int j, int count )
        {
            if (i == A.Length || j == B.Length)
                return count;

            if (DP[i, j] != -1)
                return DP[i, j];

            if (A[i] == B[j])
            {
                DP[i, j] = LCS(i + 1, j + 1, count + 1);
                return DP[i, j];
            }
                
            else
            {
                DP[i, j] = Math.Max(LCS(i + 1, j, count), LCS(i, j + 1, count)); ;
                return DP[i, j];
            }
                 
        }
    }
}
