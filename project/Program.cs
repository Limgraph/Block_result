//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекции.
Console.Clear();
string[] mass = new string[5] { "раз", "два", "три", "четыре", "=)" };

string[] GetResult(string[] mass)
{
    string[] temp = new string[mass.Length];
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            temp[count] = mass[i];
            count++;
        }
    }
    string[] result = new string[count];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = temp[i];
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
}

string[] threeCharacters = GetResult(mass);
PrintArray(threeCharacters);