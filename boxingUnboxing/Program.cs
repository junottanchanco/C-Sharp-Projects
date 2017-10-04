using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create an empty List of type object
            List<object> newList = new List<object>();

            //2. Add the following values to the list: 7, 28, -1, true, "chair"
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            //3. Loop through the list and print all values (Hint: Type Inference might help here!)
            int sum = 0;
            foreach(var item in newList){
                Console.WriteLine(item);
                if(item is int){
                    sum +=(int)item;
                }
            }
            Console.WriteLine("The sum of integers is {0}", sum);
        }
    }
}
