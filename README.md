# CSharpBenchmarks
 Identify and compare the performance of loops and data structures in dotnet.

# Read All Elements from a Data Structure
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Xeon CPU E5-2630 v3 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


|     Method |      Mean |     Error |    StdDev |
|----------- |----------:|----------:|----------:|
|      Array |  7.949 us | 0.0021 us | 0.0020 us |
|       List | 34.020 us | 0.7840 us | 0.7334 us |
| Dictionary | 37.766 us | 0.0137 us | 0.0121 us |
| Enumerable | 75.230 us | 0.2556 us | 0.1996 us |

# Loop Over All Elements in an Array
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Xeon CPU E5-2630 v3 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
|     For | 7.520 us | 0.1081 us | 0.0958 us |
| ForEach | 7.957 us | 0.0018 us | 0.0014 us |
|   While | 7.486 us | 0.0570 us | 0.0505 us |
|      Do | 7.499 us | 0.0648 us | 0.0606 us |

# Run these Benchmarks Locally on Windows 10
* Clone the repo to your local machine.
* Open the DataStructuresBenchmark.sln file in Visual Studio 2019 16.4 or higher.
* Run the DataStructuresBenchmark console app project in "Release" mode.

There's no platform specific code in this repo, but I haven't tried it elsewhere so YMMV.
