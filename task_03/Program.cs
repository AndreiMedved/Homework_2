// Task_03 Задать номер четверти, показать диапазоны для возможных координат

Console.Write("quarter = ");
int q = int.Parse(Console.ReadLine());

if (q == 1)
{
    Console.WriteLine("X >= 0 and Y >= 0");
}
else if (q == 2)
{
    Console.WriteLine("X <= 0 and Y >= 0");
}
else if (q == 3)
{
    Console.WriteLine("X <= 0 and Y <= 0");
}
else if (q == 4)
{
    Console.WriteLine("X >= 0 and Y <= 0");
}
else
{
    Console.WriteLine("There isn't quarter");
}