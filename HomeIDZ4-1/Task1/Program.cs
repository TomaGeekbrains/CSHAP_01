using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break; // выход из цикла при вводе символа 'q'
            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sumOfDigits = CalculateSumOfDigits(number);
                if (sumOfDigits % 2 == 0)
                {
                    break; // выход из цикла при вводе числа, сумма цифр которого чётная
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
