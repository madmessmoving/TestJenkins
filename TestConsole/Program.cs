﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lets try to print 0 - 99.");
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
