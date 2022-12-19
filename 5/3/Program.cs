// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементом массива.

void FillArrayRandomNumbers(double [] Random) // Генерация случайных чисел
{
    for(int i = 0; i < Random.Length; i++)
    {
        Random[i] = new Random().Next(-99.0, 99.0);
    }
}
void PrintArray(double[] Random) // Заполнение массива 
{
    Console.Write("[ ");
    for(int i = 0; i < Random.Length; i++)
    {
        Console.Write(Random[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] Random = new double [size];
FillArrayRandomNumbers(Random);
Console.WriteLine();
Console.WriteLine("Полученый одномерный массив случайных чисел: ");
PrintArray(Random);