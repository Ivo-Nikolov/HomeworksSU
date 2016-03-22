using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;


namespace ujas
{
   public class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            var length = rnd.Next(10);
            var input = new string[length];

            Console.WriteLine("Enter {0} messeges ",length);

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            string newInput = String.Join(",", input);

            int[] resultArray = Regex.Matches(newInput, "(-?[0-9]+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (resultArray[i]<min)
                {
                    min = resultArray[i];
                }
                else if (resultArray[i]>max)
                {
                    max = resultArray[i];
                }
            }
            Console.WriteLine("Results:");
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.Write("InBetween: ");
            var inbetween = "";
            for (int i = min+1; i < max; i++)
            {
                Console.Write(i);
                inbetween += i;
                if (i < max - 1)
                {
                    Console.Write(", ");
                    inbetween += ", ";
                }
                else
                {
                    Console.WriteLine();
                }
            }

            using (XmlWriter writer = XmlWriter.Create("tempresults.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Result");

                writer.WriteElementString("Min", min.ToString());
                writer.WriteElementString("Max", max.ToString());
                writer.WriteElementString("InBetween", inbetween);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            var cheatJson = String.Format("Result:{{ Min:{0}, Max:{1}, InBetween: {2}}}",min,max,inbetween);
            Console.WriteLine(cheatJson);

        }
    }
}
