using System;
using System.IO;
using System.Linq;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("input.txt");
            var numbers = lines.Select(x => Int32.Parse(x)).ToArray();
            //numbers = numbers.OrderBy(x => x);
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 1; j < numbers.Count(); j++)
                {
                        if (numbers[i] + numbers[j] == 2020)
                            Console.WriteLine(numbers[i] * numbers[j]);
                }
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 1; j < numbers.Count(); j++)
                {
                    for (int k = 2; k < numbers.Count(); k++)
                    {
                        if (numbers[i] + numbers[j]+ numbers[k] == 2020)
                            Console.WriteLine(numbers[i] * numbers[j]* numbers[k]);
                    }
                }
            }

        }
    }
}
