//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n%7 == 0 && n%11 == 0)
{
   Console.WriteLine("Число кратно 7 и 11");
}
else if (n%7 == 0)
{
  Console.WriteLine("Число кратно 7, но не кратно  11");
}
else if (n%11 == 0)
{
  Console.WriteLine("Число кратно 11, но не кратно  7");
}
else
Console.WriteLine("Число не кратно ни 11 ни 7");


//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Ведите день недели от 1 до 7: ");
int numberday = Convert.ToInt32(Console.ReadLine());
//вариант 1
if(numberday == 1)
{
  Console.WriteLine("Понедельник");
}
else if(numberday == 2)
{
  Console.WriteLine("Вторник");
}
else if(numberday == 3)
{
  Console.WriteLine("Среда");
}
else if(numberday == 4)
{
 Console.WriteLine("Четверг");
}
else if(numberday == 5)
{
  Console.WriteLine("Пятница");
}
else if(numberday == 6)
{
  Console.WriteLine("Суббота");
}
else if(numberday == 7)
{
  Console.WriteLine("Воскресение");
}      
else
{
  Console.WriteLine("Нет такого дня недели");
}


//вариант 2
/*
switch (numberday){
    case 1:
        Console.WriteLine("Понедельник");
        Console.Write("рабочий день");
        break;
    case 2:
        Console.WriteLine("Вторник");
         Console.Write("рабочий день");
        break;
    case 3:
        Console.WriteLine("Среда");
         Console.Write("рабочий день");
        break;
    case 4:
        Console.WriteLine("Четверг");
         Console.Write("рабочий день");
        break;
    case 5:
        Console.WriteLine("Пятница");
         Console.Write("рабочий день");
        break;
    case 6:
        Console.WriteLine("Суббота");
         Console.Write("выходной");
        break;
    case 7:
        Console.WriteLine("Воскресение");
         Console.Write("выходной");
        break;  
    case > 7:
      Console.WriteLine("нет такого дня недели");
      break;
    
}
*/