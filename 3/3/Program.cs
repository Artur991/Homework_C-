// Напишите программу, которая принимает на вход число (N) 
// и помещает в массив таблицу кубов чисел от 1 до N. 
// Полученный массив вывести на экран.
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
{
  int count = 0;
  int length = cube.Length;
  while (count <  length)
  {
    cube[count] = count*count*count;
    count++;
  }
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] arry = new int[cube+1];
Console.Write("Полученый массив: ");
Cube(arry);
PrintArry(arry);