# CSharpBenchmarks
 Identify and compare the performance of loops and data structures in dotnet.

# Read All Elements
|     Method |       N |             Mean |          Error |         StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------- |-----------------:|---------------:|---------------:|-------:|------:|------:|----------:|
|      Array |      10 |         8.462 ns |      0.1004 ns |      0.0939 ns |      - |     - |     - |         - |
|       List |      10 |        37.746 ns |      0.5316 ns |      0.4972 ns |      - |     - |     - |         - |
| Dictionary |      10 |        45.030 ns |      0.5924 ns |      0.5541 ns |      - |     - |     - |         - |
| Enumerable |      10 |        92.544 ns |      1.8599 ns |      1.8266 ns | 0.0030 |     - |     - |      32 B |
|      Array |     100 |        88.140 ns |      0.2264 ns |      0.2118 ns |      - |     - |     - |         - |
|       List |     100 |       325.107 ns |      0.4612 ns |      0.4088 ns |      - |     - |     - |         - |
| Dictionary |     100 |       398.824 ns |      5.3828 ns |      4.7717 ns |      - |     - |     - |         - |
| Enumerable |     100 |       791.363 ns |      0.7508 ns |      0.6269 ns | 0.0029 |     - |     - |      32 B |
|      Array |    1000 |       799.742 ns |      1.1529 ns |      0.9627 ns |      - |     - |     - |         - |
|       List |    1000 |     3,129.860 ns |     30.2348 ns |     28.2816 ns |      - |     - |     - |         - |
| Dictionary |    1000 |     3,802.089 ns |      6.8087 ns |      5.6856 ns |      - |     - |     - |         - |
| Enumerable |    1000 |     7,557.364 ns |     14.4488 ns |     11.2807 ns |      - |     - |     - |      32 B |
|      Array |   10000 |     7,958.463 ns |     13.5116 ns |     11.9777 ns |      - |     - |     - |         - |
|       List |   10000 |    31,219.201 ns |    333.8981 ns |    295.9920 ns |      - |     - |     - |         - |
| Dictionary |   10000 |    37,876.099 ns |    114.4200 ns |    107.0285 ns |      - |     - |     - |         - |
| Enumerable |   10000 |    75,158.884 ns |     70.4157 ns |     62.4217 ns |      - |     - |     - |      32 B |
|      Array |  100000 |    80,106.295 ns |    418.6813 ns |    391.6347 ns |      - |     - |     - |         - |
|       List |  100000 |   310,237.252 ns |    315.2137 ns |    263.2177 ns |      - |     - |     - |       1 B |
| Dictionary |  100000 |   377,772.063 ns |    374.2141 ns |    331.7310 ns |      - |     - |     - |       1 B |
| Enumerable |  100000 |   750,889.481 ns |  1,095.9584 ns |    971.5385 ns |      - |     - |     - |      33 B |
|      Array | 1000000 |   808,059.982 ns |  4,516.5571 ns |  4,003.8103 ns |      - |     - |     - |       1 B |
|       List | 1000000 | 3,108,008.650 ns |  2,550.8694 ns |  2,261.2793 ns |      - |     - |     - |       5 B |
| Dictionary | 1000000 | 3,858,242.020 ns | 11,047.8311 ns |  9,793.6145 ns |      - |     - |     - |       5 B |
| Enumerable | 1000000 | 7,547,736.458 ns | 54,061.0389 ns | 50,568.7293 ns |      - |     - |     - |      42 B |

* Array's are the fastest data structure to read all elements from.
* Lists are 6.5 times slower when N = 10 and 4.15 times slower when N = 1M.
* Dictionary's are only ~20% slower than lists. A relatively minor performance hit.
* Using the IEnumerable interface on top of an Array is 14 times slower when N = 10 and 8.3 times slower when N = 1M.

