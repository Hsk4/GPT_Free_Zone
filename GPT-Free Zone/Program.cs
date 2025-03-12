using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consonents_Vowels.ConsonentsandVowels();
            //wordFrequencyCounter.FrequencyCounter();
            //letterFrequencyCounter.FrequencyCounter();

            //Random coin = new Random();
            //int flip = coin.Next(0, 2);
            //Console.WriteLine((flip == 0) ? "heads" : "tails");
            //Console.ReadLine();

            //ifElseConversion.Statements();
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
