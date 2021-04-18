using DataStrutures_Algorithms.Dynamic_Programming.Knapsack;
using DataStrutures_Algorithms.Dynamic_Programming.LCS;
using System;

namespace DataStrutures_Algorithms
{
    internal class AlgorithmFactory
    {
        public AlgorithmFactory()
        {
        }

        internal IAlgorithm GetAlgoObject(string algoName)
        {
           switch(algoName)
            {
                case nameof(LongestCommonSubsequence):
                    return new LongestCommonSubsequence();
                case nameof(FindAllSubsets):
                    return new FindAllSubsets();
                default:
                    return null;
            }
        }
    }
}