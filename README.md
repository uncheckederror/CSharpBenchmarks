# CSharpBenchmarks
 Identify and compare the performance of loops and data structures in dotnet.

# Read All Elements
|     Method |       N |             Mean |         Error |        StdDev |           Median |
|----------- |-------- |-----------------:|--------------:|--------------:|-----------------:|
|      Array |      10 |         6.161 ns |     0.0545 ns |     0.0509 ns |         6.156 ns |
|       List |      10 |        39.898 ns |     0.1211 ns |     0.1133 ns |        39.835 ns |
| Dictionary |      10 |        47.190 ns |     1.0198 ns |     1.4948 ns |        46.409 ns |
| Enumerable |      10 |        85.217 ns |     0.3046 ns |     0.2850 ns |        85.210 ns |
|      Array |     100 |        87.554 ns |     0.2505 ns |     0.2343 ns |        87.460 ns |
|       List |     100 |       357.676 ns |     0.5226 ns |     0.4633 ns |       357.746 ns |
| Dictionary |     100 |       397.316 ns |     1.0573 ns |     0.9890 ns |       396.832 ns |
| Enumerable |     100 |       704.775 ns |     0.2638 ns |     0.2339 ns |       704.722 ns |
|      Array |    1000 |       801.526 ns |     2.2094 ns |     2.0667 ns |       800.401 ns |
|       List |    1000 |     3,386.507 ns |     4.5155 ns |     3.7707 ns |     3,387.556 ns |
| Dictionary |    1000 |     3,798.016 ns |     2.5356 ns |     2.1174 ns |     3,798.638 ns |
| Enumerable |    1000 |     6,741.304 ns |     3.1531 ns |     2.7951 ns |     6,742.274 ns |
|      Array |   10000 |     7,949.929 ns |     1.1246 ns |     0.9969 ns |     7,949.983 ns |
|       List |   10000 |    33,555.789 ns |     5.6099 ns |     4.6845 ns |    33,556.555 ns |
| Dictionary |   10000 |    37,776.747 ns |    19.2130 ns |    16.0437 ns |    37,772.565 ns |
| Enumerable |   10000 |    67,145.710 ns |    51.2869 ns |    45.4645 ns |    67,130.145 ns |
|      Array |  100000 |    79,946.232 ns |    87.9432 ns |    82.2621 ns |    79,913.831 ns |
|       List |  100000 |   335,403.868 ns |    94.0990 ns |    83.4164 ns |   335,412.427 ns |
| Dictionary |  100000 |   377,354.475 ns |   152.1656 ns |   134.8908 ns |   377,293.213 ns |
| Enumerable |  100000 |   670,825.321 ns |   136.3426 ns |   120.8642 ns |   670,817.920 ns |
|      Array | 1000000 |   801,527.434 ns |   468.8102 ns |   391.4778 ns |   801,441.992 ns |
|       List | 1000000 | 3,354,368.359 ns |   736.7150 ns |   615.1904 ns | 3,354,263.281 ns |
| Dictionary | 1000000 | 3,823,237.500 ns | 3,331.5829 ns | 2,782.0226 ns | 3,822,852.344 ns |
| Enumerable | 1000000 | 6,709,897.489 ns | 1,196.0691 ns | 1,060.2841 ns | 6,709,939.062 ns |


