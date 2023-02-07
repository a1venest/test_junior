int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = GetNumberValue(minValue, maxValue);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] InitializateArray(int m)
{
    return new int[m];
}

int m = GetNumberFromConsole("Введите размерность массива: ");
int[] array = InitializateArray(m);
int[] arrayTwo = InitializateArray(m);
int maxValue = GetNumberFromConsole("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsole("Введите минимальное допустимое число в массиве:");
FillArray(array, minValue, maxValue);
FillArray(arrayTwo, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
PrintArray(arrayTwo);
Console.WriteLine();

var duplicates = array.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

var duplicates2 = arrayTwo.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

int[] arrayDupl = duplicates.ToArray();
int[] arrayDupl2 = duplicates2.ToArray();
int[] arrayDupl3 = arrayDupl.Concat(arrayDupl2).ToArray();

var duplicates3 = arrayDupl3.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

int[] finalArray = duplicates3.ToArray();

PrintArray(finalArray);

// 1,5 часа