using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double tong = a + b + c;
        Console.WriteLine($"Tổng của 3 số {a} + {b} + {c} = {tong}");
    }
}