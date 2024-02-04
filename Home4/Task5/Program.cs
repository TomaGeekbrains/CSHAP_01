using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число N: 12345");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Цифры числа {n} через запятую: 1,2,3,4,5");
        PrintDigits(n);

        Console.ReadLine();
    }

    static void PrintDigits(int number)
    {
        string digitsString = number.ToString();
        for (int i = 0; i < digitsString.Length; i++)
        {
            Console.Write(digitsString[i]);
            if (i != digitsString.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
