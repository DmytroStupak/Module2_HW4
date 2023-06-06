using System.Collections.Generic;
using System;

namespace Modul2HW4
{
    public static class StaticAnimal
    {
        public static ChordatesAnimal[] FindByWeight(this ChordatesAnimal[] animals, double minWeight, double maxWeight)
        {
            ChordatesAnimal[] res = new ChordatesAnimal[1000];
            int count = 0;
            foreach (var item in animals)
            {
                if (item.Weight >= minWeight && item.Weight <= maxWeight)
                {
                    res[count] = item;
                    count++;
                }
            }

            Array.Resize(ref res, count + 1);

            return res;
        }

        public static void PrintList(this ChordatesAnimal[] animals)
        {
            Console.WriteLine("########################################################");
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Number of animals in the section : {animals.Length}");
            Console.WriteLine(" ");
            Console.WriteLine("########################################################");
        }
    }
}