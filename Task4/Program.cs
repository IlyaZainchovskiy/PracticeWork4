using System;
using System.Text;

namespace Task4
{
    public static class ArrayAnalyzer
    {

        public static void FindMinMax(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Масив порожній або не ініціалізований.");
                return;
            }
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"Максимальний елемент в масиві: {max}");
            Console.WriteLine($"Мінімальний елемент в масиві: {min}");
        }

        public static int CountOccurrences(int[] array, int numberToFind)
        {
            if (array == null)
            {
                return 0; 
            }

            int count = 0; 
            foreach (int element in array)
            {
                if (element == numberToFind)
                {
                    count++;
                }
            }

            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Завдання 1 ---");
            int[] array1 = { 4, 5, 2, 3, 8, 7, 6, 1 };
            Console.WriteLine("Вхідний масив: { " + string.Join(", ", array1) + " }");

            ArrayAnalyzer.FindMinMax(array1);
            Console.WriteLine(); 

            Console.WriteLine("--- Завдання 2 ---");
            int[] array2 = { 1, 2, 5, 3, 7, 5, 1, 3, 4 };
            Console.WriteLine("Вхідний масив: { " + string.Join(", ", array2) + " }");
            int numberToFind1 = 5;
            int count1 = ArrayAnalyzer.CountOccurrences(array2, numberToFind1);
            Console.WriteLine($"Число '{numberToFind1}' зустрічається в масиві {count1} раз.");

            int numberToFind2 = 1;
            int count2 = ArrayAnalyzer.CountOccurrences(array2, numberToFind2);
            Console.WriteLine($"Число '{numberToFind2}' зустрічається в масиві {count2} раз.");
            int numberToFind3 = 9;
            int count3 = ArrayAnalyzer.CountOccurrences(array2, numberToFind3);
            Console.WriteLine($"Число '{numberToFind3}' зустрічається в масиві {count3} раз.");

            Console.ReadKey();
        }
    }
}

