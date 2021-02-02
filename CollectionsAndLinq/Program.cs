using System;
using System.Collections.Generic;

namespace CollectionsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //anything with angle brackets after the type name is called a generic type
            // List<T> Generic List
            //Pronounced List of T
            //T is a Generic Type Parameter
            //String in this case closes the generic type----tells you what it's going to contain
            var teachers = new List<string>
            {
                "Jameka", "Dylan", "Nathan"
            };
            var e13 = new List<string> { "Chris", "Ryan", "Joseph" };
            e13.Add("Jordan");
            e13.Add("Wanda");
            e13.Add("Hunter");

            e13.AddRange(teachers);

            e13.ForEach((name) =>
            {
                Console.WriteLine($"{name}");
            });

            if (e13.Remove("Wanda"))
            {
                Console.WriteLine("Bye Wanda.");
            }
            if (e13.Remove("wanda"))
            {
                Console.WriteLine("Couldnt find wanda.");
            }


            // Dictionary<TKey, TValue>
            //Arity (`2)- amount of generic type parameters a type has. ----- Makes them unique---- You can have a dictionary classs with an arity of one and an arity of two. Dictionary`2
            //Very fast information retrieval
            //Slower information storage speed
            //Good for: storing a ton of information at once and reading it back a bunch --- infrequently updated but often read data
            //Good for: loading information at startup or in the background and fast retrieval on demand (caching)

            //the first parameter is the type for the key, the second is the type for the value
            var words = new Dictionary<string, string>()
            {
                { "soup", "A thing I dont have right now, but want."  },
                { "cake", "A thing I dont have right now, but dont need." }
            };

            words.Add("Arity", "amount of generic type parameters a type has.");

            words["Arity"] = "A thing Nathan made up";


        }
    }
}
