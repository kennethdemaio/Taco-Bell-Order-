﻿using System;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name + "So is mine!");
            Console.WriteLine("How's your day");
            string day = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
