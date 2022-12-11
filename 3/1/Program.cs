// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int num1 = N / 10000;
int num5 = N % 10;
int num2 = (N / 1000)%10;
int num4 = (N / 10)%10;
int no5num = N / 10000;
if (num1 < 1 || num1 >9)
{
    Console.WriteLine($"Число: {N} - не пятизначное.");
}
else if (num1 == num5 && num2 == num4)
{
    Console.WriteLine($"Число: {N} - палиндром.");
}
else
Console.WriteLine($"Число: {N} - не палиндром.");

