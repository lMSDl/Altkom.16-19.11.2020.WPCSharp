﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            var buffer = new Buffer<string>(list);

            var list2 = new List<string>();
            foreach (var item in buffer)
            {
                var x = item[0] + item[1];
                Console.WriteLine(x);
                list2.Add(x);
            }

            foreach (var item in new Buffer<string>(list2))
            {
                var x = item[0] + item[1];
                Console.WriteLine(x);
            }

        }
    }
}
