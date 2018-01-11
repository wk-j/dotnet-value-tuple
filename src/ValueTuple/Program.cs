using System;
using BenchmarkDotNet.Running;

namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BM>();
        }
    }
}
