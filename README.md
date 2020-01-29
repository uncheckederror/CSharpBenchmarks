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

* Array's are the fastest data structure to read all elements from.
* Lists are 6.5 times slower when N = 10 and 4.15 times slower when N = 1M.
* Dictionary's are only ~20% slower than lists. A relatively minor performance hit.
* Using the IEnumerable interface on top of an Array is 14 times slower when N = 10 and 8.3 times slower when N = 1M.

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

# Write All Elements from an Array
|           Method |       N |             Mean |          Error |         StdDev |
|----------------- |-------- |-----------------:|---------------:|---------------:|
|            Array |      10 |         21.21 ns |       0.426 ns |       0.355 ns |
|          ListAdd |      10 |        130.28 ns |       2.389 ns |       3.022 ns |
|     ListAddRange |      10 |         72.76 ns |       0.503 ns |       0.420 ns |
|    DictionaryAdd |      10 |        411.26 ns |       2.480 ns |       2.319 ns |
| DictionaryTryAdd |      10 |        407.34 ns |       5.219 ns |       4.627 ns |
|            Array |     100 |        132.14 ns |       1.013 ns |       0.948 ns |
|          ListAdd |     100 |        587.36 ns |       1.509 ns |       1.260 ns |
|     ListAddRange |     100 |        124.97 ns |       0.721 ns |       0.639 ns |
|    DictionaryAdd |     100 |      3,667.09 ns |      37.273 ns |      34.865 ns |
| DictionaryTryAdd |     100 |      3,716.60 ns |      30.277 ns |      28.321 ns |
|            Array |    1000 |      1,156.67 ns |       8.862 ns |       8.290 ns |
|          ListAdd |    1000 |      3,927.04 ns |      26.012 ns |      23.059 ns |
|     ListAddRange |    1000 |        539.35 ns |       4.417 ns |       3.916 ns |
|    DictionaryAdd |    1000 |     34,235.61 ns |     120.323 ns |     100.475 ns |
| DictionaryTryAdd |    1000 |     35,260.67 ns |     145.700 ns |     129.159 ns |
|            Array |   10000 |     10,944.74 ns |      76.390 ns |      71.455 ns |
|          ListAdd |   10000 |     43,527.94 ns |     622.108 ns |     581.921 ns |
|     ListAddRange |   10000 |      5,924.37 ns |      49.652 ns |      46.445 ns |
|    DictionaryAdd |   10000 |    465,603.96 ns |   1,317.105 ns |   1,232.021 ns |
| DictionaryTryAdd |   10000 |    483,884.04 ns |   2,803.839 ns |   2,485.530 ns |
|            Array |  100000 |    258,269.28 ns |     324.509 ns |     287.669 ns |
|          ListAdd |  100000 |    663,242.71 ns |   8,379.884 ns |   7,838.548 ns |
|     ListAddRange |  100000 |    251,265.44 ns |     730.431 ns |     609.943 ns |
|    DictionaryAdd |  100000 |  3,575,937.11 ns |  18,988.172 ns |  16,832.520 ns |
| DictionaryTryAdd |  100000 |  3,736,792.30 ns |  15,093.308 ns |  13,379.824 ns |
|            Array | 1000000 |  1,547,204.93 ns |  30,466.430 ns |  48,322.987 ns |
|          ListAdd | 1000000 |  7,434,515.42 ns |  24,997.318 ns |  23,382.506 ns |
|     ListAddRange | 1000000 |  1,146,523.93 ns |  18,632.211 ns |  17,428.582 ns |
|    DictionaryAdd | 1000000 | 36,168,110.71 ns | 637,174.491 ns | 564,838.590 ns |
| DictionaryTryAdd | 1000000 | 36,037,202.55 ns |  86,442.858 ns |  76,629.342 ns |