# Read a Random Element
|     Method |       N |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|      Array |      10 | 18.16 ns | 0.010 ns | 0.008 ns |     - |     - |     - |         - |
|       List |      10 | 18.74 ns | 0.016 ns | 0.014 ns |     - |     - |     - |         - |
| Dictionary |      10 | 32.67 ns | 0.177 ns | 0.148 ns |     - |     - |     - |         - |
| Enumerable |      10 | 62.17 ns | 0.026 ns | 0.020 ns |     - |     - |     - |         - |
|      Array |     100 | 18.17 ns | 0.019 ns | 0.018 ns |     - |     - |     - |         - |
|       List |     100 | 18.86 ns | 0.214 ns | 0.200 ns |     - |     - |     - |         - |
| Dictionary |     100 | 31.64 ns | 0.546 ns | 0.510 ns |     - |     - |     - |         - |
| Enumerable |     100 | 61.26 ns | 0.315 ns | 0.279 ns |     - |     - |     - |         - |
|      Array |    1000 | 18.16 ns | 0.010 ns | 0.009 ns |     - |     - |     - |         - |
|       List |    1000 | 18.86 ns | 0.195 ns | 0.173 ns |     - |     - |     - |         - |
| Dictionary |    1000 | 31.34 ns | 0.018 ns | 0.017 ns |     - |     - |     - |         - |
| Enumerable |    1000 | 61.25 ns | 0.240 ns | 0.213 ns |     - |     - |     - |         - |
|      Array |   10000 | 18.53 ns | 0.010 ns | 0.008 ns |     - |     - |     - |         - |
|       List |   10000 | 19.18 ns | 0.426 ns | 0.418 ns |     - |     - |     - |         - |
| Dictionary |   10000 | 32.61 ns | 0.018 ns | 0.015 ns |     - |     - |     - |         - |
| Enumerable |   10000 | 61.20 ns | 0.225 ns | 0.188 ns |     - |     - |     - |         - |
|      Array |  100000 | 19.06 ns | 0.007 ns | 0.006 ns |     - |     - |     - |         - |
|       List |  100000 | 20.85 ns | 0.412 ns | 0.386 ns |     - |     - |     - |         - |
| Dictionary |  100000 | 42.78 ns | 0.169 ns | 0.150 ns |     - |     - |     - |         - |
| Enumerable |  100000 | 61.56 ns | 0.298 ns | 0.249 ns |     - |     - |     - |         - |
|      Array | 1000000 | 20.51 ns | 0.394 ns | 0.369 ns |     - |     - |     - |         - |
|       List | 1000000 | 20.01 ns | 0.285 ns | 0.267 ns |     - |     - |     - |         - |
| Dictionary | 1000000 | 86.46 ns | 1.564 ns | 1.463 ns |     - |     - |     - |         - |
| Enumerable | 1000000 | 66.15 ns | 1.372 ns | 1.409 ns |     - |     - |     - |         - |

# Read the First Element
|     Method |       N |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|      Array | 1000000 |  0.4420 ns | 0.0090 ns | 0.0080 ns |     - |     - |     - |         - |
|       List | 1000000 |  0.4546 ns | 0.0160 ns | 0.0142 ns |     - |     - |     - |         - |
| Enumerable | 1000000 | 42.8946 ns | 0.0515 ns | 0.0457 ns |     - |     - |     - |         - |

# Read the Last Element
|     Method |       N |       Mean |     Error |    StdDev |     Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------- |-----------:|----------:|----------:|-----------:|------:|------:|------:|----------:|
|      Array | 1000000 |  0.0031 ns | 0.0052 ns | 0.0049 ns |  0.0000 ns |     - |     - |     - |         - |
|       List | 1000000 |  0.5693 ns | 0.0017 ns | 0.0015 ns |  0.5689 ns |     - |     - |     - |         - |
| Enumerable | 1000000 | 43.1204 ns | 0.2835 ns | 0.2652 ns | 43.0264 ns |     - |     - |     - |         - |

