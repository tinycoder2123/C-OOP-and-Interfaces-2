using System;
using System.Collections.Generic;
using System.Linq;

namespace Module2Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            int i = 1;
            while (i < 4)
            {

                Animal animal = null;
                Console.WriteLine($" Cage {i} ");
                Console.WriteLine("What is the animal’s species?");
                var species = Console.ReadLine();
                if (species.Trim().ToLower() == "lion")
                    animal = new Lions();

                if (species.Trim().ToLower() == "wolf")
                    animal = new Wolves();

                if (species.Trim().ToLower() == "bear")
                    animal = new Bears();

                animal.species = species;
                Console.WriteLine("How old is it? ");
                animal.age = Convert.ToInt32(Console.ReadLine());
                animal.RequestUniqueCharacteristic();
                animals.Add(animal);
                i++;
            }
            for (i = 0; i < animals.Count(); i++)
            {
                Console.Write($"Cage {i + 1} contains a");
                animals[i].GetDescription();
            }
        }
    }
}
