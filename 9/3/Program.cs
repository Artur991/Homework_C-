// Задача 3: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 (?)
// m = 3, n = 2 -> A(m,n) = 29 (?)
Console.WriteLine("Вычисления функции Аккермана: ");
Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    else
      if ((M != 0) && (N == 0))
        return Akerman(M - 1, 1);
    else
        return Akerman(M - 1, Akerman(M, N - 1));
}

Console.WriteLine("Результат: " + Akerman(M, N)); 