# Read a Specific Element
|     Method |       N |             Mean |          Error |         StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------- |-----------------:|---------------:|---------------:|-------:|------:|------:|----------:|
|      Array |      10 |         6.654 ns |      0.0964 ns |      0.0902 ns |      - |     - |     - |         - |
|       List |      10 |        12.528 ns |      0.0302 ns |      0.0268 ns |      - |     - |     - |         - |
| Dictionary |      10 |        12.596 ns |      0.1338 ns |      0.1252 ns |      - |     - |     - |         - |
| Enumerable |      10 |       104.985 ns |      2.1010 ns |      3.0132 ns | 0.0106 |     - |     - |     112 B |
|      Array |     100 |        46.228 ns |      0.2222 ns |      0.2079 ns |      - |     - |     - |         - |
|       List |     100 |       109.426 ns |      0.6678 ns |      0.5920 ns |      - |     - |     - |         - |
| Dictionary |     100 |        12.295 ns |      0.0223 ns |      0.0174 ns |      - |     - |     - |         - |
| Enumerable |     100 |       250.941 ns |      4.3398 ns |      4.0594 ns | 0.0105 |     - |     - |     112 B |
|      Array |    1000 |       439.344 ns |      4.9141 ns |      4.5967 ns |      - |     - |     - |         - |
|       List |    1000 |       942.661 ns |      0.5443 ns |      0.5091 ns |      - |     - |     - |         - |
| Dictionary |    1000 |        12.528 ns |      0.1591 ns |      0.1410 ns |      - |     - |     - |         - |
| Enumerable |    1000 |     1,572.533 ns |      3.3320 ns |      3.1168 ns | 0.0095 |     - |     - |     112 B |
|      Array |   10000 |     4,207.046 ns |      2.7252 ns |      2.2756 ns |      - |     - |     - |         - |
|       List |   10000 |     9,289.749 ns |      8.6985 ns |      7.2637 ns |      - |     - |     - |         - |
| Dictionary |   10000 |        12.837 ns |      0.1375 ns |      0.1286 ns |      - |     - |     - |         - |
| Enumerable |   10000 |    15,118.351 ns |    283.6053 ns |    278.5383 ns |      - |     - |     - |     112 B |
|      Array |  100000 |    42,533.988 ns |    653.0281 ns |    610.8429 ns |      - |     - |     - |         - |
|       List |  100000 |    93,499.006 ns |     68.5882 ns |     57.2743 ns |      - |     - |     - |         - |
| Dictionary |  100000 |        12.466 ns |      0.2935 ns |      0.2746 ns |      - |     - |     - |         - |
| Enumerable |  100000 |   149,119.863 ns |  2,081.4885 ns |  1,947.0257 ns |      - |     - |     - |     114 B |
|      Array | 1000000 |   426,127.438 ns |    993.7234 ns |    880.9099 ns |      - |     - |     - |       5 B |
|       List | 1000000 |   949,036.021 ns | 12,406.9680 ns | 10,998.4540 ns |      - |     - |     - |       1 B |
| Dictionary | 1000000 |        12.805 ns |      0.7688 ns |      0.7551 ns |      - |     - |     - |         - |
| Enumerable | 1000000 | 1,471,627.427 ns |  2,970.2328 ns |  2,633.0340 ns |      - |     - |     - |     115 B |

