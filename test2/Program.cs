using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            
            
            string[] text = new string[numberOfLines];

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();

            }

            int tempCount = 1;
            int bestCount = 1;
            string word = text[0];
            for (int i = 1; i < numberOfLines; i++)
            {
                if (text[i] == text[i - 1])
                {
                    tempCount++;
                    if (tempCount > bestCount)
                    {
                        bestCount = tempCount;
                        word = text[i];
                    }
                }
                else
                {
                    tempCount = 1;
                }
            }
            Console.WriteLine(bestCount);
            for (int j = 0; j < bestCount; j++)
            {
                Console.WriteLine(word);
            }

        }
    }
}
