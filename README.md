## Test Value Tuple

- https://www.facebook.com/photo.php?fbid=1962903433723376

```bash
cake build.cake -target=Run
```

```
    Method |      Mean |    Error |   StdDev |    Gen 0 | Allocated |
---------- |----------:|---------:|---------:|---------:|----------:|
     Tuple | 208.79 us | 5.400 us | 6.631 us |  76.1719 |  240000 B |
 NameTuple | 208.16 us | 3.397 us | 3.011 us |  76.1719 |  240000 B |
    Struct | 140.56 us | 2.727 us | 3.823 us |        - |       0 B |
     Class |  74.82 us | 2.037 us | 5.811 us | 177.9785 |  560000 B |
```