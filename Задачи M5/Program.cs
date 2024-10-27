using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_M5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //M5.?
            //а)
            //б)
            //в)
            //г)
            //д)

            //M5.1

            //а)
            //int[] nums = { 3, 5, 2, 8, 1 };
            //int max = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //}
            //Console.WriteLine($"Максимальный элемент: {max}");

            //б)
            //int[] nums = { 3, 5, 2, 8, 1 };
            //int min = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{

            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //}
            //Console.WriteLine($"Минимальный элемент: {min}");

            //в)
            //int[] nums = { 3, 5, 2, 8, 1 };
            //int min = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //}
            //Console.WriteLine($"Минимальный элемент: {min}");
            //г)
            //int[] nums = { 3, 5, 2, 8, 1 };
            //int maxIndex = 0;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > nums[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
            //Console.WriteLine($"Максимальный элемент: {nums[maxIndex]}");

            //д)
            //int[] nums = { 3, 5, 2, 8, 1 };
            //int minIndex = 0;
            //int maxIndex = 0;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] < nums[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //    if (nums[i] > nums[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine($"Индекс минимального элемента: {minIndex}");
            //Console.WriteLine($"Минимальный элемент: {nums[minIndex]}");
            //Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
            //Console.WriteLine($"Максимальный элемент: {nums[maxIndex]}");

            //M5.2
            //Random random = new Random();
            //decimal[] prices = new decimal[50];
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    prices[i] = random.Next(15000, 100001);
            //}
            //decimal maxPrice = prices[0];
            //for (int i = 1; i < prices.Length; i++)
            //{
            //    if (prices[i] > maxPrice)
            //    {
            //        maxPrice = prices[i];
            //    }
            //}
            //Console.WriteLine($"Стоимость самого дорогого автомобиля: {maxPrice}");

            //M5.3
            //Random random = new Random();
            //decimal[] prices = new decimal[20];
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    prices[i] = random.Next(50, 501); 
            //}
            //decimal minPrice = prices[0];
            //for (int i = 1; i < prices.Length; i++)
            //{
            //    if (prices[i] < minPrice)
            //    {
            //        minPrice = prices[i];
            //    }
            //}
            //Console.WriteLine($"Стоимость самых дешевых конфет: {minPrice}");

            //M5.4
            //Random random = new Random();
            //int[] heights = new int[25];
            //for (int i = 0; i < heights.Length; i++)
            //{
            //    heights[i] = random.Next(150, 201); 
            //}
            //int maxHeight = heights[0];
            //int minHeight = heights[0];
            //for (int i = 1; i < heights.Length; i++)
            //{
            //    if (heights[i] > maxHeight)
            //    {
            //        maxHeight = heights[i];
            //    }
            //    if (heights[i] < minHeight)
            //    {
            //        minHeight = heights[i];
            //    }
            //}
            //int heightDifference = maxHeight - minHeight;
            //Console.WriteLine($"Рост самого высокого человека: {maxHeight} см");
            //Console.WriteLine($"Рост самого низкого человека: {minHeight} см");
            //Console.WriteLine($"На сколько рост самого высокого человека превышает рост самого низкого: {heightDifference} см");

            //M5.5
            //Random random = new Random();
            //int[] scores = new int[8];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    scores[i] = random.Next(1, 11); 
            //}
            //Console.WriteLine("Оценки судей: " + string.Join(", ", scores));
            //int maxScore = scores.Max();
            //int minScore = scores.Min();
            //int[] filteredScores = scores.Where(score => score != maxScore && score != minScore).ToArray();
            //if (filteredScores.Length < 6)
            //{
            //    filteredScores = scores.Where(score => score == maxScore || score == minScore).Concat(filteredScores).ToArray();
            //}
            //double averageScore = filteredScores.Average();
            //Console.WriteLine($"Средняя оценка после удаления наивысшей и наинизшей оценок: {averageScore:F2}");

            //M5.6
            //а)
            //int[] speeds = new int[40];
            //Random random = new Random();
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    speeds[i] = random.Next(100, 301); 
            //}
            //Console.WriteLine("Максимальные скорости автомобилей: " + string.Join(", ", speeds));
            //int maxSpeed = speeds[0];
            //int maxIndex = 0;
            //for (int i = 1; i < speeds.Length; i++)
            //{
            //    if (speeds[i] > maxSpeed)
            //    {
            //        maxSpeed = speeds[i];
            //        maxIndex = i; 
            //    }
            //}
            //Console.WriteLine($"Самый быстрый автомобиль имеет скорость: {maxSpeed} км/ч");
            //Console.WriteLine($"Порядковый номер самого быстрого автомобиля: {maxIndex + 1}"); 
            //б)
            //int[] speeds = new int[40];
            //Random random = new Random();
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    speeds[i] = random.Next(100, 301); 
            //}
            //Console.WriteLine("Максимальные скорости автомобилей: " + string.Join(", ", speeds));
            //int maxSpeed = speeds[0];
            //int maxIndex = 0;
            //for (int i = 1; i < speeds.Length; i++)
            //{
            //    if (speeds[i] >= maxSpeed) 
            //    {
            //        maxSpeed = speeds[i];
            //        maxIndex = i; 
            //    }
            //}
            //Console.WriteLine($"Самый быстрый автомобиль имеет скорость: {maxSpeed} км/ч");
            //Console.WriteLine($"Порядковый номер самого быстрого автомобиля: {maxIndex + 1}");

            //M5.7
            //int[] nums = new int[40];
            //Random random = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(1, 101); 
            //}
            //Console.WriteLine("Элементы массива: " + string.Join(", ", nums));
            //int maxElement = nums[0];
            //int minElement = nums[0];
            //int maxCount = 1;
            //int minCount = 1;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > maxElement)
            //    {
            //        maxElement = nums[i];
            //        maxCount = 1; 
            //    }
            //    else if (nums[i] == maxElement)
            //    {
            //        maxCount++; 
            //    }

            //    if (nums[i] < minElement)
            //    {
            //        minElement = nums[i];
            //        minCount = 1; 
            //    }
            //    else if (nums[i] == minElement)
            //    {
            //        minCount++; 
            //    }
            //}
            //Console.WriteLine($"Максимальный элемент: {maxElement}, Количество максимальных элементов: {maxCount}");
            //Console.WriteLine($"Минимальный элемент: {minElement}, Количество минимальных элементов: {minCount}");

            //M5.8
            //int[] nums = new int[40];
            //Random random = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(1, 101);
            //}
            //Console.WriteLine("Элементы массива: " + string.Join(", ", nums));
            //int minElement = nums[0];
            //int maxElement = nums[0];
            //List<int> minIndices = new List<int>();
            //List<int> maxIndices = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] < minElement)
            //    {
            //        minElement = nums[i];
            //        minIndices.Clear(); 
            //        minIndices.Add(i); 
            //    }
            //    else if (nums[i] == minElement)
            //    {
            //        minIndices.Add(i); 
            //    }
            //    if (nums[i] > maxElement)
            //    {
            //        maxElement = nums[i];
            //        maxIndices.Clear();
            //        maxIndices.Add(i);
            //    }
            //    else if (nums[i] == maxElement)
            //    {
            //        maxIndices.Add(i); 
            //    }
            //}
            //Console.WriteLine($"Минимальный элемент: {minElement}, Индексы: {string.Join(", ", minIndices)}");
            //Console.WriteLine($"Максимальный элемент: {maxElement}, Индексы: {string.Join(", ", maxIndices)}");

            //M5.9
            //double[] nums = new double[40];
            //Random random = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.NextDouble() * 99 + 1; 
            //}
            //Console.WriteLine("Элементы массива: " + string.Join(", ", nums));
            //double minElement = nums[0];
            //double maxElement = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] < minElement)
            //    {
            //        minElement = nums[i];
            //    }

            //    if (nums[i] > maxElement)
            //    {
            //        maxElement = nums[i];
            //    }
            //}
            //bool conditionA = (maxElement - minElement) <= 25;
            //bool conditionB = (minElement < maxElement / 2);
            //Console.WriteLine($"Минимальный элемент: {minElement}");
            //Console.WriteLine($"Максимальный элемент: {maxElement}");
            //Console.WriteLine($"Условие A (максимальный элемент превышает минимальный не более чем на 25): {conditionA}");
            //Console.WriteLine($"Условие B (минимальный элемент меньше максимального более чем в 2 раза): {conditionB}");

            //M5.10
            //double[] nums = new double[40];
            //Random random = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.NextDouble() * 99 + 1;
            //}
            //Console.WriteLine("Элементы массива: " + string.Join(", ", nums));
            //double minElement = nums[0];
            //double maxElement = nums[0];
            //int minIndex = 0;
            //int maxIndex = 0;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] < minElement)
            //    {
            //        minElement = nums[i];
            //        minIndex = i;
            //    }
            //    if (nums[i] > maxElement)
            //    {
            //        maxElement = nums[i];
            //        maxIndex = i;
            //    }
            //}
            //if (minIndex < maxIndex)
            //{
            //    Console.WriteLine($"Минимальный элемент {minElement} встретился раньше максимального элемента {maxElement}.");
            //}
            //else if (maxIndex < minIndex)
            //{
            //    Console.WriteLine($"Максимальный элемент {maxElement} встретился раньше минимального элемента {minElement}.");
            //}
            //else
            //{
            //    Console.WriteLine("Минимальный и максимальный элементы встречаются на одной позиции (это возможно, если они равны).");
            //}

            //M5.11
            //int[] windDirections = new int[365];
            //Random random = new Random();
            //for (int i = 0; i < windDirections.Length; i++)
            //{
            //    windDirections[i] = random.Next(1, 9); 
            //}
            //int[] directionCounts = new int[8];
            //foreach (int direction in windDirections)
            //{
            //    directionCounts[direction - 1]++;
            //}
            //Console.WriteLine("Количество дней по направлениям ветра:");
            //for (int i = 0; i < directionCounts.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} - {directionCounts[i]} дней");
            //}
            //int minDirection = 0;
            //int minCount = directionCounts[0];
            //for (int i = 1; i < directionCounts.Length; i++)
            //{
            //    if (directionCounts[i] < minCount)
            //    {
            //        minCount = directionCounts[i];
            //        minDirection = i;
            //    }
            //}
            //Console.WriteLine($"Оптимальное направление для строительства жилого комплекса: {minDirection + 1} (частота: {minCount} дней)");
            //string[] directionNames = { "Северный", "Южный", "Восточный", "Западный", "Северо-западный", "Северо-восточный", "Юго-западный", "Юго-восточный" };
            //Console.WriteLine($"Рекомендуемое направление: {directionNames[minDirection]}");

            //M5.12
            //int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            //int maxElement = int.MinValue;
            //int secondMaxElement = int.MinValue;
            //int minElement = int.MaxValue;
            //int secondMinElement = int.MaxValue;
            //int maxIndex = -1;
            //int minIndex = -1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > maxElement)
            //    {
            //        secondMaxElement = maxElement;
            //        maxElement = array[i];
            //        maxIndex = i; 
            //    }
            //    else if (array[i] > secondMaxElement && array[i] != maxElement)
            //    {
            //        secondMaxElement = array[i]; 
            //    }
            //    if (array[i] < minElement)
            //    {
            //        secondMinElement = minElement;
            //        minElement = array[i];
            //        minIndex = i; 
            //    }
            //    else if (array[i] < secondMinElement && array[i] != minElement)
            //    {
            //        secondMinElement = array[i];
            //    }
            //}
            //Console.WriteLine($"Максимальный элемент: {maxElement} (индекс: {maxIndex})");
            //Console.WriteLine($"Максимальный элемент без учета максимального: {secondMaxElement}");
            //Console.WriteLine($"Минимальный элемент: {minElement} (индекс: {minIndex})");
            //Console.WriteLine($"Минимальный элемент без учета минимального: {secondMinElement}");
            //Console.WriteLine($"Индексы: Максимальный элемент - {maxIndex}, Максимальный без учета - {Array.IndexOf(array, secondMaxElement)}");
            //Console.WriteLine($"Индексы: Минимальный элемент - {minIndex}, Минимальный без учета - {Array.IndexOf(array, secondMinElement)}");

            //M5.13
            //Random random = new Random();
            //int[] speeds = new int[40];
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    speeds[i] = random.Next(100, 301); 
            //}
            //int maxSpeed = int.MinValue;
            //int secondMaxSpeed = int.MinValue;
            //for (int i = 0; i < speeds.Length; i++)
            //{
            //    if (speeds[i] > maxSpeed)
            //    {
            //        secondMaxSpeed = maxSpeed; 
            //        maxSpeed = speeds[i]; 
            //    }
            //    else if (speeds[i] > secondMaxSpeed && speeds[i] != maxSpeed)
            //    {
            //        secondMaxSpeed = speeds[i]; 
            //    }
            //}
            //Console.WriteLine("Скорости автомобилей:");
            //foreach (var speed in speeds)
            //{
            //    Console.WriteLine(speed);
            //}
            //Console.WriteLine($"Максимальная скорость: {maxSpeed}");
            //Console.WriteLine($"Вторая максимальная скорость: {secondMaxSpeed}");

            //M5.14
            //int[] peopleOnFloors = { 10, 20, 5, 15, 30, 25, 12, 18, 22, 8, 14, 6, 9, 11, 4 };
            //int minPeople = int.MaxValue;
            //int secondMinPeople = int.MaxValue;
            //int minFloor = -1;
            //int secondMinFloor = -1;
            //for (int i = 0; i < peopleOnFloors.Length; i++)
            //{
            //    if (peopleOnFloors[i] < minPeople)
            //    {
            //        secondMinPeople = minPeople;
            //        secondMinFloor = minFloor;
            //        minPeople = peopleOnFloors[i];
            //        minFloor = i + 1; 
            //    }
            //    else if (peopleOnFloors[i] < secondMinPeople && peopleOnFloors[i] != minPeople)
            //    {
            //        secondMinPeople = peopleOnFloors[i];
            //        secondMinFloor = i + 1;
            //    }
            //}
            //Console.WriteLine($"Этаж с наименьшим количеством людей: {minFloor} (Количество людей: {minPeople})");
            //Console.WriteLine($"Этаж с вторым наименьшим количеством людей: {secondMinFloor} (Количество людей: {secondMinPeople})");

            //M5.15
            //Random rand = new Random();
            //double[] results = new double[23];
            //for (int i = 0; i < results.Length; i++)
            //{
            //    results[i] = rand.Next(9800, 10501) / 100.0; 
            //}
            //Console.WriteLine("Результаты спортсменов (в сотых долях секунды):");
            //for (int i = 0; i < results.Length; i++)
            //{
            //    Console.WriteLine($"Спортсмен {i + 1}: {results[i]:F2}");
            //}
            //double minSum = double.MaxValue;
            //int index1 = -1, index2 = -1, index3 = -1, index4 = -1;
            //for (int i = 0; i < results.Length - 3; i++)
            //{
            //    for (int j = i + 1; j < results.Length - 2; j++)
            //    {
            //        for (int k = j + 1; k < results.Length - 1; k++)
            //        {
            //            for (int m = k + 1; m < results.Length; m++)
            //            {
            //                double currentSum = results[i] + results[j] + results[k] + results[m];
            //                if (currentSum < minSum)
            //                {
            //                    minSum = currentSum;
            //                    index1 = i + 1; 
            //                    index2 = j + 1;
            //                    index3 = k + 1;
            //                    index4 = m + 1;
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"\nИндексы четырех лучших бегунов: {index1}, {index2}, {index3}, {index4}");
            //Console.WriteLine($"Сумма их результатов: {minSum:F2}");

            //M5.16
            //double[] array = { -3.5, 2.1, 4.7, -9.2, 5.5, -7.1, 6.3 };
            //Console.WriteLine("Исходный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //double maxAbsValue = double.MinValue;
            //int maxAbsIndex = -1;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (Math.Abs(array[i]) > maxAbsValue)
            //    {
            //        maxAbsValue = Math.Abs(array[i]);
            //        maxAbsIndex = i;
            //    }
            //}
            //if (maxAbsIndex != -1)
            //{
            //    array[maxAbsIndex] = -array[maxAbsIndex];
            //}
            //Console.WriteLine("\nИзмененный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //M5.17
            //int[] array = { 5, 2, 8, 3, 1, 4, 7, 6 };
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
