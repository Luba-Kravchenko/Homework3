/*  Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве.  */

//Ввод координат точки А
Console.WriteLine("Введите координату x для точки А");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y для точки А");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки А");
int z1 = Convert.ToInt32(Console.ReadLine());

//Ввод координат точки B
Console.WriteLine("Введите координату x для точки B");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y для точки B");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

Double Segment = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Double Distance = Math.Round(Segment, 2);

Console.WriteLine("Расстояние между точками в 3D: " + Distance);