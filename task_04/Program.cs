//Task_04 Найти расстояние между точками в пространстве 2D/3D
//Console.Write("input number A for 2D: ");
//int a_2d = int.Parse(Console.ReadLine());

//Console.Write("input number B for 2D: ");
//int b_2d = int.Parse(Console.ReadLine());
//Console.Write("Difference: " + (Math.Sqrt(a_2d - b_2d)));
double ax = new Random().Next(-100, 100);
double ay = new Random().Next(-100, 100);
double az =  new Random().Next(-100, 100);
double bx = new Random().Next(-100, 100);
double by = new Random().Next(-100, 100);
double bz = new Random().Next(-100, 100);

double[] point_a = new double[] { ax, ay, az };
double[] point_b = new double[] { bx, by, bz };

Console.WriteLine("point A: " + point_a[0] + ", " + point_a[1] + ", " + point_a[2]);
Console.WriteLine("point B: " + point_b[0] + ", " + point_b[1] + ", " + point_b[2]);

Console.WriteLine("diff between Ax and Bx: " + Math.Abs(ax - bx));
Console.WriteLine("diff between Ay and By: " + Math.Abs(ay - by));
Console.WriteLine("diff between Az and Bz: " + Math.Abs(az - bz));

