// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе, которые являются делителями этого числа
Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
double sum = 0;
string str_number = Convert.ToString(number);
List<int> list = new List<int>();
char[] arr = str_number.ToCharArray();
for(int i = 0; i< arr.Length; i++)
{
        list.Add(Int32.Parse(new String(arr[i], 1)));              
        double x = Convert.ToInt32(list[i]);
        if (number % x == 0)
        {
                sum +=x;                
        }
                
        }
Console.WriteLine ("Сумма цифр числа, которые являются делителями этого числа: {0}", sum);
