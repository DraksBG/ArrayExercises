﻿using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // [Hey, hello, 2, 4]
            string[] arrOne = Console.ReadLine().Split(' ');
            // [10, hey, 4, hello]
            string[] arrTwo = Console.ReadLine().Split(' ');

            foreach (string currElement in arrOne)
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    string secondCurElement = arrTwo[i];
                    if (currElement == secondCurElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }

        }
    }
}
