// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Создание двумерного массива.   Количество строк массива: ");
int rowcount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов массива: ");
int columcount = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rowcount, columcount] ;


void FillArray(int[,] arr)          
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        arr[i,j] = new Random().Next(1,10); 
        }
    }
}

void PrintArray(int[,] arr)
{
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{ ");
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        Console.Write(arr[i,j] + " "); 
        }
        Console.Write("}");
        Console.WriteLine();
    }
    
    Console.WriteLine();
}


void PrintSortArray(int[,] arr)
{
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{ ");
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           for (int s = 0; s < arr.GetLength(1) - 1; s++)
           {
           if (arr[i, s] < arr[i, s + 1])
           {
           int temp = arr[i, s + 1];
           arr[i, s + 1] = arr[i, s];
           arr[i, s] = temp;
           }
           }
        Console.Write(arr[i,j] + " "); 
        }
        Console.Write("}");
        Console.WriteLine();
    }  
}


FillArray(arr);
PrintArray(arr);
PrintSortArray(arr);
