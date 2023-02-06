string[] GetString()
{
    Console.WriteLine("Введите значения через пробел, по окончании ввода, нажмите Enter: ");
    return Console.ReadLine().Split(" ");
}
void NewInput(string[] arr)
{
    string newInput = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        newInput = newInput + arr[i] + ", ";
    }
    string lastPosition = arr[arr.Length - 1];
    Console.WriteLine(newInput + lastPosition + ".");
}

string[] input = GetString();
NewInput(input);