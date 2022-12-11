// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console. Write("Введите через пробел координаты первой точки по x: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console. Write("По y:   ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console. Write("По z:   ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите через пробел координаты второй точки по x: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console. Write("По y:   ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console. Write("По z:   ");
double z2 = Convert.ToInt32(Console.ReadLine());
double pow1 = (x2 - x1)*(x2 - x1); // можно через Math.Pow((x2 - x1),2)
double pow2 = (y2 - y1)*(y2 - y1);
double pow3 = (z2 - z1)*(z2 - z1);
double radix = pow1 + pow2 + pow3;
double Distance = Math.Round(Math.Sqrt(radix), 2); 
// разобратся в математическом нахождении корня double не получилось 
Console.WriteLine($"Расстояние между кардинатами равно {Distance}");
// Вариант нахождения корня для целочисленых значений
// while(a<=(radix))
// {
//     radix -= a;
//     a += 2;
//     Distance+=1;
// }

