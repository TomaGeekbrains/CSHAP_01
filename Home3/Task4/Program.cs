﻿// Задача 3: Напишите программу, которая принимает на вход
//  целое число из отрезка [10, 99] и показывает наибольшую цифру 
// числа.

class Program
{
    static void Main()
    {
        Console.Write(" [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
         Console.WriteLine(maxDigit);
    }
}