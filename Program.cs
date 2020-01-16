using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    /// <summary>
    /// Compares the performance of Data Structures.
    /// </summary>
    public class DataStructures
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;

        public DataStructures()
        {
            var random = new Random();
            array = new int[10000];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();
            enumerable = array;

            // Fill each data structure with the same random ints.
            for (var i = 0; i < 10000; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            foreach (var i in array)
            {
                // The underscore is a varible that is imedately disguarded, because we don't care about its value.
                // https://docs.microsoft.com/en-us/dotnet/csharp/discards
                _ = i;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            foreach (var i in list)
            {
                _ = i;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            foreach (var i in dictionary.Values)
            {
                _ = i;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            foreach (var i in enumerable)
            {
                _ = i;
            }
        }
    }

    /// <summary>
    /// Compares the performance of loops.
    /// </summary>
    public class ForLoops
    {
        private readonly int[] data;

        public ForLoops()
        {
            var random = new Random();
            data = new int[10000];

            for (var i = 0; i < 10000; i++)
            {
                data[i] = random.Next();
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for
        [Benchmark]
        public void For()
        {
            for (var i = 0; i < data.Length; i++)
            {
                _ = data[i];
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
        [Benchmark]
        public void ForEach()
        {
            foreach (var i in data)
            {
                _ = i;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while
        [Benchmark]
        public void While()
        {
            int count = 0;
            while (count < data.Length)
            {
                _ = data[count];
                count++;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do
        [Benchmark]
        public void Do()
        {
            int count = 0;
            do
            {
                _ = data[count];
                count++;
            }
            while (count < data.Length);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var dsSummary = BenchmarkRunner.Run<DataStructures>();
            var flSummary = BenchmarkRunner.Run<ForLoops>();
        }
    }
}