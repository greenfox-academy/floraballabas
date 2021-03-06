﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(Recursive(12));
            Console.ReadLine();
        }

        private static int Recursive(int bunny)
        {
            if (bunny == 0)
                return 0;
            else if (bunny % 2 == 0)
                return 3 + Recursive(bunny - 1);
            return 2 + Recursive(bunny-1);  
        }
    }
}
