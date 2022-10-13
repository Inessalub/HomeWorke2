// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine() ?? "0");

if(a == b*b) 
{
    Console.WriteLine("Число является квадратом другого");
}
else
{
    Console.WriteLine("Число не является квадратом другого");
}