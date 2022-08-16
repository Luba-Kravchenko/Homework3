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



