Console.WriteLine("Ведите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());


int Max(int numA, int numB, int numC)
{
    int result = numA;
    if (numB > result) result = numB;
    if (numC > result) result = numC; 
    return result;
}


int max = Max(numA, numB, numC);
Console.WriteLine(max);

/*
int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC; 

Console.WriteLine(max);
*/