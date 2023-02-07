int GetNumberFromConsole()
{
    Console.WriteLine("Введите целое число:");
    return Convert.ToInt32(Console.ReadLine());
}

void Case(int a)
{
    int temp = a % 10;
    if (temp == 1) Console.WriteLine(a + " компьютер.");
    if (temp == 2 || temp == 3 || temp == 4) Console.WriteLine(a + " компьютера.");
    if (temp == 0 || temp == 5 || temp == 6 || temp == 7 || temp == 8 || temp == 9) Console.WriteLine(a + " компьютеров.");
}
int number = GetNumberFromConsole();
Case(number);