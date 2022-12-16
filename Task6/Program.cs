Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int test = number/2;
if ((test * 2) == number)
    Console.WriteLine("Число " + number + " является чётным");
else
    Console.WriteLine("Число " + number + " НЕ является чётным");
