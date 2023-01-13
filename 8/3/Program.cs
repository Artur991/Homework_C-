// Задача 3: Задайте две квадратные матрицы одинакового размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18

Console.WriteLine("Создание Матрицы A. Количество строк: ");
int rowcountA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов Матрицы A: ");
int columcountA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Создание Матрицы B.   Количество строк: ");
int rowcountB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов Матрицы B: ");
int columcountB = Convert.ToInt32(Console.ReadLine());

int[,] A = new int[rowcountA, columcountA];
int[,] B = new int[rowcountB, columcountB];

void FillArray(int[,] array)          
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        array[i,j] = new Random().Next(1,10); 
        }
    }
}    

static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
    
static int[,] Multiplication(int[,] array, int[,] array2)
    {
        if (array.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        int[,] r = new int[array.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    r[i,j] += array[i,k] * array2[k,j];
                }
            }
        }
    return r;
    }

FillArray(A);
FillArray(B);
Console.WriteLine("Матрица первая: ");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Матрица вторая: ");
PrintArray(B);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
int[,] C = Multiplication(A, B);
PrintArray(C);