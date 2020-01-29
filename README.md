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
