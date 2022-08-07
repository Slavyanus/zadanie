//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());


if (a>b & a>c)
{
    Console.Write("max = ");
    Console.Write(a);
}
else if (b>a & b>c)
{
    Console.Write("max = ");
    Console.Write(b);
}

else if (c>a & c>b)
{
    Console.Write("max = ");
    Console.Write(c);
}
