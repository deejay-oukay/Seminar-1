Console.Write("Введите значение числа А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа C: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Max = " + max);