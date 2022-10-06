``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2006/21H1/May2021Update)
Intel Core i7-5600U CPU 2.60GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-rc.1.22431.12
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|      Method |       Mean |     Error |    StdDev | Allocated |
|------------ |-----------:|----------:|----------:|----------:|
|      NameOf |  0.1442 ns | 0.1130 ns | 0.1002 ns |         - |
|  TypeOfName |  8.8884 ns | 0.1424 ns | 0.1332 ns |         - |
| GetTypeName | 10.3133 ns | 0.3458 ns | 0.5965 ns |         - |
