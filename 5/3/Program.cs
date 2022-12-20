// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементом массива.

void FillArrayRandomNumbers(double [] Random) //Генерация случайных вещественых чисел
{
    Random random = new Random();
    for(int i = 0; i < Random.Length; i++)
    {
        Random[i] = random.NextDouble() * 1000;
    }
}
void PrintDoubleArray(double[] Random) //Заполнение массива 
{
    Console.Write("[ ");
    for(int i = 0; i < Random.Length; i++)
    {
        Console.Write(String.Format("{0:00.00}  ", Random[i]));
    }
    Console.Write("]");
    Console.WriteLine();
}
// void FindMinAndMax(double[] Random) //Поиск минимального и максимального элиммента
// {
// double min = Random[0];
// double max = Random[0];
 
// double minIndex = 0;
// double maxIndex = 0;
 
// for (int i = 0; i < Random.Length; i++)
// {
//     if (Random[i] < min)
//     {
//         min = Random[i];
//         minIndex = i;
//     }
//     else if (Random[i] > max)
//     {
//         max = Random[i];
//         maxIndex = i;
//     }
// }
//  Console.WriteLine(String.Format("Минимальный элимент массива: [ {0:00.00} ]",min));
//  Console.WriteLine(String.Format("Максимальный элимент массива: [ {0:00.00} ]",max));
// }
void ShowDifferenceMinMax(double[] Random) //Разница между минимальным и максимальным элеменнтом массива
{
double FindMinNumber = Random[0];
double FindMaxNumber = Random[0];
 
double minIndex = 0;
double maxIndex = 0;
 
for (int i = 0; i < Random.Length; i++)
{
    if (Random[i] < FindMinNumber)
    {
        FindMinNumber = Random[i];
        minIndex = i;
    }
    else if (Random[i] > FindMaxNumber)
    {
        FindMaxNumber = Random[i];
        maxIndex = i;
    }
}
Console.WriteLine(String.Format("Минимальный элимент массива: [ {0:00.00} ]",FindMinNumber));
Console.WriteLine(String.Format("Максимальный элимент массива: [ {0:00.00} ]",FindMaxNumber));
Console.WriteLine(String.Format("Разница между найдеными элиментами массива: [ {0:00.00} ]",FindMaxNumber - FindMinNumber));
 
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] Random = new double [size];
FillArrayRandomNumbers(Random);
Console.WriteLine();
Console.WriteLine("Полученый одномерный массив случайных чисел: ");
PrintDoubleArray(Random);
// FindMinAndMax(Random);
ShowDifferenceMinMax(Random);
