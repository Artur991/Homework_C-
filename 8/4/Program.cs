// Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив. Обратите внимание, 
// что максимальный размер такого массива ограничен. 
// Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

// Например,
// 11 22 78
// 12 47 96
// 25 87 88
// класс с методами расширения

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Создание двумерного массива.   Количество строк массива: ");
        int rowcount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество столбцов массива: ");
        int columcount = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[rowcount, columcount];
        int[] arr2 = new int[rowcount * columcount];
        Console.WriteLine();
        Console.WriteLine("Вывод массива по заданым параметрам: ");
        FillRandom(arr, new Random()); // Генерация массива
        WriteArray(arr);               // Печать 2х мерного масива
        Console.WriteLine();
        Console.WriteLine("Вывод однострочного массива: ");
        ToJagged(arr);                    // Вывод в однострочный массив
    }
    static void FillRandom(int[,] array, Random random)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int element = random.Next(10, 100);
                while (Contains(array, element))
                {
                    element = random.Next(10, 100);
                }
                array[i, j] = element;
            }
        }
    }
    static bool Contains(int[,] array, int element)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == element)
                    return true;
            }
        }

        return false;
    }
    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static T[][] ToJagged<T>(T[,] array)
    {
        var result = new T[array.GetLength(0)][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new T[array.GetLength(1)];
            for (int j = 0; j < result[i].Length; j++)
            {
                result[i][j] = array[i, j];
                Console.Write(result[i][j] + " ");
            }
        }
        return result;
    }
}
