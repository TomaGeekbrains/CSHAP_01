// // Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

Console.Write(" X: 5 6 7 8");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write(" Y: 1 2 3 4");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
  Console.Write("X: 5 6 7 8 ");
  x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
  Console.Write(" Y: 1 2 3 4");
  y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
  Console.WriteLine("1");
else if (x < 0 && y > 0)
  Console.WriteLine("2");
else if (x < 0 && y < 0)
  Console.WriteLine("3");
else
  Console.WriteLine("4");