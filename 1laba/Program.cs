using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Введите основание a: ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("Введите показатель степени n: ");
         int n = int.Parse(Console.ReadLine());

         int result = Power(a, n);
         Console.WriteLine($"{a} в степени {n} = {result}");
        }

        static int Power(int a, int n)
        {
         if (n == 0)
         return 1;

         int result = Power(a, n / 2);
         if (n % 2 == 0)
         return result * result;
         else
         return a * result * result;
        }
    }
}
