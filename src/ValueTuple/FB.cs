using System;
using System.Collections.Generic;

public struct MyStruct
{
    public int V1;
    public int V2;
    public int V3;
    public int V4;
    public int V5;
    public int V6;
    public int V7;
    public int V8;
    public int V9;
}
public class MyClass
{
    public int V1;
    public int V2;
    public int V3;
    public int V4;
    public int V5;
    public int V6;
    public int V7;
    public int V8;
    public int V9;
}

public class FB
{
    public static (int, int, int, int, int, int, int, int, int) QueryTuple()
    {
        return (9, 9, 9, 9, 9, 9, 9, 9, 9);
    }
    public static (int V1, int V2, int V3, int V4, int V5, int V6, int V7, int V8, int V9) QueryNameTuple()
    {
        return (9, 9, 9, 9, 9, 9, 9, 9, 9);
    }
    public static MyStruct QueryStruct()
    {
        return new MyStruct
        {
            V1 = 9,
            V2 = 9,
            V3 = 9,
            V4 = 9,
            V5 = 9,
            V6 = 9,
            V7 = 9,
            V8 = 9,
            V9 = 9
        };
    }
    public static MyClass QueryClass()
    {
        return new MyClass
        {
            V1 = 9,
            V2 = 9,
            V3 = 9,
            V4 = 9,
            V5 = 9,
            V6 = 9,
            V7 = 9,
            V8 = 9,
            V9 = 9
        };
    }
}