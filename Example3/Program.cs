/* Напишите программу, которая принимает на вход число (N) 
   и выдаёт таблицу кубов чисел от 1 до N.  */

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число от 1 до N: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 1)
        {
            Console.WriteLine("Введите число больше или равное 1");
        }
        for (int i = 0; i < num; i++)
        {
            Console.Write(Math.Pow(i+1, 3) + ", ");
        }
        Console.ReadKey();
    }
}


