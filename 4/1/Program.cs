// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow

Console. Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите степень возведения: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    if (A == 0)
{  
    Console.Write($"Нельзя {A} Возвести в степень");
    return;
}
    else if  (B == 0)
    {
        Console.WriteLine($" Число {A} в степени {B} = 1");
        return;
    }
    else
    {
        result = result * A;

    }
}
Console.Write(result);
// if (A == 0)
// {  
//     Console.Write($"Нельзя {A} Возвести в степень");
//     return;
// }
//     else if  (B == 0)
//     {
//         Console.WriteLine($" Число {A} в степени {B} = 1");
//         return;
//     }

// else
// {
//     for (int i = 1; i < B; i++)
//      {
//         result = result * A;

//     }
// }
// Console.Write(result);
