﻿Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int plus = 0; //сколько добавить к начальному значеню i в цикло (0 (по умолчанию) или 1)
Console.WriteLine("Чётные числа:");

int test = N/2;
if ((test*2) != N)  //если N - нечётный
    plus++;         //то далее стартовать будем не с него (-N), а со следующего числа (-N+1)

//шаг в цикле равен двум, т.к. каждое следующее чётное будет на 2 больше, чем предыдущее
for (int i=-N+plus; i <= N; i+=2)
    Console.WriteLine(i);
