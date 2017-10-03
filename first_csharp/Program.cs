using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int favNum = 42;
            // string name = "Junot";
            // string interpol = $"The answer to 2 + 7 is {2+ 7}";
            // bool crazy = false;
            

            // Console.WriteLine("My name is " + name + " and My favorite number is");
            // Console.WriteLine(favNum);
            // Console.WriteLine(interpol);
            // Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");

            // int rings = 5;
            // int numOfAllStarAppearances = 17;
            // const string name = "Kobe";
            

            // if(rings >= 5 && name == "Kobe"){
            //     Console.WriteLine("Welcome to the party {0}, congratualtions on your {1} rings", name, rings);
            // }
            // else if(rings > 2){
            //     Console.WriteLine("Decent... but {0} rings aren't enough.", rings);
            // }
            // else{
            //     Console.WriteLine("Go win some more rings!");
            // }

            // if(rings >= 5 || numOfAllStarAppearances > 3){
            //     Console.WriteLine("Welcome {0}, you are truly a legend", name);
            // }
            
            // if(!crazy){
            //     Console.WriteLine("Let's party!");
            // }

            // int start = 0;
            // int end = 5;
            // // loop from 1 to 5 including 5
            // for (int i = start; i <= end; i++){
            //     Console.WriteLine(i);
            // }
            // // loop from 1 to 5 excluding 5
            // for (int i = start; i < end; i++){
            //     Console.WriteLine(i);
            // }

            // int i =1;
            // while (i<6){
            //     Console.WriteLine(i);
            //     i++;
            // }

            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                Console.WriteLine(rand.Next(2,8));
            }
        }
    }
}
