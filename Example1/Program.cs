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



Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int i = 0;
    int length = cube.Length;
    while (i < length)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
    }
}

void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArry(arry);
