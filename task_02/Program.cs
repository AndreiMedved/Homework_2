// Task_02 По двум заданным числам проверять является ли одно квадратом другого
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("a = b*b");
}
else if (b == a * a)
{
    Console.WriteLine("b = a*a");
}

else
{
    Console.WriteLine("try again");
}
