using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine($"sbyte: {sbyte.MaxValue}, {sbyte.MinValue}");
        Console.WriteLine($"byte: {byte.MaxValue}, {byte.MinValue}");
        Console.WriteLine($"short: {short.MaxValue}, {short.MinValue}");
        Console.WriteLine($"ushort: {ushort.MaxValue}, {ushort.MinValue}");
        Console.WriteLine($"int: {int.MaxValue}, {int.MinValue}");
        Console.WriteLine($"uint: {uint.MaxValue}, {uint.MinValue}");
        Console.WriteLine($"long: {long.MaxValue}, {long.MinValue}");
        Console.WriteLine($"ulong: {ulong.MaxValue}, {ulong.MinValue}");
        Console.WriteLine($"float: {float.MaxValue}, {float.MinValue}");
        Console.WriteLine($"double: {double.MaxValue}, {double.MinValue}");
        Console.WriteLine($"decimal: {decimal.MaxValue}, {decimal.MinValue}");
        Console.WriteLine($"-∞: {float.NegativeInfinity}");
        Console.WriteLine($"+∞: {float.PositiveInfinity}");
        Console.WriteLine($"NaN: {float.NaN}");
        Console.WriteLine($"-∞: {double.NegativeInfinity}");
        Console.WriteLine($"+∞: {double.PositiveInfinity}");
        Console.WriteLine($"NaN: {double.NaN}");
        }
    }
}
