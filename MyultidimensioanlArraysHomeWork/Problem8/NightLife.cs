using System;
using System.Collections.Generic;
using System.Linq;

namespace NightLife
{
    class NightLife
    {
        static void Main()
        {
            var cities = new Dictionary<string, SortedDictionary<string, List<string>>>();
            var venues = new SortedDictionary<string, List<string>>();
            var performers = new List<string>();
            var inputList = new List<string>();
            string input = "";

            while (input != "END")
            {
                input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    inputList = input.Split(';').ToList();
                    string cityStr = inputList[0];
                    string venueStr = inputList[1];
                    string perfStr = inputList[2];

                    
                    if (cities.ContainsKey(cityStr))
                    {
                        
                        if (cities[cityStr].ContainsKey(venueStr))
                        {
                                                     
                            if (!SearchList(cities[cityStr][venueStr], perfStr))
                            {
                                cities[cityStr][venueStr].Add(perfStr);
                            }
                        }
                        else
                        {
                            cities[cityStr].Add(venueStr, performers);
                            performers = new List<string>();
                            cities[cityStr][venueStr].Add(perfStr);
                        }
                    }
                    else
                    {
                        cities.Add(cityStr, venues);
                        venues = new SortedDictionary<string, List<string>>();
                        cities[cityStr].Add(venueStr, performers);
                        performers = new List<string>();
                        cities[cityStr][venueStr].Add(perfStr);
                    }
                }
            }

            
            foreach (var city in cities)
            {
                foreach (var venue in city.Value)
                {
                    (venue.Value).Sort();
                }
            }

           
            foreach (var city in cities)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    Console.Write("->{0}: ", venue.Key);
                    for (int i = 0; i < venue.Value.Count; i++)
                    {
                        Console.Write(venue.Value[i]);
                        if (i < venue.Value.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        
        static bool SearchList(List<string> list, string item)
        {
            bool check = false;
            string position = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(item))
                {
                    check = true;
                    position = i.ToString();
                }
            }
            return check;
        }
    }
}