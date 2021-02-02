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
            { //collection initializer 
                { "soup", "A thing I dont have right now, but want."  }, //key value pair
                { "cake", "A thing I dont have right now, but dont need." }
            };

            words.Add("Arity", "amount of generic type parameters a type has.");

            words["Arity"] = "A thing Nathan made up"; // look up an item by key using the indexer

            //No duplicate keys

            //This checks to see if it already exists and if it doesnt it will add it and return true
            if(!words.TryAdd("Arity", "another definition"))
            {
                words["Arity"] = "another definition";
            }

            words.ContainsKey("soup"); //These are doing the same things, this is the better choice

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} means {word.Value}");
            } 
            //DESTRUCTURED looks like this
            foreach (var (word, definition) in words)
            {
                Console.WriteLine($"{word} means {definition} in a destructed way");
            }

            var complicatedDictionary = new Dictionary<string, List<string>>();
            complicatedDictionary.Add("Soup", new List<string> { "A soup definition", "Another soup definition" });

            //Hashset<T>
            //Really fast retrieval, no keys 
            //Good for: looping, deduplication, NO DUPLICATES WOO WOO
            //Good for: When you only want at most one copy of a thing
            //enforces uniqueness, but no errors
            //slow storage :/
            
            //this will make a unique collection without duplicates
            //Most collection constructors take in collections to convert them
            var unique = new HashSet<string>(e13);

            unique.Add("Nathan"); // these last 3 get ignored
            unique.Add("Nathan");
            unique.Add("Nathan");
            unique.Add("Nathan");


            //Queue<T>
            // FIFO - First in first out

            var queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            
            while (queue.Count > 0)
            {
                Console.WriteLine($"Currently dequeueing : {queue.Dequeue()}");
            }

            //Stack<T>
            //LIFO - Last in first out
            //Think of a stack of plates

            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            while (stack.Count > 0)
            {
                Console.WriteLine($"Currently popping : {stack.Pop()}");
            }

        }
    }
}
