using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_M5_сокр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 3, 5, 1, 9, 2, 8 };
            //int max = arr[0], min = arr[0];
            //int maxIndex = 0, minIndex = 0;
            //int maxCount = 0, minCount = 0;
            //foreach (var num in arr)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //        maxIndex = Array.IndexOf(arr, num);
            //        maxCount++;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //        minIndex = Array.IndexOf(arr, num);
            //        minCount++;
            //    }
            //}
            //Console.WriteLine($"Максимальный элемент: {max}");
            //Console.WriteLine($"Минимальный элемент: {min}");
            //Console.WriteLine($"Разница: {max - min}");
            //Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
            //Console.WriteLine($"Индекс минимального элемента: {minIndex}");

            //decimal[] prices = { 20000, 30000, 15000, 35000, 25000 };
            //decimal maxPrice = prices[0];
            //foreach (var price in prices)
            //{
            //    if (price > maxPrice)
            //    {
            //        maxPrice = price;
            //    }
            //}
            //Console.WriteLine($"Самый дорогой автомобиль стоит: {maxPrice}");

            //decimal[] candyPrices = { 2.5m, 1.5m, 3.0m, 1.0m, 2.0m };
            //decimal minPrice = candyPrices[0];
            //foreach (var price in candyPrices)
            //{
            //    if (price < minPrice)
            //    {
            //        minPrice = price;
            //    }
            //}
            //Console.WriteLine($"Самые дешевые конфеты стоят: {minPrice}");

            //int[] heights = { 170, 160, 180, 155, 175 };
            //int maxHeight = heights[0];
            //int minHeight = heights[0];
            //foreach (var height in heights)
            //{
            //    if (height > maxHeight)
            //        maxHeight = height;
            //    if (height < minHeight)
            //        minHeight = height;
            //}
            //Console.WriteLine($"Разница между самым высоким и самым низким ростом: {maxHeight - minHeight}");

            //int[] scores = { 5, 8, 7, 9, 6, 10, 5, 8 };
            //int maxScore = scores[0];
            //int minScore = scores[0];
            //foreach (var score in scores)
            //{
            //    if (score > maxScore) maxScore = score;
            //    if (score < minScore) minScore = score;
            //}
            //int sum = 0;
            //int count = 0;
            //foreach (var score in scores)
            //{
            //    if (score != maxScore && score != minScore)
            //    {
            //        sum += score;
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Средняя оценка: {(double)sum / count}");

            //int[] speeds = { 120, 150, 130, 180, 160 };
            //int maxSpeed = speeds[0];
            //int firstIndex = -1, lastIndex = -1;
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    if (speeds[i] > maxSpeed)
            //    {
            //        maxSpeed = speeds[i];
            //        firstIndex = lastIndex = i;
            //    }
            //    else if (speeds[i] == maxSpeed)
            //    {
            //        lastIndex = i;
            //    }
            //}
            //Console.WriteLine($"Первый самый быстрый автомобиль: {firstIndex + 1}");
            //Console.WriteLine($"Последний самый быстрый автомобиль: {lastIndex + 1}");

            //int[] arr = { 3, 5, 1, 9, 2, 9, 1 };
            //int max = arr[0], min = arr[0];
            //int maxCount = 0, minCount = 0;
            //foreach (var num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}
            //foreach (var num in arr)
            //{
            //    if (num == max) maxCount++;
            //    if (num == min) minCount++;
            //}
            //Console.WriteLine($"Количество максимальных элементов: {maxCount}");
            //Console.WriteLine($"Количество минимальных элементов: {minCount}");

            //int[] arr = { 3, 5, 1, 9, 2, 9, 1 };
            //int max = arr[0], min = arr[0];
            //List<int> minIndices = new List<int>();
            //List<int> maxIndices = new List<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxIndices.Clear();
            //        maxIndices.Add(i);
            //    }
            //    else if (arr[i] == max)
            //    {
            //        maxIndices.Add(i);
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        minIndices.Clear();
            //        minIndices.Add(i);
            //    }
            //    else if (arr[i] == min)
            //    {
            //        minIndices.Add(i);
            //    }
            //}
            //Console.WriteLine($"Индексы минимальных элементов: {string.Join(", ", minIndices)}");
            //Console.WriteLine($"Индексы максимальных элементов: {string.Join(", ", maxIndices)}");

            //double[] arr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            //double max = arr[0], min = arr[0];
            //foreach (var num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}
            //Console.WriteLine($"Максимальный элемент превышает минимальный не более чем на 25: {max - min <= 25}");
            //Console.WriteLine($"Минимальный элемент меньше максимального более чем в 2 раза: {min * 2 < max}");

            //int[] arr = { 3, 5, 1, 9, 2, 9 };
            //int maxIndex = -1, minIndex = -1;
            //int max = arr[0], min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxIndex = i;
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        minIndex = i;
            //    }
            //}
            //Console.WriteLine($"Число, которое встретится раньше: {(maxIndex < minIndex ? "максимальное" : "минимальное")}");

            //int[] windDirections = { 1, 2, 3, 4, 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] frequency = new int[8];
            //foreach (var direction in windDirections)
            //{
            //    frequency[direction - 1]++;
            //}
            //int minIndex = 0;
            //for (int i = 1; i < frequency.Length; i++)
            //{
            //    if (frequency[i] < frequency[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //}
            //Console.WriteLine($"Жилой комплекс должен быть расположен в сторону: {minIndex + 1}");

            //int[] arr = { 3, 5, 1, 9, 2, 9 };
            //int max = arr[0], min = arr[0];
            //int maxIndex = 0, minIndex = 0;
            //int secondMax = int.MinValue, secondMin = int.MaxValue;
            //int secondMaxIndex = -1, secondMinIndex = -1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        secondMaxIndex = maxIndex;
            //        max = arr[i];
            //        maxIndex = i;
            //    }
            //    else if (arr[i] > secondMax && arr[i] < max)
            //    {
            //        secondMax = arr[i];
            //        secondMaxIndex = i;
            //    }
            //    if (arr[i] < min)
            //    {
            //        secondMin = min;
            //        secondMinIndex = minIndex;
            //        min = arr[i];
            //        minIndex = i;
            //    }
            //    else if (arr[i] < secondMin && arr[i] > min)
            //    {
            //        secondMin = arr[i];
            //        secondMinIndex = i;
            //    }
            //}
            //Console.WriteLine($"Максимальный элемент: {max} (индекс: {maxIndex})");
            //Console.WriteLine($"Максимальный без учета: {secondMax} (индекс: {secondMaxIndex})");
            //Console.WriteLine($"Минимальный элемент: {min} (индекс: {minIndex})");
            //Console.WriteLine($"Минимальный без учета: {secondMin} (индекс: {secondMinIndex})");

            //Random random = new Random();
            //int[] speeds = new int[40];
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    speeds[i] = random.Next(100, 301); 
            //}
            //int max1 = int.MinValue;
            //int max2 = int.MinValue;
            //foreach (var speed in speeds)
            //{
            //    if (speed > max1)
            //    {
            //        max2 = max1; 
            //        max1 = speed; 
            //    }
            //    else if (speed > max2 && speed < max1)
            //    {
            //        max2 = speed; 
            //    }
            //}
            //Console.WriteLine($"Скорости двух самых быстрых автомобилей: {max1} и {max2}");

            //Random random = new Random();
            //int[] residents = new int[15];
            //for (int i = 0; i < residents.Length; i++)
            //{
            //    residents[i] = random.Next(0, 101); 
            //}

            //int min1 = int.MaxValue; 
            //int min2 = int.MaxValue; 
            //int min1Index = -1; 
            //int min2Index = -1; 
            //for (int i = 0; i < residents.Length; i++)
            //{
            //    if (residents[i] < min1)
            //    {
            //        min2 = min1;
            //        min2Index = min1Index;
            //        min1 = residents[i];
            //        min1Index = i;
            //    }
            //    else if (residents[i] < min2 && residents[i] != min1)
            //    {
            //        min2 = residents[i];
            //        min2Index = i;
            //    }
            //}
            //Console.WriteLine("Количество людей на этажах:");
            //for (int i = 0; i < residents.Length; i++)
            //{
            //    Console.WriteLine($"Этаж {i + 1}: {residents[i]} человек");
            //}
            //Console.WriteLine($"Два этажа с наименьшим числом жителей: Этаж {min1Index + 1} ({min1} человек) и Этаж {min2Index + 1} ({min2} человек)");

            //Random random = new Random();
            //int[] results = new int[23];
            //for (int i = 0; i < results.Length; i++)
            //{
            //    results[i] = random.Next(1000, 2001); 
            //}
            //int minSum = int.MaxValue;
            //int[] bestTeam = new int[4];
            //for (int i = 0; i < results.Length - 3; i++)
            //{
            //    for (int j = i + 1; j < results.Length - 2; j++)
            //    {
            //        for (int k = j + 1; k < results.Length - 1; k++)
            //        {
            //            for (int m = k + 1; m < results.Length; m++)
            //            {
            //                int currentSum = results[i] + results[j] + results[k] + results[m];
            //                if (currentSum < minSum)
            //                {
            //                    minSum = currentSum;
            //                    bestTeam[0] = i + 1; 
            //                    bestTeam[1] = j + 1;
            //                    bestTeam[2] = k + 1;
            //                    bestTeam[3] = m + 1;
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Результаты спортсменов (в сотых долях секунды):");
            //for (int i = 0; i < results.Length; i++)
            //{
            //    Console.WriteLine($"Спортсмен {i + 1}: {results[i] / 100.0} секунд");
            //}
            //Console.WriteLine($"\nЧетверка лучших бегунов для участия в эстафете:");
            //Console.WriteLine($"Спортсмены: {bestTeam[0]}, {bestTeam[1]}, {bestTeam[2]}, {bestTeam[3]}");
            //Console.WriteLine($"Сумма их результатов: {minSum / 100.0} секунд");

            //Random random = new Random();
            //int[] array = new int[23];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-100, 101); 
            //}
            //Console.WriteLine("Исходный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //int maxIndex = 0;
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (Math.Abs(array[i]) > Math.Abs(array[maxIndex]))
            //    {
            //        maxIndex = i;
            //    }
            //}
            //array[maxIndex] = -array[maxIndex];
            //Console.WriteLine("\nИзмененный массив (знак максимального по модулю элемента изменен):");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //int[] array = { 5, 3, 8, 6, 2, 7, 4, 1 }; 
            //Console.WriteLine("Исходный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if (array[i + 1] < array[i])
            //    {
            //        int temp = array[i];
            //        array[i] = array[i + 1];
            //        array[i + 1] = temp;
            //    }
            //}
            //Console.WriteLine("\nИзмененный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Последний элемент массива: " + array[array.Length - 1]);
        }
    }
}