# Read a Random Element
|     Method |       N |     Mean |    Error |   StdDev |   Median |
|----------- |-------- |---------:|---------:|---------:|---------:|
|      Array |      10 | 18.18 ns | 0.016 ns | 0.014 ns | 18.19 ns |
|       List |      10 | 18.28 ns | 0.006 ns | 0.005 ns | 18.28 ns |
| Dictionary |      10 | 32.07 ns | 0.375 ns | 0.351 ns | 31.80 ns |
| Enumerable |      10 | 62.18 ns | 0.742 ns | 0.694 ns | 61.85 ns |
|      Array |     100 | 18.49 ns | 0.006 ns | 0.005 ns | 18.48 ns |
|       List |     100 | 18.73 ns | 0.006 ns | 0.006 ns | 18.73 ns |
| Dictionary |     100 | 31.79 ns | 0.012 ns | 0.010 ns | 31.78 ns |
| Enumerable |     100 | 62.34 ns | 0.907 ns | 0.849 ns | 62.38 ns |
|      Array |    1000 | 18.49 ns | 0.009 ns | 0.008 ns | 18.49 ns |
|       List |    1000 | 18.28 ns | 0.004 ns | 0.004 ns | 18.28 ns |
| Dictionary |    1000 | 31.31 ns | 0.007 ns | 0.006 ns | 31.31 ns |
| Enumerable |    1000 | 64.46 ns | 0.188 ns | 0.166 ns | 64.39 ns |
|      Array |   10000 | 18.19 ns | 0.007 ns | 0.006 ns | 18.19 ns |
|       List |   10000 | 19.15 ns | 0.038 ns | 0.035 ns | 19.12 ns |
| Dictionary |   10000 | 33.23 ns | 0.471 ns | 0.417 ns | 33.44 ns |
| Enumerable |   10000 | 62.00 ns | 0.822 ns | 0.769 ns | 61.56 ns |
|      Array |  100000 | 19.11 ns | 0.179 ns | 0.159 ns | 19.17 ns |
|       List |  100000 | 19.72 ns | 0.431 ns | 0.513 ns | 19.44 ns |
| Dictionary |  100000 | 43.44 ns | 0.914 ns | 0.939 ns | 42.69 ns |
| Enumerable |  100000 | 62.32 ns | 0.850 ns | 0.795 ns | 61.88 ns |
|      Array | 1000000 | 20.10 ns | 0.298 ns | 0.264 ns | 20.22 ns |
|       List | 1000000 | 20.16 ns | 0.025 ns | 0.023 ns | 20.15 ns |
| Dictionary | 1000000 | 72.44 ns | 1.280 ns | 1.198 ns | 72.15 ns |
| Enumerable | 1000000 | 63.78 ns | 0.770 ns | 0.720 ns | 63.55 ns |

# Read the First Element
|     Method |       N |       Mean |     Error |    StdDev |
|----------- |-------- |-----------:|----------:|----------:|
|      Array | 1000000 |  0.4473 ns | 0.0008 ns | 0.0006 ns |
|       List | 1000000 |  0.4450 ns | 0.0002 ns | 0.0002 ns |
| Enumerable | 1000000 | 43.8761 ns | 0.3056 ns | 0.2709 ns |

# Read the Last Element
|     Method |       N |       Mean |     Error |    StdDev |
|----------- |-------- |-----------:|----------:|----------:|
|      Array | 1000000 |  0.5257 ns | 0.0018 ns | 0.0017 ns |
|       List | 1000000 |  0.4024 ns | 0.0013 ns | 0.0011 ns |
| Enumerable | 1000000 | 43.7647 ns | 0.1312 ns | 0.1096 ns |

# Read a Specific Element
|     Method |       N |             Mean |          Error |         StdDev |
|----------- |-------- |-----------------:|---------------:|---------------:|
|      Array |      10 |         6.586 ns |      0.0582 ns |      0.0516 ns |
|       List |      10 |        12.499 ns |      0.0041 ns |      0.0032 ns |
| Dictionary |      10 |        13.185 ns |      1.3779 ns |      1.4150 ns |
| Enumerable |      10 |       102.887 ns |      0.5625 ns |      0.5261 ns |
|      Array |     100 |        47.969 ns |      0.4176 ns |      0.3702 ns |
|       List |     100 |       108.668 ns |      0.4342 ns |      0.4062 ns |
| Dictionary |     100 |        12.433 ns |      0.0145 ns |      0.0121 ns |
| Enumerable |     100 |       248.719 ns |      0.5426 ns |      0.4810 ns |
|      Array |    1000 |       434.200 ns |      0.0458 ns |      0.0406 ns |
|       List |    1000 |       944.351 ns |      0.9707 ns |      0.8605 ns |
| Dictionary |    1000 |        12.957 ns |      0.2982 ns |      0.2790 ns |
| Enumerable |    1000 |     1,574.623 ns |      2.5326 ns |      2.2451 ns |
|      Array |   10000 |     4,210.605 ns |      5.7470 ns |      5.3757 ns |
|       List |   10000 |     9,279.196 ns |      9.4236 ns |      7.8692 ns |
| Dictionary |   10000 |        12.429 ns |      0.0126 ns |      0.0098 ns |
| Enumerable |   10000 |    14,886.387 ns |     22.7724 ns |     21.3014 ns |
|      Array |  100000 |    41,962.231 ns |     74.8830 ns |     62.5307 ns |
|       List |  100000 |    93,410.210 ns |     89.5474 ns |     74.7761 ns |
| Dictionary |  100000 |        12.423 ns |      0.0059 ns |      0.0055 ns |
| Enumerable |  100000 |   147,027.398 ns |     46.7962 ns |     41.4836 ns |
|      Array | 1000000 |   424,265.472 ns |    101.5233 ns |     94.9650 ns |
|       List | 1000000 |   939,321.791 ns |    292.7719 ns |    259.5346 ns |
| Dictionary | 1000000 |        12.423 ns |      0.0040 ns |      0.0038 ns |
| Enumerable | 1000000 | 1,480,188.236 ns | 13,180.8004 ns | 11,006.5653 ns |