# Copy Dictionary Values to a Stack
|                 Method |       N |            Mean |        Error |       StdDev |
|----------------------- |-------- |----------------:|-------------:|-------------:|
|                ForEach |      10 |        116.5 ns |      0.33 ns |      0.30 ns |
|             LinqSelect |      10 |        249.7 ns |      1.29 ns |      1.21 ns |
| LinqSelectIntermediate |      10 |        252.5 ns |      1.22 ns |      1.08 ns |
|                ForEach |     100 |        689.9 ns |      2.42 ns |      2.27 ns |
|             LinqSelect |     100 |      1,501.2 ns |      4.93 ns |      4.37 ns |
| LinqSelectIntermediate |     100 |      1,447.6 ns |      5.66 ns |      5.29 ns |
|                ForEach |    1000 |      5,234.4 ns |     61.17 ns |     57.22 ns |
|             LinqSelect |    1000 |     14,662.9 ns |    230.60 ns |    215.70 ns |
| LinqSelectIntermediate |    1000 |     13,203.0 ns |     59.09 ns |     49.34 ns |
|                ForEach |   10000 |     55,455.1 ns |    317.70 ns |    297.17 ns |
|             LinqSelect |   10000 |    148,531.2 ns |    710.57 ns |    554.77 ns |
| LinqSelectIntermediate |   10000 |    127,066.6 ns |    800.17 ns |    748.48 ns |
|                ForEach |  100000 |    565,574.7 ns |  2,624.18 ns |  2,326.27 ns |
|             LinqSelect |  100000 |  1,545,944.7 ns | 30,409.13 ns | 28,444.72 ns |
| LinqSelectIntermediate |  100000 |  1,429,165.3 ns | 27,404.38 ns | 28,142.28 ns |
|                ForEach | 1000000 |  8,116,902.7 ns | 26,836.76 ns | 25,103.13 ns |
|             LinqSelect | 1000000 | 15,934,311.4 ns | 59,427.68 ns | 55,588.69 ns |
| LinqSelectIntermediate | 1000000 | 17,450,616.1 ns | 59,623.95 ns | 52,855.08 ns |

* Using a Foreach loop is 2.14 times faster when N = 10 and 2 times as faster when N = 1M.
* Using an intermediate varible in a Linq Select loop has no performance impact when N = 10 and a 9% performance hit when N = 1M.

# Loop Over All Elements After using To Array

