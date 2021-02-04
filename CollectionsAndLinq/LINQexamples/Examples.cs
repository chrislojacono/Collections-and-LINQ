using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionsAndLinq.LINQexamples
{
    class Examples
    {
        public void Run()
        {
            //new list of whole numbers
            var numbers = new List<int> { 12, 44, 33, 93, 32, 3466, 234 };

            //Where() is like array.filter(), returns a collection of IEnumberable<T>
            //filtering data
           var bigNumbers = numbers.Where(number => number > 50);

            //Select() is like the Array.map, returns a new collection of IEnumerable
            //transforming data
            var biggerNumbers = numbers.Select(number => number + 27);

            var biggestNumber = numbers.Max();

            var firstNumber = numbers.First();
            var firstNumberOverFifty = numbers.First(number => number > 50);

            //contains but cooler ---- returns a Boolean
            var hasReallyBigNumbers = numbers.Any(numbers => numbers > 1000);


            //Complex/Reference Types and Linq
            var animals = new List<Animals>
            { //collection initializer
                new Animals { Type = "Giraffe", HeightInInches = 204, WeightInPounds = 1800}, //object initializers
                new Animals { Type = "Tiger", HeightInInches = 40, WeightInPounds = 500}, //note the comma it is important
                new Animals { Type = "Frog", HeightInInches= 3, WeightInPounds = 1},
                new Animals { Type = "Gorilla", HeightInInches = 63, WeightInPounds= 3500}
            };

            //filter data
            //Materializing an IEnumerable
            // Linq by default uses a concept called deferred execution to only filter/transform data just in time
            var animalsThatStartWithG = animals.Where(animal => animal.Type.StartsWith('G')).ToList();

            //Transform data
            var animalDescriptions = animals.Select(animal => $@"A {animal.Type} is {animal.WeightInPounds}lbs heavy and {animal.HeightInInches} inches tall");

            foreach (var description in animalDescriptions)
            {
                Console.WriteLine(description);
            }

            //Groups the animals by the first charachter
            var groupAnimals = animals.GroupBy(animal => animal.Type.First());

            foreach (var animalGroup in groupAnimals)
            {
                Console.WriteLine($"ANimals that start with {animalGroup.Key}");

                foreach (var animal in animalGroup)
                {
                    Console.WriteLine(animal.Type);
                }

            }

            var groupAnimalName = animals.GroupBy(animal => animal.Type.First(), animal => animal.Type);

            foreach (var animalGroup in groupAnimalName)
            {
                Console.WriteLine($"Animals that start with {animalGroup.Key}");

                foreach (var name in animalGroup)
                {
                    Console.WriteLine(name);
                }
            }

            var filteredAndTransformedAnimals = animals
                .Where(animal => animal.HeightInInches > 20)
                .Select(animal => animal.Type);
        }
    }
}
