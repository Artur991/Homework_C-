// Задача 3: Задайте две квадратные матрицы одинакового размера. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица:
// 18 20
// 15 18

static class MatrixExt
{
    // метод расширения для получения количества строк матрицы
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }

    // метод расширения для получения количества столбцов матрицы
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }   
}

class Program
{
    // метод для получения матрицы из консоли
    static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Количество строк матрицы {0}:    ", name);
        var n = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов матрицы {0}: ", name);
        var m = int.Parse(Console.ReadLine());

        var matrix = new int[n, m];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                matrix[i, j] = new Random().Next(1,10); ;
            }
        }

        return matrix;
    }

    // метод для печати матрицы в консоль
    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    // метод для умножения   матриц
    static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

        for (var i = 0; i < matrixA.RowsCount(); i++)
        {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.ColumnsCount(); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Программа для умножения матриц");

        var a = GetMatrixFromConsole("A");
        var b = GetMatrixFromConsole("B");

        Console.WriteLine("Матрица A:");
        PrintMatrix(a);

        Console.WriteLine("Матрица B:");
        PrintMatrix(b);

        var result = MatrixMultiplication(a, b);
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(result);

        Console.ReadLine();
    }
}