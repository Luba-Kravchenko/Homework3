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

 /* или

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));               
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Расстояние между точками в 3D {segmentLength}"); */
