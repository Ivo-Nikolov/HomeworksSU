using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zada4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var ivan = "lol";
            string[,] resourceMatrix = new string[input.Length,3];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains('_'))
                {
                    resourceMatrix[i,0] = input[i].Split('_')[0];
                    resourceMatrix[i,1] = input[i].Split('_')[1];
                }
                else
                {
                    resourceMatrix[i, 0] = input[i];
                    resourceMatrix[i, 1] = "1";   
                }
                resourceMatrix[i, 2] = "no";
            }

            var numberOfPaths = int.Parse(Console.ReadLine());
            var paths = new int[numberOfPaths,2];

            for (int j = 0; j < numberOfPaths; j++)
            {
                var inputPaths = Console.ReadLine().Split().Select(int.Parse).ToArray();
                paths[j,0] = inputPaths[0];
                paths[j,1] = inputPaths[1];
            }
            var maxQuantity = 0;
            var tempQuantity = 0;
            var maxStep = input.Length;

            for (int k = 0; k < numberOfPaths; k++)
            {
               var currentStep = paths[k,0];
               if (maxQuantity < tempQuantity)
               {
                   maxQuantity = tempQuantity;
               }
                if (currentStep >= maxStep)
                {
                    currentStep = currentStep%maxStep;
                }
                while (resourceMatrix[currentStep, 2] != "yes")
                {
                   
                    switch (resourceMatrix[currentStep, 0])
                    {
                        case "stone":
                        case "gold":
                        case "wood":
                        case "food":
                            if (resourceMatrix[currentStep, 2] == "no")
                            {
                                tempQuantity += int.Parse(resourceMatrix[currentStep, 1]);
                                resourceMatrix[currentStep, 2] = "yes";
                                currentStep += paths[k, 1];
                                if (currentStep >= maxStep)
                                {
                                    currentStep = currentStep % maxStep;
                                }
                            }
                            break;
                        default:
                            {
                                currentStep += paths[k, 1];
                                if (currentStep >= maxStep)
                                {
                                    currentStep = currentStep % maxStep;
                                }
                        }
                            break;
                    }
                }   
            }
            var mariika = "";
            Console.WriteLine(maxQuantity);
            

        }
    }
}
