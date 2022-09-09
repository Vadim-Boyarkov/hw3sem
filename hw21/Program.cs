// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки");
double coordX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
double coordY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
double coordZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
double coordX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
double coordY2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки");
double coordZ2 = Convert.ToInt32(Console.ReadLine());

double qwx = Math.Pow((coordX2 - coordX1), 2);

double qwy = Math.Pow((coordY2 - coordY1), 2);
double qwz = Math.Pow((coordZ2 - coordZ1), 2);
double length = Math.Sqrt(qwx + qwy + qwz);
Console.WriteLine(Math.Round(length , 2));