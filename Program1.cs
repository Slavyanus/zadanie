//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("mix = ");
    Console.Write(b);
}
else if (a<b)
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.Write(a);
}
