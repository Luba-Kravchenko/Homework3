/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = Math.Abs(num);
        string stringNum = Convert.ToString(a);
        if (stringNum[0] == stringNum[4] || stringNum[1] == stringNum[3])
        {
            Console.WriteLine($"Ваше число: {num} - палиндром.");
        }
        else 
        {
            Console.WriteLine($"Ваше число: {num} - НЕ палиндром."); 
        }

    }
}



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

Console.WriteLine($"Расстояние между точками в 3D {segmentLength}");
