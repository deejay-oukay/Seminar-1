int number = 0;
string testNumber;
bool correct = false;
while(!correct)
    {
        Console.Write("Введите трёхзначное число: ");
        testNumber = Console.ReadLine().Trim();
        if (!int.TryParse(testNumber,out number))
            Console.Write("Вы ввели не число. ");
        else if ((number < 100) || (number > 999))
            Console.Write("Вы ввели нетрёхзначное число. ");
        else
            {
                correct = true;
                Console.WriteLine($"Последняя цифра: {testNumber[2]}");
                //компилятор не хочет выполнять предыдущую строку, если разместить её после цикла:
                //пишет: "error CS0165: Использование локальной переменной "testNumber", которой не присвоено значение."
            }
    }


