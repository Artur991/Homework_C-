// Задача 1: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string Numbers (int N, int B = 1)
{
    if (N >= 1) return $" {N} " + Numbers(N - 1);
    else return String.Empty;

}

Console.WriteLine("Полученые натуральные числа от N до  1");
Console.WriteLine(Numbers(N) + " ");


