Console.WriteLine("Ведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB)
{
    max = numberA;
    Console.WriteLine(max);
}
else if (numberB > numberA)
{
    max = numberB;
    Console.WriteLine(max);
}
else
{
   Console.WriteLine("Числа равны");
}