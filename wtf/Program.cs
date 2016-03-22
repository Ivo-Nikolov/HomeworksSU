using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wtf
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = inputSize[0];
            int columns = inputSize[1];
            var command = Console.ReadLine();
            var matrix = new int[rows,columns];
            int steps = 0;
            while (command != "stop")
            {
                var carPlace = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int enteringRow = carPlace[0];
                int carRow = carPlace[1];
                int carColumn = carPlace[2];

                Console.WriteLine(steps);
                command = Console.ReadLine();

            }
        }
    }
}
