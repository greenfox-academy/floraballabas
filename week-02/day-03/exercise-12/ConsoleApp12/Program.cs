﻿using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            string temp = list[2];
            list[2] = list[5];
            list[5] = temp;
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is 


            //to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.
            foreach (string output in list)
            {
                Console.Write(output+" ");
            }
            Console.ReadLine();
        }
    }
}
