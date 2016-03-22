using System;
using System.Linq;


namespace zadacha4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            int[] numbers = numberInput.Split().Select(n => Convert.ToInt32(n)).ToArray();
           
            Array.Sort(numbers);

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine();
        }
    }
}