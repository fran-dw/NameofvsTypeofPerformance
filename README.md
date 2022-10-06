# nameof() vs typeof() Performance Benchmarks In NET 6.0

Obtaining the name of a program entity can be achied in several ways.
Some of which are `nameof(...)`, `typeof(...).Name` or `Object.GetType().Name`

# Sample Result
Sample result from one of the runs.

|      Method |       Mean |     Error |    StdDev | Allocated |
|------------ |-----------:|----------:|----------:|----------:|
|      NameOf |  0.1442 ns | 0.1130 ns | 0.1002 ns |         - |
|  TypeOfName |  8.8884 ns | 0.1424 ns | 0.1332 ns |         - |
| GetTypeName | 10.3133 ns | 0.3458 ns | 0.5965 ns |         - |


# Resources
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#typeof-operator

https://learn.microsoft.com/en-us/visualstudio/ide/reference/convert-typeof-to-nameof?view=vs-2022

https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-6.0
