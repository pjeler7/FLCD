using System;

namespace Lab3 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var finalState = string.Empty;
            var allStates = new List<string>();
            var allTransitions = new List<string>();
            var alphabetList = new List<char>();
            string[] lines = File.ReadAllLines(@"D:\LTFC\LFTC-Lab3\hw3.txt");

            
            foreach (string line in lines)
            {
                var el = line.Split("->");
                var left = el[0];
                var right = el[1];

                var al = left[1] + "" + left[2];
                if (!allStates.Contains(al))
                {
                    allStates.Add(al);
                    if (left.Contains("["))
                    {
                        finalState = left;
                    }
                }

                var ar = right[1] + "" + right[2];
                if (!allStates.Contains(ar))
                {
                    allStates.Add(ar);
                    if (right.Contains("["))
                    {
                        finalState = right;
                    }
                }

                var t = left[1] + "" + left[2] + "->" + right[1] + "" + right[2];
                if (!allTransitions.Contains(t))
                {
                    allTransitions.Add(t);
                }

                var alp = line[6];
                if (!alphabetList.Contains(alp))
                {
                    alphabetList.Add(alp);
                }
            }

            Console.WriteLine("Final state: " + finalState);

            Console.Write("Alphabet: ");
            foreach (var alphabet in alphabetList)
            {
                Console.Write(alphabet + " ");
            }
            Console.WriteLine();

            Console.Write("Transitions: ");
            foreach (var transition in allTransitions)
            {
                Console.Write(transition + " ");
            }
            Console.WriteLine();

            Console.Write("All states: ");
            foreach (var state in allStates)
            {
                Console.Write(state + " ");
            }

            Console.ReadKey();
        }
    }
}