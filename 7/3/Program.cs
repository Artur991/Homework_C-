// Необязательная, дополнительная задача Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// В каждом столбце найдите среднее арифметическое среди тех элементов,
//  которые являются палиндромами 
// (если палиндромов нет, то среднее арифметическое считать равным 0). Полученные средние арифметические занести в одномерный массив.

// Например, задан массив:
// 100 404 504 225
// 550 478 800 363
// 505 101 410 479
// => [505, 252.5, 0, 363 ]

Console.WriteLine("Создание двумерного массива. Введите количество строк массива: ");
int rowcount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columcount = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rowcount, columcount] ;  // 1

void FillArray(int[,] arr)          // 2
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        arr[i,j] = new Random().Next(100,999); 
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


FillArray(arr);
PrintArray(arr);
SumNoun(arr);
PrintArray(arr);

void SumNoun(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
    int sum = 0;
    int temp = 0;
    string temp2 = string.Empty;
    int temp3 = 0; 
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[i,j];
        temp2 = Convert.ToString(temp);
      if (temp2[0] == temp2[2])    // проверка на палиндром
      {
        temp3 = Convert.ToInt32(temp2);
        sum = sum + temp3;
        arr[i,j] = temp3;
        // temp3 += temp3; 
        Console.WriteLine("палиндромы:  {0}", arr[i,j]);
        Console.WriteLine("Сумма:  {0}", sum);      
        }  
        // temp3 += temp3; 
        // Console.WriteLine("Сумма2:  {0}", temp3);   
    }
    Console.WriteLine("Cумму :  {0}", sum);
}  
// Console.WriteLine("Cумму :  {0}", sum);
}  

