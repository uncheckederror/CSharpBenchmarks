# CSharpBenchmarks
 Identify and compare the performance of loops and data structures in dotnet.

# Read All Elements
|     Method |      Mean |     Error |    StdDev |
|----------- |----------:|----------:|----------:|
|      Array |  7.949 us | 0.0021 us | 0.0020 us |
|       List | 34.020 us | 0.7840 us | 0.7334 us |
| Dictionary | 37.766 us | 0.0137 us | 0.0121 us |
| Enumerable | 75.230 us | 0.2556 us | 0.1996 us |

# Read a Random Element
|     Method |     Mean |    Error |   StdDev |
|----------- |---------:|---------:|---------:|
|      Array | 18.27 ns | 0.012 ns | 0.010 ns |
|       List | 19.99 ns | 0.386 ns | 0.361 ns |
| Dictionary | 33.46 ns | 0.656 ns | 0.614 ns |
| Enumerable | 61.89 ns | 0.553 ns | 0.517 ns |

# Read the First Element
|     Method |       Mean |     Error |    StdDev |
|----------- |-----------:|----------:|----------:|
|      Array |  0.1240 ns | 0.0159 ns | 0.0149 ns |
|       List |  0.4492 ns | 0.0059 ns | 0.0055 ns |
| Dictionary | 43.2668 ns | 0.1045 ns | 0.0872 ns |
| Enumerable | 44.7244 ns | 0.1574 ns | 0.1472 ns |

# Read the Last Element
|     Method |            Mean |       Error |      StdDev |
|----------- |----------------:|------------:|------------:|
|      Array |       0.4676 ns |   0.0358 ns |   0.0335 ns |
|       List |       0.4549 ns |   0.0079 ns |   0.0074 ns |
| Dictionary | 105,284.8467 ns | 138.5369 ns | 122.8093 ns |
| Enumerable |      44.5685 ns |   0.1821 ns |   0.1422 ns |

# Read a Specific Element
|     Method |      Mean |    Error |   StdDev |
|----------- |----------:|---------:|---------:|
|      Array |  99.59 ns | 0.112 ns | 0.100 ns |
|       List | 201.13 ns | 1.051 ns | 0.983 ns |
| Dictionary |  10.62 ns | 0.022 ns | 0.019 ns |
| Enumerable | 398.70 ns | 0.807 ns | 0.715 ns |

# Loop Over All Elements in an Array
|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
|     For | 7.520 us | 0.1081 us | 0.0958 us |
| ForEach | 7.957 us | 0.0018 us | 0.0014 us |
|   While | 7.486 us | 0.0570 us | 0.0505 us |
|      Do | 7.499 us | 0.0648 us | 0.0606 us |

# Benchmark System
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Xeon CPU E5-2630 v3 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

# Run these Benchmarks Locally on Windows 10
* Clone the repo to your local machine.
* Open the DataStructuresBenchmark.sln file in Visual Studio 2019 16.4 or higher.
* Run the DataStructuresBenchmark console app project in "Release" mode.

There's no platform specific code in this repo, but I haven't tried it elsewhere so YMMV.
