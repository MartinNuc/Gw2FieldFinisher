using System;
using System.Collections.Generic;
using Gw2FieldFinisher.Dijkstra;
using Gw2FieldFinisher.GuildWars2;
using Gw2FieldFinisher.GuildWars2.Classes;

namespace Gw2FieldFinisher
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboFinderClass engineer = new Engineer();

            // for each combo field we look for all possible finishers
            foreach (var field in engineer.GetFields())
            {
                foreach (var finisher in engineer.GetFinishers())
                {
                    var path = engineer.CalculateDistance(field, finisher);
                    if (path.Count <= 1) continue;

                    // print results
                    for (var i = 0; i < path.Count - 1; i++)  // last if printed out of for-cycle
                    {
                        Console.Write(path[i].Name + " -> ");
                    }
                    Console.WriteLine(path[path.Count-1].Name + " ==> " + FieldFinisher.GetEffect(field.Field, finisher.Finisher));
                }
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
