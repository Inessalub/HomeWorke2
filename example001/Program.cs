// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели от 1 до 7");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a > 5 && a < 8)
{
    Console.WriteLine("Выходной день");
}
else if (a < 6)
{
    Console.WriteLine("Будний день");
}