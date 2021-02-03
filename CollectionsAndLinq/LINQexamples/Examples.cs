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

            


        }
    }
}
