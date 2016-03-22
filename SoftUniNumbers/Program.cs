using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet =
            new Dictionary<string, int>
            {
                {"aa", 0},
                {"aba", 1},
                {"bcc", 2},
                {"cc", 3},
                {"cdc", 4}
            };
            var input = Console.ReadLine().ToCharArray();
            var letter = "";
            List<int> softNumber = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                letter += input[i];
                if (alphabet.ContainsKey(letter))
                {
                    softNumber.Add(alphabet[letter]);
                    letter = "";
                }
            }
            var result = 0;
            var maxpower = softNumber.Count;
            for (int j = 0; j <maxpower;j++)
            {
                result += softNumber[j]*(int)Math.Pow(5,maxpower-j-1);
            }
            Console.WriteLine(result);
        }
    }
}