# Write All Elements from an Array
|           Method |       N |             Mean |         Error |        StdDev |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
|----------------- |-------- |-----------------:|--------------:|--------------:|----------:|----------:|----------:|-----------:|
|            Array |      10 |         20.19 ns |      0.173 ns |      0.162 ns |    0.0061 |         - |         - |       64 B |
|          ListAdd |      10 |        125.15 ns |      0.325 ns |      0.288 ns |    0.0205 |         - |         - |      216 B |
|     ListAddRange |      10 |         72.11 ns |      0.125 ns |      0.104 ns |    0.0092 |         - |         - |       96 B |
|    DictionaryAdd |      10 |        406.24 ns |      0.887 ns |      0.787 ns |    0.0734 |         - |         - |      768 B |
| DictionaryTryAdd |      10 |        404.84 ns |      2.164 ns |      2.024 ns |    0.0734 |         - |         - |      768 B |
|            Array |     100 |        130.42 ns |      2.101 ns |      1.863 ns |    0.0405 |         - |         - |      424 B |
|          ListAdd |     100 |        576.42 ns |      2.392 ns |      2.237 ns |    0.1125 |         - |         - |     1184 B |
|     ListAddRange |     100 |        123.20 ns |      0.720 ns |      0.673 ns |    0.0434 |         - |         - |      456 B |
|    DictionaryAdd |     100 |      3,590.04 ns |     22.021 ns |     20.599 ns |    0.7057 |    0.0114 |         - |     7384 B |
| DictionaryTryAdd |     100 |      3,614.08 ns |      4.907 ns |      4.350 ns |    0.7057 |    0.0114 |         - |     7384 B |
|            Array |    1000 |      1,150.38 ns |     11.193 ns |     10.470 ns |    0.3834 |         - |         - |     4024 B |
|          ListAdd |    1000 |      3,858.67 ns |     12.355 ns |     11.557 ns |    0.8011 |    0.0153 |         - |     8424 B |
|     ListAddRange |    1000 |        537.78 ns |     12.548 ns |     11.737 ns |    0.3872 |    0.0057 |         - |     4056 B |
|    DictionaryAdd |    1000 |     33,913.77 ns |     76.949 ns |     71.978 ns |    6.9580 |    1.0376 |         - |    73160 B |
| DictionaryTryAdd |    1000 |     35,224.03 ns |     58.757 ns |     54.962 ns |    6.9580 |    1.0986 |         - |    73160 B |
|            Array |   10000 |     10,776.14 ns |     48.028 ns |     44.926 ns |    3.8147 |         - |         - |    40024 B |
|          ListAdd |   10000 |     43,018.69 ns |    442.264 ns |    392.055 ns |   12.4512 |    2.4414 |         - |   131400 B |
|     ListAddRange |   10000 |      5,747.48 ns |     38.101 ns |     35.640 ns |    3.8147 |    0.4730 |         - |    40056 B |
|    DictionaryAdd |   10000 |    463,246.09 ns |    582.210 ns |    486.172 ns |  124.5117 |  124.5117 |  124.5117 |   673057 B |
| DictionaryTryAdd |   10000 |    481,237.39 ns |  6,601.390 ns |  6,174.945 ns |  124.5117 |  124.5117 |  124.5117 |   673061 B |
|            Array |  100000 |    256,847.50 ns |    409.768 ns |    319.920 ns |  124.5117 |  124.5117 |  124.5117 |   400025 B |
|          ListAdd |  100000 |    660,658.81 ns |  4,265.502 ns |  3,989.953 ns |  285.1563 |  285.1563 |  285.1563 |  1048981 B |
|     ListAddRange |  100000 |    241,667.06 ns |    389.111 ns |    363.974 ns |  124.7559 |  124.7559 |  124.7559 |   400056 B |
|    DictionaryAdd |  100000 |  3,554,851.17 ns |  8,874.704 ns |  8,301.404 ns | 1023.4375 | 1000.0000 | 1000.0000 |  6037627 B |
| DictionaryTryAdd |  100000 |  3,711,831.22 ns |  5,310.246 ns |  4,434.296 ns | 1023.4375 | 1000.0000 | 1000.0000 |  6037630 B |
|            Array | 1000000 |  1,533,038.94 ns | 30,614.551 ns | 52,808.596 ns |  218.7500 |  218.7500 |  218.7500 |  4000019 B |
|          ListAdd | 1000000 |  7,411,313.04 ns | 30,983.108 ns | 25,872.298 ns |  500.0000 |  492.1875 |  492.1875 |  8389078 B |
|     ListAddRange | 1000000 |  1,103,381.51 ns | 17,380.970 ns | 14,513.897 ns |  220.7031 |  220.7031 |  220.7031 |  4000060 B |
|    DictionaryAdd | 1000000 | 34,201,491.11 ns | 50,923.897 ns | 47,634.244 ns | 1000.0000 | 1000.0000 | 1000.0000 | 53888539 B |
| DictionaryTryAdd | 1000000 | 35,962,784.18 ns | 52,817.353 ns | 46,821.208 ns | 1071.4286 | 1071.4286 | 1071.4286 | 53888537 B |

