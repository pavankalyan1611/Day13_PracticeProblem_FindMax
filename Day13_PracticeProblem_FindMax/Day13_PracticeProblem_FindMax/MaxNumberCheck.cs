﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FindMax
{   
    public class MaxNumberCheck
    {
        public static void FindMax<T>(params T[] inputArray)
        {
            Array.Sort(inputArray);
            Console.WriteLine(inputArray[inputArray.Length - 1]);
        }
    }    
}
