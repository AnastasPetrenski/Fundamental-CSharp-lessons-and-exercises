﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSumMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> index = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                if (nums.Take(i).Sum() == nums.Skip(i + 1).Take(nums.Length - i).Sum())
                    index.Add(i);

            if (index.Count > 0)
                Console.WriteLine(string.Join(", ", index));
            else
                Console.WriteLine("no");
        }
    }
}