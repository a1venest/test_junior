int GetNumber()
{
    int temp = 0;
    while (temp < 1 || temp > 9)
    {
        Console.WriteLine("Введите число от 1 до 9, до котрого необходимо составить таблицу умножения:");
        temp = Convert.ToInt32(Console.ReadLine());
    }
    return temp;
}

int number = GetNumber();

string[] FillArray(int n)
{
    string[] temp = new string[n];

    for (int i = 0; i < n; i++)
    {
        temp[i] = "  " + (i + 1);
    }

    return temp;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == 0) Console.Write(" " + arr[i]);
        else Console.Write(arr[i]);
    }
}

string[] numbers = FillArray(number);

PrintArray(numbers);
Console.WriteLine();


void MultiplicationTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i);
        for (int j = 1; j <= n; j++)
        {
            if (i * j < 10)
                Console.Write("  " + i * j);
            else Console.Write(" " + i * j);
        }

        Console.WriteLine("");
    }
}

MultiplicationTable(number);

// час, так как сначала пытался сделать таблицу без ограничений по вводимому числу, но не нашел решение проблемы с пробелами.
