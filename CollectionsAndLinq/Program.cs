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



        }
    }
}
