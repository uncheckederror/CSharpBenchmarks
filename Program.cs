using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    /// <summary>
    /// Compares the read all performance of Data Structures.
    /// </summary>
    public class ReadAll
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;

        public ReadAll()
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
    /// Compares the random single read performance of Data Structures.
    /// </summary>
    public class ReadSingleRandom
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;
        private readonly Random random = new Random();

        public ReadSingleRandom()
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
            var element = random.Next(0, 10000);
            _ = array[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            var element = random.Next(0, 10000);
            _ = list[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            var element = random.Next(0, 10000);
            _ = dictionary[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            var element = random.Next(0, 10000);
            _ = enumerable.ElementAtOrDefault(element);
        }
    }

    /// <summary>
    /// Compares the performance of reading just the first element in a Data Structure.
    /// </summary>
    public class ReadFirst
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;

        public ReadFirst()
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
            _ = array[0];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            _ = list[0];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            // This isn't meaningful because dictionaries aren't ordered. There's no 'first' or 'last'.
            _ = dictionary.Values.FirstOrDefault();
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            _ = enumerable.FirstOrDefault();
        }
    }

    /// <summary>
    /// Compares the performance of reading just the last element in a Data Structure.
    /// </summary>
    public class ReadLast
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;

        public ReadLast()
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
            _ = array[array.Length];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            _ = list[list.Count];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            // This isn't meaningful because dictionaries aren't ordered. There's no 'first' or 'last'.
            _ = dictionary.Values.LastOrDefault();
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            _ = enumerable.LastOrDefault();
        }
    }

    /// <summary>
    /// Compares the performance of reading a single known element in a Data Structure.
    /// </summary>
    public class ReadSingleSpecific
    {
        private readonly int[] array;
        private readonly List<int> list;
        private readonly Dictionary<int, int> dictionary;
        private readonly IEnumerable<int> enumerable;
        private readonly int specificValue;

        public ReadSingleSpecific()
        {
            var random = new Random();
            array = new int[10000];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < 10000; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            specificValue = 999999;
            array[100] = specificValue;
            list[100] = specificValue;
            dictionary[100] = specificValue;
            enumerable = array;
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == specificValue)
                {
                    _ = array[i];
                }
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == specificValue)
                {
                    _ = list[i];
                }
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            // This isn't meaningful because dictionaries aren't ordered. There's no 'first' or 'last'.
            _ = dictionary[100];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            _ = enumerable.Where(x => x == specificValue).FirstOrDefault();
        }
    }


    /// <summary>
    /// Compares the performance of loops.
    /// </summary>
    public class Loops
    {
        private readonly int[] data;

        public Loops()
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
            var readAll = BenchmarkRunner.Run<ReadAll>();
            var readSingleRandom = BenchmarkRunner.Run<ReadSingleRandom>();
            var readFirst = BenchmarkRunner.Run<ReadFirst>();
            var readLast = BenchmarkRunner.Run<ReadLast>();
            var readSingleSpecific = BenchmarkRunner.Run<ReadSingleSpecific>();

            var loops = BenchmarkRunner.Run<Loops>();
        }
    }
}