using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one way attribute way of creating an array
            int[] luckynumbers = { 4, 5, 8, 9 };
            Console.WriteLine(luckynumbers[0]);
            //if you wanna populate it later, the 5 is the size
            string[] friends = new string[5];
            friends[0] = "Bonolo";
            friends[1] = "koketso";
            friends[2] = "onalerona";
            Console.WriteLine(friends[0]);

            Console.Read();
        }
    }
}
