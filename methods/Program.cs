using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите три числа:");
        //    double num1 = Convert.ToDouble(Console.ReadLine());
        //    double num2 = Convert.ToDouble(Console.ReadLine());
        //    double num3 = Convert.ToDouble(Console.ReadLine());
        //    double min = FindMin(num1, num2, num3);
        //    double max = FindMax(num1, num2, num3);
        //    double sum = min + max;
        //    Console.WriteLine($"Сумма меньшего и большего числа: {sum}");
        //}
        //static double FindMin(double a, double b, double c)
        //{
        //    double min = a; 
        //    if (b < min)
        //        min = b; 
        //    if (c < min)
        //        min = c; 
        //    return min;
        //}
        //static double FindMax(double a, double b, double c)
        //{
        //    double max = a; 
        //    if (b > max)
        //        max = b; 
        //    if (c > max)
        //        max = c; 
        //    return max;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите число n (n >= 2):");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    if (n < 2)
        //    {
        //        Console.WriteLine("Число должно быть больше или равно 2.");
        //        return;
        //    }
        //    int numberWithMaxDivisorSum = FindNumberWithMaxDivisorSum(n);
        //    Console.WriteLine($"Число с максимальной суммой делителей на отрезке [2, {n}]: {numberWithMaxDivisorSum}");
        //}
        //static int FindNumberWithMaxDivisorSum(int n)
        //{
        //    int maxNumber = 2; 
        //    int maxSumOfDivisors = SumOfDivisors(maxNumber); 
        //    for (int i = 3; i <= n; i++)
        //    {
        //        int currentSumOfDivisors = SumOfDivisors(i);
        //        if (currentSumOfDivisors > maxSumOfDivisors)
        //        {
        //            maxSumOfDivisors = currentSumOfDivisors;
        //            maxNumber = i; 
        //        }
        //    }
        //    return maxNumber;
        //}
        //static int SumOfDivisors(int number)
        //{
        //    int sum = 0;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        if (number % i == 0) 
        //        {
        //            sum += i; 
        //        }
        //    }
        //    return sum;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите три числа:");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    int c = Convert.ToInt32(Console.ReadLine());
        //    bool result = AreCoprime(a, b, c);
        //    Console.WriteLine($"Числа {a}, {b} и {c} взаимно простые: {result}");
        //}
        //static int ReadInteger(string prompt)
        //{
        //    int number;
        //    while (true)
        //    {
        //        Console.Write(prompt);
        //        if (int.TryParse(Console.ReadLine(), out number))
        //        {
        //            return number;
        //        }
        //        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        //    }
        //}
        //static bool AreCoprime(int a, int b, int c)
        //{
        //    return GCD(a, b) == 1 && GCD(a, c) == 1 && GCD(b, c) == 1;
        //}
        //static int GCD(int x, int y)
        //{
        //    while (y != 0)
        //    {
        //        int temp = y;
        //        y = x % y;
        //        x = temp;
        //    }
        //    return x;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите три числа:");
        //    double num1 = Convert.ToDouble(Console.ReadLine());
        //    double num2 = Convert.ToDouble(Console.ReadLine());
        //    double num3 = Convert.ToDouble(Console.ReadLine());
        //    double[] averages = CalculateAverages(num1, num2, num3);

        //    Console.WriteLine($"Среднее арифметическое пар чисел:");
        //    Console.WriteLine($"({num1}, {num2}): {averages[0]}");
        //    Console.WriteLine($"({num1}, {num3}): {averages[1]}");
        //    Console.WriteLine($"({num2}, {num3}): {averages[2]}");

        //    Console.WriteLine($"Среднее геометрическое модулей:");
        //    Console.WriteLine($"|{num1}| и |{num2}|: {averages[3]}");
        //    Console.WriteLine($"|{num1}| и |{num3}|: {averages[4]}");
        //    Console.WriteLine($"|{num2}| и |{num3}|: {averages[5]}");
        //}
        //static double ReadDouble(string prompt)
        //{
        //    double number;
        //    while (true)
        //    {
        //        Console.Write(prompt);
        //        if (double.TryParse(Console.ReadLine(), out number))
        //        {
        //            return number;
        //        }
        //        Console.WriteLine("Некорректный ввод. Пожалуйста, введите действительное число.");
        //    }
        //}
        //static double[] CalculateAverages(double a, double b, double c)
        //{
        //    double[] averages = new double[6];
        //    averages[0] = ArithmeticMean(a, b);
        //    averages[1] = ArithmeticMean(a, c);
        //    averages[2] = ArithmeticMean(b, c);

        //    averages[3] = GeometricMean(Math.Abs(a), Math.Abs(b));
        //    averages[4] = GeometricMean(Math.Abs(a), Math.Abs(c));
        //    averages[5] = GeometricMean(Math.Abs(b), Math.Abs(c));
        //    return averages;
        //}
        //static double ArithmeticMean(double x, double y)
        //{
        //    return (x + y) / 2;
        //}
        //static double GeometricMean(double x, double y)
        //{
        //    return Math.Sqrt(x * y);
        //}

        //static void Main()
        //{
        //    Console.WriteLine("Введите размерность матрицы A:");
        //    int sizeA = ReadMatrixSize();
        //    double[,] matrixA = ReadMatrix(sizeA, "A");

        //    Console.WriteLine("Введите размерность матрицы B:");
        //    int sizeB = ReadMatrixSize();
        //    double[,] matrixB = ReadMatrix(sizeB, "B");

        //    double traceA = CalculateTrace(matrixA);
        //    double traceB = CalculateTrace(matrixB);

        //    Console.WriteLine($"След матрицы A (c): {traceA}");
        //    Console.WriteLine($"След матрицы B (d): {traceB}");
        //    Console.WriteLine("nТаблица значений функции y = cx^2 + d:");
        //    Console.WriteLine(" xtt y");
        //    for (double x = 0; x <= 1; x += 0.1)
        //    {
        //        double y = traceA * x * x + traceB;
        //        Console.WriteLine($"{x:F1}t {y:F4}");
        //    }
        //}
        //static int ReadMatrixSize()
        //{
        //    int size;
        //    while (true)
        //    {
        //        Console.Write("Введите размерность (положительное целое число): ");
        //        if (int.TryParse(Console.ReadLine(), out size) && size > 0)
        //        {
        //            return size;
        //        }
        //        Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
        //    }
        //}
        //static double[,] ReadMatrix(int size, string matrixName)
        //{
        //    double[,] matrix = new double[size, size];
        //    Console.WriteLine($"Введите элементы матрицы {matrixName}:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int j = 0; j < size; j++)
        //        {
        //            while (true)
        //            {
        //                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
        //                if (double.TryParse(Console.ReadLine(), out matrix[i, j]))
        //                {
        //                    break;
        //                }
        //                Console.WriteLine("Некорректный ввод. Пожалуйста, введите действительное число.");
        //            }
        //        }
        //    }
        //    return matrix;
        //}
        //static double CalculateTrace(double[,] matrix)
        //{
        //    double trace = 0;
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        trace += matrix[i, i];
        //    }
        //    return trace;
        //}
    }
}

