using System;
using System.Collections.Generic;

namespace Basic_13
{
    public class Program
    {
        public static void Print1to255(){
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void PrintOdd1to255(){
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                sum = sum + i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }
        public static void PrintIterArray(int[] arr){
            string output = "[";
            for(int i = 0; i < arr.Length; i++){
                output += arr[i] + ",";
            }
            output += "]";
            Console.WriteLine(output);
        }
        public static void FindMax(int[] arr){
            int max = arr[0];
            foreach(int i in arr){
                if(i > max){
                    max = i;
                }
            }
            Console.WriteLine(max);
        }
        public static void GetAverage(int[] arr){
            int sum = 0;
            foreach(int i in arr){
                sum = sum + i;
            }
            Console.WriteLine(sum/arr.Length);
        }
        public static void ArrayWithOdds(){
            string output = "[";
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){
                    output += i + ",";
                }
            }
            output += "]";
            Console.WriteLine(output);
        }
        public static void GreaterThanY(int[] arr, int y){
            
            int count = 0;
            foreach(int i in arr){
                if(i > y){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void SquareValues(int[] arr){
            int val = 0;
            string output = "[";

            foreach(int i in arr){
                val = i*i;
                output += val + ",";
            }
            output += "]";
            Console.WriteLine(output);
        }
        public static void ElimNegatives(int[] arr){
            string output = "[";

            for(int i=0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                    output += arr[i] + ",";
                }else{
                    output += arr[i] + ",";
                }
            }
            output += "]";
            Console.WriteLine(output);
        }
        public static void MinMaxAvg(int[] arr){
            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            foreach(int i in arr){

                sum += i;

                if(i > max){
                    max =i;
                }
                if(i < min){
                    min = i;
                }
            }
            Console.WriteLine("The max of the array is {0}, min is {1}, average is {2}", max, min, sum/arr.Length);
        }
        public static void ShiftValues(int[] arr){
            string output = "[";
            for(int i=0; i < arr.Length-1; i++){
                arr[i] = arr[i+1];
                output += arr[i] + ",";
            }
            output += 0 + "]";
            Console.WriteLine(output);
        }

        public static object[] NumberToString(object[] arr){
            for(int i = 0; i < arr.Length; i++){
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }

        public static void Main(string[] args)
        {
            int[] newArr = new int[6] {2, 10, 3, 11, 12, 13};
            int[] myArr = new int[4] {1, 5, 10, -2};
            // Print1to255();
            // PrintOdd1to255();
            // PrintSum();
            // PrintIterArray(newArr);
            // FindMax(newArr);
            // GetAverage(newArr);
            // ArrayWithOdds();
            // GreaterThanY(newArr, 3);
            // SquareValues(newArr);
            // ElimNegatives(myArr);
            // MinMaxAvg(newArr);
            // ShiftValues(myArr);
            object[] boxedArray = new object[] {-1, 3, 2, 16};
            NumberToString(boxedArray);
        }
    }
}
