// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine() ?? "0");

if(a == b * b) 
{
    Console.WriteLine("Число a является квадратом числа b");
}
else if (b == a * a)
{
    Console.WriteLine("Число b является квадратом числа a");
}
else
{
    Console.WriteLine ("Одно число не является квадратом другого");
}