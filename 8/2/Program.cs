// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


int SumLineElements(int[,] array, int i)  
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void FindRowWithMinSum(int [,] arr) 
{
  int sumLine = SumLineElements(arr, 0);
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    Console.WriteLine(" Строка № {0}, сумма ее элементов {1}", i+1, SumLineElements(arr, i));
  }
}

void ShowRowWithMinSum(int [,] arr) 
{
  int minSumLine = 0;
  int sumLine = SumLineElements(arr, 0);
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int tempSumLine = SumLineElements(arr, i);
    if (sumLine > tempSumLine)
    {
      sumLine = tempSumLine;
      minSumLine = i;
    } 
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
    }




FillArray(arr);
Console.WriteLine("Получаем массив заданого размера, со случайными цифрами:  ");
PrintArray(arr);
Console.WriteLine("Ввывод строк с суммой элементов:  ");
Console.ReadLine();
FindRowWithMinSum(arr);
Console.WriteLine();
Console.WriteLine("Для поиска строк с наименьшей суммой элементов нажмите Enter:  ");
Console.ReadLine();
ShowRowWithMinSum(arr);