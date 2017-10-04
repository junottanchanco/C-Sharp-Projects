using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            //1. Create an array to hold integer values 0 through 9
            // int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(numArray[0]);
            // Console.WriteLine(numArray[1]);
            // Console.WriteLine(numArray[2]);
            // Console.WriteLine(numArray[3]);
            // Console.WriteLine(numArray[4]);
            // Console.WriteLine(numArray[5]);
            // Console.WriteLine(numArray[6]);
            // Console.WriteLine(numArray[7]);
            // Console.WriteLine(numArray[8]);
            // Console.WriteLine(numArray[9]);
            //2. Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            // Console.WriteLine(nameArray[0]);
            // Console.WriteLine(nameArray[1]);
            // Console.WriteLine(nameArray[2]);
            // Console.WriteLine(nameArray[3]);
            //3. Create an array of length 10 that alternates between true and false values, starting with true
            // bool[] boolArray = new bool[10];
            // for(int i =0; i < 10; i += 2){
            //     boolArray[i] = true;
            //     Console.WriteLine(boolArray[i]);
            // }

            //Multiplication Table
            //With the values 1-10, use code to generate a multiplication table

            // int[,] mult = new int[10,10];
            // for(int x = 0; x < 10; x++){
            //     for(int y = 0; y < 10; y++){
            //         mult[x,y] = (x+1) * (y+1);
            //     }
            // }
            // for(int x =0; x < 10; x++){
            //     string display = "[";
            //     for(int y = 0; y < 10; y++){
            //         display += mult[x,y] + ",";

            //         if(mult[x,y] < 10){
            //             display += " ";
            //         }
            //     }
            //     display += "]";
            //     Console.WriteLine(display);
            // }

            //List of Flavors
            //1. Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Ube");
            iceCream.Add("Cheese");
            iceCream.Add("Coffee");

            // Console.WriteLine(iceCream[0]);
            // Console.WriteLine(iceCream[1]);
            // Console.WriteLine(iceCream[2]);
            // Console.WriteLine(iceCream[3]);
            // Console.WriteLine(iceCream[4]);
            //2. Output the length of this list after building it
            // Console.WriteLine("There are " + iceCream.Count + " flavors of ice cream.");
            //3. Output the third flavor in the list, then remove this value.
            // Console.WriteLine(iceCream[2] + " is the 3rd flavor on the menu.");
            // iceCream.RemoveAt(2);
            //4. Output the new length of the list (Note it should just be one less~)
            // Console.WriteLine("The new menu has " + iceCream.Count + " flavors of ice cream.");

            //User Info Dictionary
            //1. Create a Dictionary that will store both string keys as well as string values
            Dictionary<string,string> newDict = new Dictionary<string,string>();
            //2. For each name in the array of names you made previously, add it as a new key in this dictionary with value null "Tim", "Martin", "Nikki", "Sara"

            Random rand = new Random();
            foreach(string name in nameArray){
                newDict[name] = iceCream[rand.Next(iceCream.Count)];
            }
            //3. Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            foreach(var entry in newDict){
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    }
}
