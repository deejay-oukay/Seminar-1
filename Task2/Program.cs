Console.Write("Введите значение числа А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("Max = a = " + a);
else if (a < b)
    Console.WriteLine("Max = b = " + b);
else
    Console.WriteLine("Max = a = b = " + b);