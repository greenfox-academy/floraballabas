﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeWillNever
{
    public class HeWillNever
    {
        public static void Main(string[] args)
        {
            string output = "";
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you");
            map.Add(49, "make you cry,");
            map.Add(2, "let you down");
            map.Add(12, "give you up,");
            map.Add(1, "Never gonna");
            map.Add(11, "\n");
            map.Add(3, "say goodbye");

            // Things are a little bit messed up
            // Your job is to decode the notSoCrypticMessage by using the hashmap as a look up table
            // Assemble the fragments into the out variable
            StringBuilder sb = new StringBuilder();

            foreach (int item in notSoCrypticMessage)
            {
                sb.Append(map[item]);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
