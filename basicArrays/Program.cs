using System;
using System.Linq;
namespace basicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int [] numbers = new int[numberInput];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

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
