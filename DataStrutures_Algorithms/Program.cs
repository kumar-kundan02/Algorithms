using DataStrutures_Algorithms.Dynamic_Programming.Knapsack;
using DataStrutures_Algorithms.Dynamic_Programming.LCS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace DataStrutures_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var algoDetails = LoadAllAlgorithms();
            
            bool start = true;

            while (start)
            {
                Console.WriteLine("Select the Algorithm Pattern");
                algoDetails.Keys.ToList().ForEach(x => Console.WriteLine($"{x} : {algoDetails[x]}"));
                int.TryParse(Console.ReadLine(), out int algoChoice);
                if(algoDetails.ContainsKey(algoChoice))
                {
                    IAlgorithm algorithm = new AlgorithmFactory().GetAlgoObject(algoDetails[algoChoice]);
                    if (algorithm != null)
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        algorithm.Execute();
                        stopwatch.Stop();
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);
                    }
                        
                    else
                        Console.WriteLine($"No Such Algorithm: {algoDetails[algoChoice]} is Available");
                }
                else
                    Console.WriteLine($"Choice {algoChoice} is not available. Make another choice.");

                Console.WriteLine("Do you want to continue(Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                    start = false;
            }
                

            Console.WriteLine("Executuion Completed");
            Console.ReadLine();
        }

        private static Dictionary<int,string> LoadAllAlgorithms()
        {
            Dictionary<int, string> algorithmCollection = new Dictionary<int, string>();
            algorithmCollection.Add(1,nameof(LongestCommonSubsequence));
            algorithmCollection.Add(2, nameof(FindAllSubsets));

            return algorithmCollection;
        }
    }
}
