using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant1
{
    public class SumOfTwoNumbers
    {
        public static int f(int x)
        {
            return x / 10 + x % 10;
        }

        public static void Write(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма цифр двузначного числа: {f(x)}");
        }
    }



    public class PrimeChecker
    {
        public static string IsPrime(int num)
        {
            if (num % 2 == 0)
            {
                return "Составное число";
            }
            int sqrtnum = (int)Math.Sqrt(num);
            for (int i = 3; i <= sqrtnum; i += 2)
            {
                if (num % i == 0)
                {
                    return "Составное число";
                }
            }
            return "Простое число";
        }
        public static void Write(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

    }



    public class InternetCost
    {
        public static int CalculateInternetCost(int a, int b, int c, int d)
        {
            int cost = a;
            if (d > b)
            {
                cost += (d - b) * c;
            }
            return cost;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость абонентской платы: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во мегабайт трафика: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость сверхлимитного трафика: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во потраченых мегабайт трафика: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateInternetCost(a, b, c, d));
        }
    }
}
