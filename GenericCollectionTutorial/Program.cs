using System;
using System.Collections.Generic;

namespace GenericCollectionTutorial {
    class Program {
        static void Main(string[] args) {
            // create list for weather class 
            /*var WxHistory = new List<Weather>(3);
            var DtThr = new Weather {
                Today = new DateTime(2021, 2, 18),
                Temperature = 19,
                Percipitation = 3
            };
            WxHistory.Add(DtThr);
            var DtWed = new Weather {
                Today = new DateTime(2021, 2, 17),
                Temperature = 4,
                Percipitation = 0
            };
            WxHistory.Add(DtWed);
            var DtTue = new Weather {
                Today = new DateTime(2021, 2, 16),
                Temperature = 25,
                Percipitation = 2
            };

            WxHistory.Add(DtTue);
            // foreach statement
            foreach (var day in WxHistory) {
                //concat statement with + sign so we have multiple lines so message isnt all on one line
                var msg = $"Weather for {day.Today.ToString("MM dd,yyyy")}" +
                    $" Percipitation was {day.Percipitation} inches" +
                    $" Temperature was {day.Temperature} degrees";
                    Console.WriteLine(msg);
            */

            // create generic friends collection class exercise Monday 2/22

            var friends = new List<Friend>();

            var Jess = new Friend {Name = "Jess", Email = "mynameisJess@yahoo.com", BFF = true };
            friends.Add(Jess);

            var Patty = new Friend {Name = "Patty", Email = "Patty@yahoo.com", BFF = true };
            friends.Add(Patty);


            foreach (var friend in friends) {
                Console.WriteLine($"{friend.Name}");


            }


            // created generic list
           // var ints = new List<int>();
            // creating another list (strings)
           // var strs = new List<string> {
            //"orange", "blue", "gray", "red", "black", "green"
            //}; 
            //Print favorite color list
            //Console.WriteLine($"Favorite color count is {strs.Count}");
            //Sort Colors
           // strs.Sort();
            //for each statement on sorts
            //foreach (var color in strs) {
                //print sorted list
           // Console.WriteLine($"Color is {color}");
            }

            //initial add to our collection

            //ints.Add(7);
            //ints.Add(10);
            //ints.Add(3);
            //ints.Add(6);
            //ints.Add(96);
            //ints.Add(22);
            // used for each statement 
            //foreach (var i in ints) {
              //print statement for favorite numbers
            //    Console.WriteLine($"Favorite number {i}");
            //}


        
    }
}
