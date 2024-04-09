namespace Assignment_01;

public class NumSizesAndRanges
{
    public static void PrintSizesAndRanges()
    {
        Console.WriteLine($"sbyte:\nBytes: {sizeof(sbyte)}, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
        Console.WriteLine($"byte:\nBytes: {sizeof(byte)}, Min: {byte.MinValue}, Max: {byte.MaxValue}");
        Console.WriteLine($"short:\nBytes: {sizeof(short)}, Min: {short.MinValue}, Max: {short.MaxValue}");
        Console.WriteLine($"ushort:\nBytes: {sizeof(ushort)}, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
        Console.WriteLine($"int:\nBytes: {sizeof(int)}, Min: {int.MinValue}, Max: {int.MaxValue}");
        Console.WriteLine($"uint:\nBytes: {sizeof(uint)}, Min: {uint.MinValue}, Max: {uint.MaxValue}");
        Console.WriteLine($"long:\nBytes: {sizeof(long)}, Min: {long.MinValue}, Max: {long.MaxValue}");
        Console.WriteLine($"ulong:\nBytes: {sizeof(ulong)}, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
        Console.WriteLine($"float:\nBytes: {sizeof(float)}, Min: {float.MinValue}, Max: {float.MaxValue}");
        Console.WriteLine($"double:\nBytes: {sizeof(double)}, Min: {double.MinValue}, Max: {double.MaxValue}");
        Console.WriteLine($"decimal:\nBytes: {sizeof(decimal)}, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
    }
}