using System;
using BenchmarkDotNet.Attributes;

namespace NameOfPerformance
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private readonly TestClass _testClass = new();
        private readonly TestClass _testGuid = new();
        
        [Benchmark]
        public string NameOf() => nameof(TestClass);

        [Benchmark]
        public string TypeOfName() => typeof(TestClass).Name;
        
        [Benchmark]
        public string GetTypeName() => _testClass.GetType().Name;
    }
}