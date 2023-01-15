// Задача 4*. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("");

int [,] array = new int [4,4];
// double [,] array = new double [4,4];

// void FillArray(double[,] arr)
// {
//     Random random = new Random();
//         for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//         arr[i,j] = random.Next(01,15);    
//         }
   
//     }
// }

// void PrintArray(double[,] arr)
// {
    
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write("{ ");
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(String.Format("{0:N2}  ", + arr[i,j]));
//         }
//         Console.Write("}");
//         Console.WriteLine();
//     }
    
//     Console.WriteLine();
// }

void FillArray(int[,] arr)
{
        for(int i = 0; i < arr.GetLength(1); i++)
    {
         arr[0,i] += i+1;
    }
    for(int j = 0; j < arr.GetLength(0); j++)
    {
        arr[j,arr.GetLength(0)-1] += j;

    }
   
}

void PrintArray(int[,] arr)
{
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{ ");
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0:00}  ", + arr[i,j]));
        }
        Console.Write("}");
        Console.WriteLine();
    }
    
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
