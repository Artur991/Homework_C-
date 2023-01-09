// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Не использовать массив.
// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Ведите количесво  чисел: ");
int CountNumbers = Convert.ToInt32(Console.ReadLine());
int Str = 0;
for (int i = 0; i < CountNumbers; i++)
{
    Console.WriteLine("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        Str++;
    }        
}
Console.WriteLine("Вы ввели {0} чисела, из них {1} больше 0 " ,CountNumbers ,Str);
