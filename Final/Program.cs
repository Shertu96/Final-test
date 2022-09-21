/*  
    Из имеющегося массива строк формировать новый массив из строк,
    длина которых меньше, либо равна 3 символам.
*/

string?[] FillArray(int length)
{
    string?[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void WriteArray(string?[] texts)
{
    foreach (string? text in texts)
    {
        Console.WriteLine(text);
    }
}

int NewArrayLength(string?[] array)
{
    int length = 0;
    foreach (string? text in array)
    {
        if (IsTextLessThanFour(text)) length++;
    }
    return length;
}

string?[] FillNewArray(string?[] oldArray, string?[] newArray)
{
    int j = 0;

    foreach (string? text in oldArray)
    {
        if (IsTextLessThanFour(text))
        {
            newArray[j] = text;
            j++;
        }
    }
    return newArray;
}

bool IsTextLessThanFour(string? text)
{
    if (text?.Length < 4) return true;

    return false;
}

int START_ARAY_LENGTH = 5;
string?[] array = FillArray(START_ARAY_LENGTH);
Console.WriteLine("-------Ваш-массив-------");
WriteArray(array);
Console.WriteLine("-------Новый-массив-------");
string?[] new_array = new string[NewArrayLength(array)];
WriteArray(FillNewArray(array, new_array));
