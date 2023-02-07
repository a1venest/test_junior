int GetNumberFromConsole()
{
    Console.WriteLine("Введите целое число:");
    return Convert.ToInt32(Console.ReadLine());
}

bool PrimeNumber(int a)
{
    for (int i = 2; i < a; i++)
    {
        if (a % i == 0) return false;
    }
    return true;
}
int number = GetNumberFromConsole();
Console.WriteLine(PrimeNumber(number));
// 7 минут