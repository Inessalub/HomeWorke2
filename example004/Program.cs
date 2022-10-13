// Найти расстояние между точками в пространстве 2D/3D

// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите число x1 ");
int x1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число x2 ");
int x2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число y1 ");
int y1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число y2 ");
int y2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число z1 ");
int z1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число z2 ");
int z2 = int.Parse(Console.ReadLine() ?? "0");

double space2D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2));
Console.WriteLine($"Расстояние между точками в пространстве 2D A: {x1}, {y1}, B: {x2}, {y2})  =  {space2D}");

double space3D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine($"Расстояние между точками в пространстве 3D A: {x1}, {y1}, {z1} B: {x2}, {y2}, {z2})  =  {space3D}");