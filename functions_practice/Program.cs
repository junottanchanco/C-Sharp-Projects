using System;
using System.Collections.Generic;

namespace functions_practice
{
    class Program
    {
        // public static void SayHello(string name = "buddy"){
        public static string SayHello(string name = "buddy"){
            // Console.WriteLine("Hello {0}, how are you doing today?", name);
            // Console.WriteLine("Hey " + name);
            return $"Hey {name}";
        }
        public static void Main(string[] args)
        {
            string greeting;
            greeting = SayHello();
            Console.WriteLine(greeting);
            // SayHello("Junot");
        }
    }
}
