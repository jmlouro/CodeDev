using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    internal class Program
    {
        private static int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

        public static void Main()
        {
            Console.WriteLine(matrix);
            Convert(1);
            Convert(2);
            Convert(3);
        }

        public static string Convert(int i)
        {
            Dictionary<int, string> map = new Dictionary<int, string>() 
            {
                { 0, "zero"},
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five"}
            };

            if (map.ContainsKey(i))
            { 
                return map[i];
            }

            return "nope";
        }
    }
}
