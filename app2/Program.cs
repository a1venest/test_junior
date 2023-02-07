decimal GetNumberFromConsole()
{
    Console.WriteLine("Введите десятичную дробь:");
    return Convert.ToDecimal(Console.ReadLine());
}

decimal Rounding(decimal a)
{
    decimal temp = Math.Round(a) % 10;
    if (temp == 0 || temp == 5)
    {
        a = Math.Round(a);
    }
    if (temp == 1 || temp == 2)
    {
        a = Math.Round(a - temp);
    }
    if (temp == 3 || temp == 4 || temp == 6 || temp == 7)
    {
        a = Math.Round(a - temp + 5);
    }
    if (temp == 8 || temp == 9)
    {
        a = Math.Round(a - temp + 10);
    }
    return a;
}

decimal number = GetNumberFromConsole();
Console.WriteLine(Rounding(number));

// 30 минут