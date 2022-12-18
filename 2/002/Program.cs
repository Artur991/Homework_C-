
//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. 

Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
//вариант 1
string n = Console.ReadLine();
if (n.Length  > 2)
{
    Console.WriteLine(n[2]);
}
else
Console.WriteLine("Нет третьего числа");


//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. 
//случайный генератор от 1 до 65536
/*
int n = new Random().Next(1, 65536);
Console.WriteLine("число: " + n);

//вариант 1
if (n > 9999)
{
   Console.WriteLine((n/100)%10);
}
else if (n > 999)
{
   Console.WriteLine((n/10)%10);
}
else if (n > 99)
{
   Console.WriteLine(n%10);
}
else
Console.WriteLine("Нет третьего числа");

//вариант 2
/*
 string s = n.ToString();

if (s.Length  > 2)
{
    Console.WriteLine(s[2]);
}
else
{
    Console.WriteLine("Нет третьего числа");
}
*/

