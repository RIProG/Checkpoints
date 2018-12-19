using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 2, 8, 3, 11 };
            List<int> result = MultiplyBy100AndAdd3(input);
            DisplayList(input, result);
        }


        private static List<int> MultiplyBy100AndAdd3(List<int> input)
        {
            return input.Select(x => x * 100 + 3).ToList();
        }
        private static void DisplayList(List<int> input, List<int> result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LISTAN");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int number in input)
            {
                if (number != input[input.Count - 1])
                {
                    Console.Write($"{number},");
                }
                else
                    Console.WriteLine($"{number}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MULTIPLICERA MED 100 OCH LÄGG TILL TRE");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int number in result)
            {
                if (number != result[result.Count - 1])
                {
                    Console.Write($"{number},");
                }
                else
                    Console.WriteLine($"{number}");
            }
            Console.WriteLine();
        }

        public List<string> ReorderList(List<string> stringInput, List<int> intInput)
        {
            List<string> result = new List<string>();
            foreach (int number in intInput)
            {
                result.Add(stringInput[number-1]);
            }

            return result;
        }

    }
}
