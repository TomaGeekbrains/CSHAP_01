
3.// Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Удаление пробелов и приведение всех символов к нижнему регистру
        string processedStr = str.Replace(" ", "").ToLower();
        
        int left = 0;
        int right = processedStr.Length - 1;

        while (left < right)
        {
            if (processedStr[left] != processedStr[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}