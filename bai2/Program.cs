using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "bai 2";
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"Tong: {a} + {b} = {sum}");
            int max = Math.Max(a, b);
            Console.WriteLine($"max:{a},{b} = {max}");
            double abs = Math.Abs(a + b);
            Console.WriteLine($"gia tri tuyet doi:{a},{b} = {abs}");
            double cos = Math.Cos(a + b);
            Console.WriteLine($"cos cua: {a},{b} = {cos}");
            Console.ReadKey();
            //ctrl KC : coment
            //ctrl KU : bo coment
        }
    }
}
