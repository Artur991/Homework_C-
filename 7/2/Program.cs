// Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.WriteLine("Создание двумерного массива. Введите    количество строк массива: ");
int rowcount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columcount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поиск эллемента. Индекс нужной строки: ");
int ShowRowcount_Index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Индекс нужного столбца: ");
int ShowColumcount_Index = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [rowcount, columcount] ;  // Планирую создать поиск по масиву вещественных чисел, ( Возможность закоментил)
void FillArray(double[,] arr)
{
    //  Random random = new Random(); // для вещественных значений
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        arr[i,j] = new Random().Next(1,10); // Для целочисленых данных
        //  arr[i,j] = random.NextDouble() * 10 ; // Вариант для вещественных значений
        }
    }
}
void PrintArray(double[,] arr)
{
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("{ ");
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        Console.Write(arr[i,j] + " "); // Для целочисленых данных
        //  Console.Write(String.Format("{0:N2}  ", + arr[i,j])); // Вариант для вещественных значений
        }
        Console.Write("}");
        Console.WriteLine();
    }
    
    Console.WriteLine();
}
FillArray(arr);
PrintArray(arr);
double Show = arr[0,0];
for (int i = 0; i < arr.Length; i++)                  
{
    if (ShowRowcount_Index >= rowcount)
    {
        Console.WriteLine("Строки с индексом {0} не сушествует ", ShowRowcount_Index);
        break;
    }
    else if (ShowColumcount_Index >= columcount )
    {
        Console.WriteLine("Столбца с индексом {0} не сушествует ", ShowColumcount_Index);  
        break;   
    }
    if (i == ShowRowcount_Index)
    {
    int Rowcount_Index = i;
       
        for (int j = 0; j < arr.Length; j++)
        if (j == ShowColumcount_Index)
        {
        Show = arr[i,j];
        int Columcount_Index = j;
        }
    }
   
}

if (ShowRowcount_Index < rowcount  && ShowColumcount_Index < columcount )
{
    Console.WriteLine(String.Format("Найденный элемент массива [ {0} ]",Show)); // Для целочисленых данных
    // Console.WriteLine(String.Format("Найденный элемент массива [ {0:N2} ]",Show)); // Вариант для вещественных значений
}   

    