# Loop Over All Elements in an Array
|      Method |       N |             Mean |          Error |         StdDev |
|------------ |-------- |-----------------:|---------------:|---------------:|
|         For |      10 |        10.092 ns |      0.0761 ns |      0.0636 ns |
|     ForEach |      10 |         8.532 ns |      0.1410 ns |      0.1319 ns |
|       While |      10 |        10.293 ns |      0.0142 ns |      0.0126 ns |
|          Do |      10 |         9.463 ns |      0.0022 ns |      0.0017 ns |
| LinqForEach |      10 |        37.851 ns |      0.7499 ns |      0.7014 ns |
|         For |     100 |        89.157 ns |      0.7500 ns |      0.7015 ns |
|     ForEach |     100 |        88.485 ns |      0.6530 ns |      0.6108 ns |
|       While |     100 |        87.203 ns |      0.8655 ns |      0.8096 ns |
|          Do |     100 |        87.800 ns |      1.1368 ns |      1.0633 ns |
| LinqForEach |     100 |       304.856 ns |      0.0499 ns |      0.0467 ns |
|         For |    1000 |       759.057 ns |      2.8052 ns |      2.4867 ns |
|     ForEach |    1000 |       800.717 ns |      0.0496 ns |      0.0439 ns |
|       While |    1000 |       765.847 ns |      2.0338 ns |      1.9024 ns |
|          Do |    1000 |       969.947 ns |      2.1211 ns |      1.9841 ns |
| LinqForEach |    1000 |     2,946.775 ns |      1.0872 ns |      0.8488 ns |
|         For |   10000 |     7,494.429 ns |     43.9420 ns |     41.1034 ns |
|     ForEach |   10000 |     7,951.526 ns |      0.8870 ns |      0.8297 ns |
|       While |   10000 |     7,562.739 ns |     51.6215 ns |     48.2868 ns |
|          Do |   10000 |     9,606.610 ns |      4.2369 ns |      3.9632 ns |
| LinqForEach |   10000 |    33,557.250 ns |      6.1974 ns |      5.7971 ns |
|         For |  100000 |    75,915.844 ns |    983.6556 ns |    920.1120 ns |
|     ForEach |  100000 |    79,779.571 ns |     74.3181 ns |     69.5172 ns |
|       While |  100000 |    76,235.844 ns |    641.2917 ns |    599.8646 ns |
|          Do |  100000 |    96,133.747 ns |     18.5915 ns |     17.3905 ns |
| LinqForEach |  100000 |   293,485.479 ns |     49.5584 ns |     41.3835 ns |
|         For | 1000000 |   767,837.919 ns | 13,001.5791 ns | 11,525.5612 ns |
|     ForEach | 1000000 |   802,731.211 ns |    885.6206 ns |    828.4100 ns |
|       While | 1000000 |   758,898.828 ns |  4,444.6630 ns |  3,940.0780 ns |
|          Do | 1000000 |   966,888.965 ns |  2,182.4345 ns |  1,934.6714 ns |
| LinqForEach | 1000000 | 3,387,192.634 ns | 46,635.7189 ns | 41,341.3501 ns |

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