|                         Method |       N |             Mean |          Error |         StdDev |   Gen 0 |   Gen 1 |   Gen 2 |  Allocated |
|------------------------------- |-------- |-----------------:|---------------:|---------------:|--------:|--------:|--------:|-----------:|
|                    ListForeach |      10 |         59.51 ns |       1.242 ns |       1.479 ns |       - |       - |       - |          - |
|             ListToArrayForeach |      10 |         44.50 ns |       0.421 ns |       0.373 ns |  0.0099 |       - |       - |      104 B |
|              DictionaryForeach |      10 |         93.68 ns |       1.289 ns |       1.206 ns |       - |       - |       - |          - |
| DictionaryValuesToArrayForeach |      10 |        105.72 ns |       0.722 ns |       0.603 ns |  0.0099 |       - |       - |      104 B |
|       DictionaryToArrayForeach |      10 |        130.14 ns |       0.538 ns |       0.503 ns |  0.0174 |       - |       - |      184 B |
|                    ListForeach |     100 |        531.67 ns |       0.470 ns |       0.439 ns |       - |       - |       - |          - |
|             ListToArrayForeach |     100 |        197.21 ns |       2.681 ns |       2.508 ns |  0.0787 |       - |       - |      824 B |
|              DictionaryForeach |     100 |        712.14 ns |       2.195 ns |       1.946 ns |       - |       - |       - |          - |
| DictionaryValuesToArrayForeach |     100 |        631.58 ns |       3.862 ns |       3.225 ns |  0.0782 |       - |       - |      824 B |
|       DictionaryToArrayForeach |     100 |        842.79 ns |       5.757 ns |       5.104 ns |  0.1545 |       - |       - |     1624 B |
|                    ListForeach |    1000 |      5,499.52 ns |      27.582 ns |      24.451 ns |       - |       - |       - |          - |
|             ListToArrayForeach |    1000 |      2,384.59 ns |      14.385 ns |      12.752 ns |  0.7668 |       - |       - |     8024 B |
|              DictionaryForeach |    1000 |      6,728.26 ns |      63.305 ns |      59.215 ns |       - |       - |       - |          - |
| DictionaryValuesToArrayForeach |    1000 |      6,207.76 ns |      31.319 ns |      27.764 ns |  0.7629 |       - |       - |     8024 B |
|       DictionaryToArrayForeach |    1000 |      8,192.87 ns |      36.321 ns |      33.975 ns |  1.5259 |       - |       - |    16024 B |
|                    ListForeach |   10000 |     51,189.58 ns |     152.732 ns |     127.538 ns |       - |       - |       - |          - |
|             ListToArrayForeach |   10000 |     31,273.19 ns |     163.439 ns |     152.881 ns |  7.6294 |       - |       - |    80025 B |
|              DictionaryForeach |   10000 |     63,149.54 ns |      26.116 ns |      24.428 ns |       - |       - |       - |          - |
| DictionaryValuesToArrayForeach |   10000 |     68,081.66 ns |     173.836 ns |     162.606 ns |  7.5684 |       - |       - |    80025 B |
|       DictionaryToArrayForeach |   10000 |    163,897.22 ns |     891.283 ns |     833.707 ns | 49.8047 | 49.8047 | 49.8047 |   160025 B |
|                    ListForeach |  100000 |    515,107.94 ns |     671.571 ns |     628.188 ns |       - |       - |       - |          - |
|             ListToArrayForeach |  100000 |    643,289.06 ns |   3,328.741 ns |   3,113.706 ns | 25.3906 | 25.3906 | 25.3906 |   800026 B |
|              DictionaryForeach |  100000 |    634,093.07 ns |   1,589.341 ns |   1,408.910 ns |       - |       - |       - |        7 B |
| DictionaryValuesToArrayForeach |  100000 |    788,784.90 ns |  10,006.459 ns |   9,360.048 ns | 67.3828 | 67.3828 | 67.3828 |   800018 B |
|       DictionaryToArrayForeach |  100000 |  1,001,216.33 ns |  15,421.245 ns |  12,877.438 ns | 74.2188 | 74.2188 | 74.2188 |  1600019 B |
|                    ListForeach | 1000000 |  6,282,542.40 ns |  13,524.965 ns |  12,651.260 ns |       - |       - |       - |          - |
|             ListToArrayForeach | 1000000 |  8,787,632.14 ns |  62,242.102 ns |  55,176.002 ns | 31.2500 | 31.2500 | 31.2500 |  8000022 B |
|              DictionaryForeach | 1000000 |  7,037,605.08 ns |  26,557.130 ns |  24,841.556 ns |       - |       - |       - |          - |
| DictionaryValuesToArrayForeach | 1000000 | 13,795,614.29 ns | 116,910.615 ns | 103,638.215 ns | 62.5000 | 62.5000 | 62.5000 |  8000022 B |
|       DictionaryToArrayForeach | 1000000 | 16,650,591.04 ns |  50,160.654 ns |  46,920.307 ns | 62.5000 | 62.5000 | 62.5000 | 16000022 B |

* When N < 100,000 using the ToArray method on a List and then looping over its result is faster than simply looping over the List.

* Theory: The degrading performance of the List.ToArray version could be because it uses Array.CopyTo under the hood which will use twice as much memory as simply looping over the List. The larger object sizes could be forcing these data structures on to the Large Object Heap and inducing more intervention from the Garbage Collector. This could be confirmed by profiling the memory consumption and garbage collections of these benchmarks.

* It's always faster to just foreach over a Dictioinary than it is to extract its elements and then loop over them.

