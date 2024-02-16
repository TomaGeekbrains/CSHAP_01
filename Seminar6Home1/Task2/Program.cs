// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

class Program
{
    static void Main(string[] args)
    {
        string originalString = "HeLloWorLD";
        string lowerCaseString = originalString.ToLower();

        Console.WriteLine(lowerCaseString);
    }
}