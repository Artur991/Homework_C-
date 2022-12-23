// Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив 
// на 10 «интересных» случайных целых чисел от 10 до 1000. 
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] Random = new int [N];

void FillArrayRandomNumbers(int[] Random) // Генерация случайных интересных чисел
{
    int sum = 0;
    int proizvedenie = 0;
    int temp1 = 0;
    int temp2 = 0;
    int temp3 = 0;
    int i = 0;
    while(i < Random.Length)
    {
        Random[i] = new Random().Next(100,999);
        temp1 = Random[i]/100;
        temp2 = Random[i]%100/10;
        temp3 = Random[i]%10;
        sum = temp1+ temp2+ temp3;
        proizvedenie = temp1 * temp2 * temp3;
        if(proizvedenie > 0 && proizvedenie%sum == 0)
        {
           i++;
        }
    }
}

void PrintArray(int[] Random) // Заполнение массива  
{

    Console.Write("[ ");
    for(int i = 0; i < Random.Length; i++)
    {
        Console.Write(Random[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}



FillArrayRandomIntrestingNumbers(Random);
PrintIntrestingArray(Random);