# Copy Dictionary Values to a Stack
|                 Method |       N |            Mean |         Error |        StdDev |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|----------------------- |-------- |----------------:|--------------:|--------------:|---------:|---------:|---------:|-----------:|
|                ForEach |      10 |        225.6 ns |       4.35 ns |       4.28 ns |   0.0205 |        - |        - |      216 B |
|             LinqSelect |      10 |        460.3 ns |       6.10 ns |       5.40 ns |   0.0296 |        - |        - |      312 B |
| LinqSelectIntermediate |      10 |        489.9 ns |       8.02 ns |       7.11 ns |   0.0401 |        - |        - |      424 B |
|                ForEach |     100 |      1,264.8 ns |      24.48 ns |      32.68 ns |   0.1125 |        - |        - |     1184 B |
|             LinqSelect |     100 |      2,818.9 ns |      10.88 ns |       9.09 ns |   0.1221 |        - |        - |     1280 B |
| LinqSelectIntermediate |     100 |      2,792.3 ns |      44.31 ns |      41.45 ns |   0.1984 |        - |        - |     2112 B |
|                ForEach |    1000 |      9,700.1 ns |     148.59 ns |     124.08 ns |   0.7935 |   0.0153 |        - |     8424 B |
|             LinqSelect |    1000 |     27,447.0 ns |     148.41 ns |     123.93 ns |   0.7935 |        - |        - |     8520 B |
| LinqSelectIntermediate |    1000 |     24,636.1 ns |     385.38 ns |     321.81 ns |   1.5564 |   0.0610 |        - |    16552 B |
|                ForEach |   10000 |    108,557.5 ns |   2,143.56 ns |   3,273.44 ns |  12.4512 |   2.4414 |        - |   131400 B |
|             LinqSelect |   10000 |    277,094.5 ns |   4,523.74 ns |   4,231.51 ns |  12.2070 |   1.9531 |        - |   131496 B |
| LinqSelectIntermediate |   10000 |    244,094.5 ns |   3,105.54 ns |   2,904.92 ns |  20.0195 |   6.3477 |        - |   211528 B |
|                ForEach |  100000 |  1,071,301.5 ns |  14,155.48 ns |  13,241.04 ns | 158.2031 | 146.4844 | 146.4844 |  1049727 B |
|             LinqSelect |  100000 |  2,749,630.3 ns |  19,226.19 ns |  16,054.74 ns | 183.5938 | 171.8750 | 171.8750 |  1049087 B |
| LinqSelectIntermediate |  100000 |  2,451,562.1 ns |  12,058.18 ns |  10,689.26 ns | 250.0000 | 238.2813 | 238.2813 |  1849206 B |
|                ForEach | 1000000 | 13,343,144.1 ns |  80,963.98 ns |  71,772.46 ns |  62.5000 |  62.5000 |  62.5000 |  8389326 B |
|             LinqSelect | 1000000 | 29,841,091.7 ns | 551,582.72 ns | 515,950.82 ns |  62.5000 |  62.5000 |  62.5000 |  8389184 B |
| LinqSelectIntermediate | 1000000 | 29,366,898.8 ns | 466,779.27 ns | 436,625.62 ns | 125.0000 | 125.0000 | 125.0000 | 16389701 B |

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
