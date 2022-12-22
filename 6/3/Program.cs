// Найдите сумму произведений пар чисел в одномерном 
// целочисленном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Если кол-во элементов нечетное, 
// то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28


Console.WriteLine("Создание массива");
int N = Convert.ToInt32(Console.ReadLine());

int [] arr = new int [N] ;
void FillArray(int[] arr)
{
    
    for(int i = 0; i < arr.Length; i++)
    {
        
        arr[i] = new Random().Next(1,10);
        
    }
}
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for(int i = 0; i < arr.Length; i++)
    {
        
        
        Console.Write(arr[i] + " ");
        
        
    }
    Console.Write("}");
    Console.WriteLine();
}

void SumNoun(int [] arr)
{
    var sum =0;
    for (int i = 0, j = arr.Length-1; i < j; i++, j--) 
    {
    sum = sum + (arr[i] * arr[j]);
    arr[i] = arr[i] * arr[j];
    }
    Console.WriteLine("Cумму произведений пар чисел массива:  {0}", sum);
}    

FillArray(arr);
PrintArray(arr);
SumNoun(arr);
// PrintArray(arr);