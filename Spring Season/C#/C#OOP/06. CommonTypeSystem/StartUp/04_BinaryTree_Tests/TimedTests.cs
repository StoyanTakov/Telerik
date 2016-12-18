﻿namespace StartUp._04_BinaryTree_Tests
{
    using OrderedBinarySearchTreeAssembly.Models;
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    public static class TimedTests
    {
        public const int NumberOfElemets = 40000;
        public const int NumberOfRuns = 15000;
        public const int NumberOfRunsTofill = 200; 
        public const int MinValue = 0;
        public const int MaxValue = 9999999;
        
        
        static readonly Random Random;

        static TimedTests()
        {
            Random = new Random();
        }

        public static void TimeToGenerate()
        {
            PrintHeader(" Time to fill: List<int> Vs BinarySearchTree<int>");

            // Generate input
            List<int> list;
            BinarySearchTree<int> tree;
            GenerateListAndTree(out list, out tree);

            var timeList = FillList(list);
            var timeTree = FillTree(list);

            Console.WriteLine("Fill List<int>        -> Total time: {0, 12:F4}ms, Average Time: {1, 16:F10}ms",
                timeList.TotalMilliseconds, timeList.TotalMilliseconds / NumberOfRunsTofill);

            Console.WriteLine("Fill Tree<int>        -> Total time: {0, 12:F4}ms, Average Time: {1, 16:F10}ms",
                timeTree.TotalMilliseconds, timeTree.TotalMilliseconds / NumberOfRunsTofill);

            Console.WriteLine();
        }

        public static void TimeSearchListVTree()
        {
            PrintHeader(" List<int>.Contains Vs BinarySearchTree<int>.Contains Vs Linq");

            // Generate input
            List<int> list;
            BinarySearchTree<int> tree;
            GenerateListAndTree(out list, out tree);

            var find = Random.Next(MinValue, MaxValue);

            var timeList = NaiveBenchmarkList(list, NumberOfRuns, find);
            var timeTree = NaiveBenchmarkTree(tree, NumberOfRuns, find);
            var timeLinq = NaiveBenchmarkLinq(list, NumberOfRuns, find);

            Console.WriteLine("List<int>.Contains()  -> Total time: {0, 12:F4}ms, Average Time: {1, 16:F10}ms",
                timeList.TotalMilliseconds, timeList.TotalMilliseconds / NumberOfRuns);

            Console.WriteLine("Tree<int>.Contains()  -> Total time: {0, 12:F4}ms, Average Time: {1, 16:F10}ms",
                timeTree.TotalMilliseconds, timeTree.TotalMilliseconds / NumberOfRuns);

            Console.WriteLine("Linq expression where -> Total time: {0, 12:F4}ms, Average Time: {1, 16:F10}ms",
                timeLinq.TotalMilliseconds, timeLinq.TotalMilliseconds / NumberOfRuns);

            Console.WriteLine();
        }
        
        private static TimeSpan FillTree(List<int> numbers)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < NumberOfRunsTofill; i++)
            {
                var tree = new BinarySearchTree<int>();
                for (int j = 0; j < NumberOfElemets; j++)
                {
                    tree.Add(numbers[j]);
                }
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        private static TimeSpan FillList(List<int> numbers)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < NumberOfRunsTofill; i++)
            {
                var list = new List<int>();
                for (int j = 0; j < NumberOfElemets; j++)
                {
                    list.Add(numbers[j]);
                }
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
        
        private static TimeSpan NaiveBenchmarkLinq
            (List<int> list, int runs, int find)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < runs; i++)
            {
                var test =
                    (from ints in list
                     where ints == find
                     select ints);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        private static TimeSpan NaiveBenchmarkTree
            (BinarySearchTree<int> tree, int runs, int find)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < runs; i++)
            {
                tree.Contains(find);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        private static TimeSpan NaiveBenchmarkList
            (List<int> list, int runs, int find)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < runs; i++)
            {
                list.Contains(find);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        private static void PrintHeader(string header)
        {
            Console.WriteLine(new string('-', 85));
            Console.WriteLine(header);
            Console.WriteLine(new string('-', 85));
        }

        private static void GenerateListAndTree
            (out List<int> list, out BinarySearchTree<int> tree)
        {
            list = new List<int>();
            tree = new BinarySearchTree<int>();

            for (int el = 0; el < NumberOfElemets; el++)
            {
                var add = Random.Next(MinValue, MaxValue);

                while (tree.Contains(add))
                {
                    add = Random.Next(MinValue, MaxValue);
                }

                list.Add(add);
                tree.Add(add);
            }
        }
    }
}
