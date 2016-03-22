using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zada4a4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var events = new SortedDictionary<string,SortedDictionary<string,string>>(); //location, name, time
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                var person = Regex.Match(input, @"#(\w+):").Captures[0].Value.Replace("#","").Replace(":","");
                var location = Regex.Match(input, @"@([a-zA-Z]+)[\s]*").Captures[0].Value.Replace("@", "").Replace(" ", "");
                var time = Regex.Match(input, @"[\s]*(\d+:\d+)").Captures[0].Value.Replace(" ", "");

                if (events.ContainsKey(location))
                {

                    if (events[location].ContainsKey(person))
                    {
                        var temparrtime = (events[location][person]+","+time).Split(',').ToList();
                        temparrtime.Sort();
                        var tempTime = string.Join(",",temparrtime);
                        tempTime.Remove(tempTime.Length - 1);
                        events[location][person] = tempTime;

                    }
                    else
                    {
                        events[location].Add(person, time);
                    }
                }
                else
                {
                    var temp = new SortedDictionary<string, string>();
                    temp.Add(person, time);
                    events.Add(location, temp);
                }
            }
            var locations = Console.ReadLine().Split(',').ToList();

            locations.Sort();
            
            for (int j = 0; j < locations.Count; j++)
            {
                var results = events.Where(e => e.Key == locations[j]).ToList();
                Console.WriteLine(locations[j] + ":");
                for (int k=0;k<results.Count;k++)
                {
                    var index = 1;
                    foreach (var names in results[k].Value)
                    {
                        Console.WriteLine("{0}. {1} -> {2}", index, names.Key, names.Value.Replace(",", ", "));
                        index ++;
                    }
                    
                }
            }
        }
    }
}
