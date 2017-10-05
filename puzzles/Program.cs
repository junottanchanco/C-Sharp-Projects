using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    public class Program
    {
        public static void RandomArray(){
            Random rand = new Random();
            int[] randArray = new int[10];
            string output = "[";
            int sum = 0;

            for(int i=0; i < randArray.Length; i++){
                int val = rand.Next(5, 26);
                randArray[i] = val;
                output += val + ",";
                sum += val;
            }
            output += "]";
            Console.WriteLine(output);
            Console.WriteLine("Max: {0} Min: {1} Sum: {2}", randArray.Max(), randArray.Min(), sum);
        }

        public static string TossCoin(){
            Console.WriteLine("Tossing a coin!");
            List<int> randList = new List<int>();
            Random rand = new Random();
            
            for(int x = 0; x < 100; x++){
                randList.Add(rand.Next(5,1000));
            }
            int[] numArray = randList.ToArray();
            int sum = numArray[0];
            
            for(int i = 0; i < numArray.Length; i++){
                sum += numArray[i];
            }

            int randcoin = sum*101;
            randcoin = randcoin/51;
            Console.WriteLine(randcoin);

            string coin;
            if(randcoin % 2 != 0){
                coin = "Heads";
            }else{
                coin = "Tails";
            }
            Console.WriteLine("+coin+");
            return coin;
        }
        public static Double TossMultipleCoins(int num){
            double headCount = 0;
            double tailCount = 0;
            double ratioHeadsToTails = 0;

            Random rand = new Random();

            for(int x = 0; x < num; x++){
                int curRand = rand.Next(5,1000);
                if(curRand % 2 == 0){
                    headCount++;
                }else{
                    tailCount++;
                }
            }
            Console.WriteLine("Getting ratio of heads to tails...");
            ratioHeadsToTails = (headCount/tailCount)*100;
            ratioHeadsToTails = Math.Round(ratioHeadsToTails, 2);
            Console.WriteLine("You asked to flip "+num+" coins. Done! Ratio of heads to tails was "+ratioHeadsToTails+"% heads to tails. I counted "+headCount+" heads and "+tailCount+" tails.");

            return ratioHeadsToTails;
        }

        public string[] Names() {
            string[] names = new string[5] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            
            Random rand = new Random();
            for(var idx = 0; idx < names.Length - 1; idx++){
                int randIdx = rand.Next(idx + 1, names.Length - 1);
                string temp = names[idx];
                names[idx] = names[randIdx];
                names[randIdx] = temp;
                
                Console.WriteLine(names[idx]);
            }
            
            Console.WriteLine(names[names.Length - 1]);

            List<string> nameList = new List<string>();
            foreach(var name in names) {
                nameList.Add(name);
            }
            return nameList.ToArray();
        }
        public static void Main(string[] args)
        {
            // RandomArray();
            TossMultipleCoins(100);

            
        }
    }
}
