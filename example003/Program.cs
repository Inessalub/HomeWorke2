// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите число N от 1 до 4: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (N == 1)
{
    Console.WriteLine("x>0; y>0");
}
if (N == 2)
{
    Console.WriteLine("x<0; y>0");
}
if (N == 3)
{
    Console.WriteLine("x<0; y<0");
}
if (N == 4)
{
    Console.WriteLine("x>0; y<0");
}