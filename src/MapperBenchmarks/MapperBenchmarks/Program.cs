﻿using System;
using BenchmarkDotNet.Running;

namespace MapperBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("*****To achieve accurate results, set project configuration to Release mode.*****");
            return;
#endif
            BenchmarkRunner.Run<Benchmarks>(new Config());
            Console.ReadLine();
        }
    }
}