# Loop Over All Elements in an Array
|      Method |       N |             Mean |         Error |        StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |-------- |-----------------:|--------------:|--------------:|------:|------:|------:|----------:|
|         For |      10 |        10.048 ns |     0.0847 ns |     0.0792 ns |     - |     - |     - |         - |
|     ForEach |      10 |         8.486 ns |     0.1095 ns |     0.1024 ns |     - |     - |     - |         - |
|       While |      10 |        10.018 ns |     0.0899 ns |     0.0797 ns |     - |     - |     - |         - |
|          Do |      10 |         9.595 ns |     0.0313 ns |     0.0277 ns |     - |     - |     - |         - |
| LinqForEach |      10 |        37.362 ns |     0.0151 ns |     0.0118 ns |     - |     - |     - |         - |
|         For |     100 |        89.177 ns |     1.1639 ns |     1.0887 ns |     - |     - |     - |         - |
|     ForEach |     100 |        87.548 ns |     0.2614 ns |     0.2041 ns |     - |     - |     - |         - |
|       While |     100 |        88.167 ns |     0.6532 ns |     0.6110 ns |     - |     - |     - |         - |
|          Do |     100 |        87.132 ns |     1.0279 ns |     0.9615 ns |     - |     - |     - |         - |
| LinqForEach |     100 |       347.971 ns |     0.6591 ns |     0.5843 ns |     - |     - |     - |         - |
|         For |    1000 |       759.653 ns |     2.9132 ns |     2.5825 ns |     - |     - |     - |         - |
|     ForEach |    1000 |       800.765 ns |     0.4494 ns |     0.3752 ns |     - |     - |     - |         - |
|       While |    1000 |       758.085 ns |     3.4188 ns |     3.1980 ns |     - |     - |     - |         - |
|          Do |    1000 |       962.118 ns |     8.3833 ns |     7.8417 ns |     - |     - |     - |         - |
| LinqForEach |    1000 |     3,364.773 ns |     2.3295 ns |     1.9452 ns |     - |     - |     - |         - |
|         For |   10000 |     7,544.185 ns |    33.3107 ns |    29.5291 ns |     - |     - |     - |         - |
|     ForEach |   10000 |     7,933.025 ns |     1.5890 ns |     1.3269 ns |     - |     - |     - |         - |
|       While |   10000 |     7,526.817 ns |    21.5115 ns |    16.7947 ns |     - |     - |     - |         - |
|          Do |   10000 |     7,461.325 ns |    17.5976 ns |    14.6948 ns |     - |     - |     - |         - |
| LinqForEach |   10000 |    33,561.451 ns |    11.2222 ns |    10.4973 ns |     - |     - |     - |         - |
|         For |  100000 |    76,431.165 ns |   441.7812 ns |   413.2424 ns |     - |     - |     - |         - |
|     ForEach |  100000 |    81,046.427 ns | 1,329.7343 ns | 1,243.8343 ns |     - |     - |     - |         - |
|       While |  100000 |    75,291.145 ns |   328.7581 ns |   291.4355 ns |     - |     - |     - |         - |
|          Do |  100000 |    96,120.500 ns |    32.1282 ns |    28.4808 ns |     - |     - |     - |       1 B |
| LinqForEach |  100000 |   335,621.505 ns |   406.5473 ns |   360.3936 ns |     - |     - |     - |         - |
|         For | 1000000 |   759,195.632 ns | 6,045.3574 ns | 5,654.8310 ns |     - |     - |     - |       5 B |
|     ForEach | 1000000 |   803,440.612 ns | 4,980.1715 ns | 4,658.4555 ns |     - |     - |     - |       5 B |
|       While | 1000000 |   757,807.910 ns | 3,337.3719 ns | 2,958.4932 ns |     - |     - |     - |       9 B |
|          Do | 1000000 |   968,572.135 ns | 4,482.3855 ns | 4,192.8262 ns |     - |     - |     - |       5 B |
| LinqForEach | 1000000 | 2,934,314.676 ns |   490.7930 ns |   435.0752 ns |     - |     - |     - |      19 B |

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
