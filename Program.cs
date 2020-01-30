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
    [MemoryDiagnoser]
    public class ReadAll
    {
        private int[] array;
        private List<int> list;
        private Dictionary<int, int> dictionary;
        private IEnumerable<int> enumerable;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(42);
            array = new int[N];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            enumerable = array;
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            foreach (var i in array)
            {
                // The underscore is a varible that is captured and then immediately disguarded, because we don't care about its value.
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
    [MemoryDiagnoser]
    public class ReadSingleRandom
    {
        private int[] array;
        private List<int> list;
        private Dictionary<int, int> dictionary;
        private IEnumerable<int> enumerable;
        private readonly Random random = new Random();

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            array = new int[N];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            enumerable = array;
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            var element = random.Next(0, N - 1);
            _ = array[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            var element = random.Next(0, N - 1);
            _ = list[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            var element = random.Next(0, N - 1);
            _ = dictionary[element];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            var element = random.Next(0, N - 1);
            _ = enumerable.ElementAtOrDefault(element);
        }
    }

    /// <summary>
    /// Compares the performance of reading just the first element in a Data Structure.
    /// </summary>
    [MemoryDiagnoser]
    public class ReadFirst
    {
        private int[] array;
        private List<int> list;
        private Dictionary<int, int> dictionary;
        private IEnumerable<int> enumerable;

        [Params(1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            array = new int[N];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            enumerable = array;
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

        // This isn't meaningful because dictionaries aren't ordered. There's no 'first' or 'last'.
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        //[Benchmark]
        //public void Dictionary()
        //{
        //    _ = dictionary.Values.FirstOrDefault();
        //}

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
    [MemoryDiagnoser]
    public class ReadLast
    {
        private int[] array;
        private List<int> list;
        private Dictionary<int, int> dictionary;
        private IEnumerable<int> enumerable;

        [Params(1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            array = new int[N];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            enumerable = array;
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            _ = array[^1];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void List()
        {
            _ = list[list.Count - 1];
        }

        // This isn't meaningful because dictionaries aren't ordered. There's no 'first' or 'last'.
        //// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        //[Benchmark]
        //public void Dictionary()
        //{
        //    _ = dictionary.Values.LastOrDefault();
        //}

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
    [MemoryDiagnoser]
    public class ReadSingleSpecific
    {
        private int[] array;
        private List<int> list;
        private Dictionary<int, int> dictionary;
        private IEnumerable<int> enumerable;
        private int specificValue;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            array = new int[N];
            list = new List<int>();
            dictionary = new Dictionary<int, int>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
                list.Add(randomInt);
                dictionary.Add(i, randomInt);
            }

            specificValue = 999999;
            array[N / 2] = specificValue;
            list[N / 2] = specificValue;
            dictionary[N / 2] = specificValue;

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
                    // Exit the loop when this statement is hit.
                    break;
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
                    // Exit the loop when this statement is hit.
                    break;
                }
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void Dictionary()
        {
            _ = dictionary[N / 2];
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netcore-3.1
        [Benchmark]
        public void Enumerable()
        {
            _ = enumerable.Where(x => x == specificValue).FirstOrDefault();
        }
    }

    /// <summary>
    /// Compares the performance of inserting all elements from an Array into a DataStructure.
    /// </summary>
    [MemoryDiagnoser]
    public class WriteAll
    {
        private int[] array;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(42);
            array = new int[N];

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                array[i] = randomInt;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
        [Benchmark]
        public void Array()
        {
            var localArray = new int[N];

            for (var i = 0; i < localArray.Length; i++)
            {
                localArray[i] = array[i];
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void ListAdd()
        {
            var localList = new List<int>();

            foreach (var i in array)
            {
                localList.Add(i);
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
        [Benchmark]
        public void ListAddRange()
        {
            var localList = new List<int>();

            localList.AddRange(array);
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void DictionaryAdd()
        {
            var localDictionary = new Dictionary<int, int>();
            for (var i = 0; i < array.Length; i++)
            {
                localDictionary.Add(i, array[i]);
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-3.1
        [Benchmark]
        public void DictionaryTryAdd()
        {
            var localDictionary = new Dictionary<int, int>();
            for (var i = 0; i < array.Length; i++)
            {
                var check = localDictionary.TryAdd(i, array[i]);

                // There's no point in having a boolean returned unless you use it, so I'm including it in this benchmark.
                if (!check)
                {
                    throw new Exception("This should never be hit.");
                }
            }
        }
    }

    public class SimpleObject
    {
        public int Id { get; set; }
        public int Data { get; set; }
    }

    /// <summary>
    /// What's the fastest way to copy values from a Dictionary to a Stack?
    /// </summary>
    [MemoryDiagnoser]
    public class CopyDictionaryToStack
    {
        private Dictionary<int, SimpleObject> dictionary;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            dictionary = new Dictionary<int, SimpleObject>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                dictionary.Add(i, new SimpleObject { Id = i, Data = randomInt });
            }
        }

        [Benchmark]
        public void ForEach()
        {
            var localStack = new Stack<int>();
            foreach (var item in dictionary)
            {
                localStack.Push(item.Value.Data);
            }
            _ = localStack.Peek();
        }

        [Benchmark]
        public void LinqSelect()
        {
            var localStack = new Stack<int>(dictionary.Values.Select(x => x.Data));
            _ = localStack.Peek();
        }

        [Benchmark]
        public void LinqSelectIntermediate()
        {
            var values = dictionary.Values.ToList().Select(x => x.Data);
            var localStack = new Stack<int>(values);
            _ = localStack.Peek();
        }
    }

    /// <summary>
    /// Does dumping a data structure to an array before looping over it improve performance?
    /// </summary>
    [MemoryDiagnoser]
    public class DataStructureToArrayForeach
    {
        private Dictionary<int, SimpleObject> dictionary;
        private List<SimpleObject> list;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            dictionary = new Dictionary<int, SimpleObject>();
            list = new List<SimpleObject>();

            // Fill each data structure with the same random ints.
            for (var i = 0; i < N; i++)
            {
                var randomInt = random.Next();
                list.Add(new SimpleObject { Id = i, Data = randomInt });
                dictionary.Add(i, new SimpleObject { Id = i, Data = randomInt });
            }
        }

        [Benchmark]
        public void ListForeach()
        {
            foreach (var item in list)
            {
                _ = item.Data;
            }
        }

        [Benchmark]
        public void ListToArrayForeach()
        {
            // .ToArray() use the Array.Copy method to create a new array before iterating over it.
            // https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=netcore-3.1
            foreach (var item in list.ToArray())
            {
                _ = item.Data;
            }
        }

        [Benchmark]
        public void DictionaryForeach()
        {
            foreach (var item in dictionary)
            {
                _ = item.Value.Data;
            }
        }

        [Benchmark]
        public void DictionaryValuesToArrayForeach()
        {
            foreach (var item in dictionary.Values.ToArray())
            {
                _ = item.Data;
            }
        }

        [Benchmark]
        public void DictionaryToArrayForeach()
        {
            foreach (var item in dictionary.ToArray())
            {
                _ = item.Value.Data;
            }
        }
    }

    /// <summary>
    /// Compares the performance of loops.
    /// </summary>
    [MemoryDiagnoser]
    public class LoopAllElements
    {
        private int[] data;
        private List<int> dataAsList;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            data = new int[N];

            for (var i = 0; i < N; i++)
            {
                data[i] = random.Next();
            }

            // A list is required to use the .ForEach() method.
            dataAsList = data.ToList();
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

        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.foreach?view=netcore-3.1
        [Benchmark]
        public void LinqForEach()
        {
            dataAsList.ForEach(x => _ = x);
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
            var writeAll = BenchmarkRunner.Run<WriteAll>();
            var dictionaryToStack = BenchmarkRunner.Run<CopyDictionaryToStack>();
            var toArray = BenchmarkRunner.Run<DataStructureToArrayForeach>();
            var loops = BenchmarkRunner.Run<LoopAllElements>();
        }
    }
}