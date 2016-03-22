using System;
using System.Collections.Generic;
using System.Linq;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = "1.2 -4 5.00 12211 93.003 4 2.2";
            double[] splitNums = inputNumbers.Split(' ').Select(double.Parse).ToArray();
            List<double> floatNumbers = new List<double>();
            List<int> roundNumbers = new List<int>();
            for (int i = 0; i < splitNums.Length; i++)
            {
                double floatNum = splitNums[i];
                int roundNum = (int)floatNum;

                if (floatNum == roundNum)
                {
                    roundNumbers.Add(roundNum);
                }
                else
                {
                    floatNumbers.Add(floatNum);
                }
            }
            string floats = string.Join(", ", floatNumbers);
            string rounds = string.Join(", ", roundNumbers);
            Console.WriteLine("Input:");
            Console.WriteLine();
            Console.WriteLine(inputNumbers);
            Console.WriteLine("\nOutput:");
            Console.WriteLine();
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}\n", floats, floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", rounds, roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), (double)roundNumbers.Average());
            Console.WriteLine();
        }
    }
}
