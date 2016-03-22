using System;
using System.Linq;


namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            int temp = 0;
            int[] numbers = numberInput.Split().Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
