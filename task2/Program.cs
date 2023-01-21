// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите последовательность координат");
Console.WriteLine("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zA: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"xA {xA}, yA {yA}, zA {zA}, xB {xB}, yB {yB}, zB {zB},");

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + (Math.Pow((yB - yA), 2)) + (Math.Pow((zB - zA), 2)));

Console.WriteLine(result);

