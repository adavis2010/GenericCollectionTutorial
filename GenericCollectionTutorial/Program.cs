using System;
using System.Collections.Generic;

namespace GenericCollectionTutorial {
    class Program {
        static void Main(string[] args) {
            // created generic list
            var ints = new List<int>();
            // creating another list (strings)
            var strs = new List<string> {
            "orange", "blue", "gray", "red", "black", "green"
            }; 
            //Print favorite color list
            Console.WriteLine($"Favorite color count is {strs.Count}");

            //add to our collection

            ints.Add(7);
            ints.Add(10);
            ints.Add(3);
            ints.Add(6);
            ints.Add(96);
            ints.Add(22);
            // used for each statement 
            foreach (var i in ints) {
                //print statement for favorite numbers
                Console.WriteLine($"Favorite number {i}");
            }


        }
    }
}
