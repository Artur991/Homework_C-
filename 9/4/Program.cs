// Задача 4*. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размерность массива");
// int s = Convert.ToInt32(Console.ReadLine());
int number = 1;
double [,] Array = new double [n,n];
// const n = 4;

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(String.Format("{0:00}  ", + Array[i,j]));
//     }
//     Console.WriteLine();
// }


    // for (int i =0; i < n / 2; i++)
    // {
    //     for (int j =i; j < n -i; j++)
    //         Array[i][j] = number++;
    //     for (int k = i + 1; k < n - i; k++)
    //         Array[k][n-1-i] = number++;
    //     for (int j = n-i - 2; j >= i; j--)
    //         Array[n-1-i][j] = number++;
    //     for (int k = n-1-i; k > i; k--)
    //         Array[k][i] = number++;
    // }


void FillArray(double[,] arr)
{
     for (int i =0; i < n / 2; i++)
    {
        for (int j =i; j < n -i; j++)
            Array[i,j] = number++;
        for (int k = i + 1; k < n - i; k++)
            Array[k,n-1-i] = number++;
        for (int j = n-i - 2; j >= i; j--)
            Array[n-1-i,j] = number++;
        for (int k = n-1-i; k > i; k--)
            Array[k,i] = number++;
    }
}

void PrintArray(double[,] arr)
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

FillArray(Array);
PrintArray(Array);