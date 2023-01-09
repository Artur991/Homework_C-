// Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив. Обратите внимание, 
// что максимальный размер такого массива ограничен. 
// Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

// Например,
// 11 22 78
// 12 47 96
// 25 87 88


// класс с методами расширения



Console.WriteLine("Создание двумерного массива.  Количество строк массива: ");
int rowcount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов массива: ");
int columcount = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rowcount, columcount] ;
int N = rowcount * columcount;
int [] arr2 = new int [N] ;
int examinationNumber = 0;

void fillArray(int[,] arr)          
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        arr[i,j] = new Random().Next(10,100); 
        }
    }
}

void printArray(int[,] array)
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

void sortArray(int[,] array)
{
    Console.Write("{ ");
    for(int i = 0; i < arr.GetLength(0); i++)
    { 
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           for (int s = j; s < arr.GetLength(1) - 1; s++)
           {
           if (arr[i, j] < arr[j, s])
           {
           int temp = arr[j, s];
           if(arr[i, j] == arr[j, s])
           {
            arr[i, j] = 0;
           }
           } 
           }
        Console.Write(arr[i,j] + " ");
        }
    }  
    Console.Write("}");
    Console.WriteLine();
}

// bool Contains(int [,] array, int element)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i,j] == element)
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }

// bool ExaminationArray(int[,] array)          
// {
    
//     for(int i = 0; i<array.GetLength(0);i++)
// {
    
//       if(array[i,0]!=0)
//   {
//       for(int j = i+1;j< array.GetLength(1); j++)
//       {
//          if(array[i,j]==array[i,j])
//          {
//          array[i,j]== 0;
//          }
//       }
//    }
//     }
// }
// for(int i = 0;i<years.Lenght;i++)
// {
//    if(years[i]!="0")
//    {
//       Console.WriteLine(years[i]); или newArrayYears.Add(years[i])
//    }
// }
// }

fillArray(arr);
printArray(arr);
sortArray(arr);
// Contains(arr, examinationNumber);
ExaminationArray(examinationNumber);


// Console.Write(string.Join(' ', Array)); // сформирует строку из элементов и разделит их 'значением'
// string str = Convert.ToString(arr2);
// str = string.Join(' ', arr.Cast<int>());

// оператор X ? Y : Z  (N>0)?1:-1

