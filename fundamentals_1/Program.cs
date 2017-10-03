using System;
using System.Collections.Generic;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 255; i++){
            //     Console.WriteLine(i);
            // }

            // for(int i = 1; i <= 100; i++){
            //     if(i % 3==0 && i % 5==0){
            //         Console.WriteLine("FizzBuzz");
            //     }else if(i % 3 ==0){
            //         Console.WriteLine("Fizz");
            //     }else if (i % 5 == 0){
            //         Console.WriteLine("Buzz");
            //     }
            // }

            // // Declaring an array of length 5, initialized by default to all zeroes
            // int[] numArray = new int[5];
            // // Declaring an array with pre-populated values
            // // For Arrays initialized this way, the length is determined by the size of the given data
            // int[] numArray2 = {1,2,3,4,6};

            // int[] array3;
            // array3 = new int[] {1,3,5,7,9};
            // Console.WriteLine(array3[0]);
            // Console.WriteLine(array3[1]);
            // Console.WriteLine(array3[2]);
            // Console.WriteLine(array3[3]);
            // Console.WriteLine(array3[4]);

        //     int[] arr = {1,2,3,4};
        //     Console.WriteLine("The first number of the arr is " + arr[0]);
        //     arr[0] = 8;
        //     Console.WriteLine("The first number of the arr is now " + arr[0]);
        
        // string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
        // The 'Length' property tells us how many values are in the Array (4 in our example here). 
        // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
        // for(int idx = 0; idx < myCars.Length; idx++){
        //     Console.WriteLine("I own a {0}", myCars[idx]);
        // }
        // foreach(String car in myCars){
        //     Console.WriteLine("I own a {0}", car);
        // }
        
        //Initializing an empty list of Motorcycle Manufacturers
        // List<string> bikes = new List<string>();
        //Use the Add function in a similar fashion to push
        // bikes.Add("Kawasaki");
        // bikes.Add("Triumph");
        // bikes.Add("BMW");
        // bikes.Add("Moto Guzzi");
        // bikes.Add("Harley Davidson");
        // bikes.Add("Suzuki");
        //Accessing a generic list value is the same as you would an array
        // Console.WriteLine(bikes[2]);
        // Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
        
        //Using our array of motorcycle manufacturers from before
        //we can easily loop through the list of them with a C-style for loop
        //this time, however, Count is the attribute for a number of items.
        // Console.WriteLine("The current manufacturers we have seen are:");
        // for(var idx = 0; idx < bikes.Count; idx++){
        //     Console.WriteLine("-" + bikes[idx]);
        // }
        // bikes.Insert(2, "Yamaha");
        // bikes.Remove("Suzuki");
        // bikes.Remove("Yamaha");
        // bikes.RemoveAt(0);
        // Console.WriteLine("List of Non-Japanese Manufacturers:");
        // foreach(string manu in bikes){
        //     Console.WriteLine("-" + manu);
        // }

        Dictionary<string, string> profile = new Dictionary<string, string>();
        profile.Add("Name", "Speros");
        profile.Add("Language", "PHP");
        profile.Add("Location", "Greece");

        Console.WriteLine("Instructor Profile");
        // Console.WriteLine("Name - " + profile["Name"]);
        // Console.WriteLine("From - " + profile["Location"]);
        // Console.WriteLine("Favorite Language - " + profile["Language"]);
        
        // foreach(KeyValuePair<string,string> entry in profile){
        //     Console.WriteLine(entry.Key + " - " + entry.Value);
        // }
        foreach(var entry in profile){
            Console.WriteLine(entry.Key + " - " + entry.Value);
        }
        }
    }
}
