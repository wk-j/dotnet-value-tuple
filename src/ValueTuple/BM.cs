using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class BM
{
    int loopTest = 10000;

    [Benchmark]
    public void Tuple()
    {
        for (int i = 0; i < loopTest; i++)
        {
            var tmp = FB.QueryTuple();
            var v1 = tmp.Item1;
            var v2 = tmp.Item2;
            var v3 = tmp.Item3;
            var v4 = tmp.Item4;
            var v5 = tmp.Item5;
            var v6 = tmp.Item6;
            var v7 = tmp.Item7;
            var v8 = tmp.Item8;
            var v9 = tmp.Item9;
        }
    }
    [Benchmark]
    public void NameTuple()
    {
        for (int i = 0; i < loopTest; i++)
        {
            var tmp = FB.QueryNameTuple();
            var v1 = tmp.V1;
            var v2 = tmp.V2;
            var v3 = tmp.V3;
            var v4 = tmp.V4;
            var v5 = tmp.V5;
            var v6 = tmp.V6;
            var v7 = tmp.V7;
            var v8 = tmp.V8;
            var v9 = tmp.V9;
        }
    }

    [Benchmark]
    public void Struct()
    {
        for (int i = 0; i < loopTest; i++)
        {
            var tmp = FB.QueryStruct();
            var v1 = tmp.V1;
            var v2 = tmp.V2;
            var v3 = tmp.V3;
            var v4 = tmp.V4;
            var v5 = tmp.V5;
            var v6 = tmp.V6;
            var v7 = tmp.V7;
            var v8 = tmp.V8;
            var v9 = tmp.V9;
        }

    }
    [Benchmark]
    public void Class()
    {
        for (int i = 0; i < loopTest; i++)
        {
            var tmp = FB.QueryClass();
            var v1 = tmp.V1;
            var v2 = tmp.V2;
            var v3 = tmp.V3;
            var v4 = tmp.V4;
            var v5 = tmp.V5;
            var v6 = tmp.V6;
            var v7 = tmp.V7;
            var v8 = tmp.V8;
            var v9 = tmp.V9;
        }
    }
}