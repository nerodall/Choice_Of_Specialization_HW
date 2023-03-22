
int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string[] InpuntArray(int sizeArray)
{
    string[] array = new string[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}


string[] LessThanThreeArray(string[] array)
{
    string[] resultArray = new string[array.Length];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            {
                resultArray[j] = array[i];
                j++;
            }
        }
    }

    return resultArray;
}


int sizeArray = InputInt("Введите размер массива");
string[] array = InpuntArray(sizeArray);
System.Console.WriteLine("Полученный массив");
PrintArray(array);
string[] resultArray = LessThanThreeArray(array);
System.Console.WriteLine("Новый массив с элементами, длина которых меньше либо равна 3 символа");
PrintArray(resultArray);