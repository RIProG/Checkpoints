using System;

namespace Checkpoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i, j, k;

            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();
            string[] stringArray = input.Split('-');

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            foreach (string model in stringArray)
            {
                string substring = model.Substring(1);
                int m = Convert.ToInt32(substring);


                for (i = 1; i <= m; i++)
                {
                    if (model[0] == 'a' || model[0] == 'A')
                    {

                        for (j = 1; j <= i; j++)
                        {
                        }
                        for (k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    else if (model[0] == 'b' || model[0] == 'B')
                    {
                        for (j = 1; j <= m - i; j++)
                        {
                        }
                        for (k = 1; k <= j; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    
                }

            }

        }










    }
}

