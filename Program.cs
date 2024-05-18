string[] EnterStringsToArray()
{
    Console.WriteLine("Введите количество строк: ");
    int count = int.Parse(Console.ReadLine());

    string[] workArray = new string[count];

    Console.WriteLine($"Введите {count} строк(у) (после ввода каждой нажмите ENTER):");
    for (int i = 0; i < count; i++)
    {
        workArray[i] = Console.ReadLine();
    }

    return workArray;
}

string[] CreatingArrayStringsLessThan3(string[] workArray)
{
    int count = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}

string PrintArray(string[] workArray)
{
    string arString = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        arString += $"\"{workArray[i]}\"";
        if (i < workArray.Length - 1)
        {
            arString += ", ";
        }
    }
    arString += "]";
    return arString;
}

string[] workArray = EnterStringsToArray();
string[] result = CreatingArrayStringsLessThan3(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(result);

Console.WriteLine(firstArray + " -> " + secondArray);