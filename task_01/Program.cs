// Task_01 Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = new Random().Next(1, 8);

if (a >= 6)
{
    Console.WriteLine(a + " It's hollyday!!!");
}
else
{
    Console.WriteLine(a + " Work!");
}

