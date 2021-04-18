using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrutures_Algorithms.Dynamic_Programming.Knapsack
{
    class FindAllSubsets : IAlgorithm
    {
        string[] A;
        public void DisplayOutput()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            ReadInput();
            ProcessInput();
        }

        private void ProcessInput()
        {
            Console.Write("Enter max Subset Length:");
            int.TryParse(Console.ReadLine(), out int subset_length);

            Console.WriteLine($"Printing Subset: ");           
            GetAllSubsets(string.Empty, subset_length, 0);            
        }

        private void GetAllSubsets(string subset, int count, int currentElement)
        {
            if (count == 0 || currentElement == A.Length)
                Console.WriteLine(subset == string.Empty ? "{}" : subset);
            else
            {
                GetAllSubsets(subset, count, currentElement + 1);                
                GetAllSubsets(subset+ A[currentElement], count-1, currentElement + 1);
            }                
        }

        private void PrintSubset(List<string> subset)
        {
            subset.ForEach(e => Console.Write("{0},",e));
            Console.WriteLine();
        }

        public void ReadInput()
        {
            Console.WriteLine("Enter Array elements Comma Seperated");
            A = Console.ReadLine().Split(',');            
        }
    }
}
