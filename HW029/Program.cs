int[] ReadArray(string msg)
{
    Console.WriteLine(msg);

    string Input = Console.ReadLine() ?? "0";
    string[] SubStrings = Input.Split(", ");

    List<int> Array = new List<int>();

    foreach (var SubString in SubStrings) 
    {
        Array.Add(int.Parse(SubString));
    }

    return Array.ToArray();
}

void PrintArray (int[] Array)
{
    string Line = "[";

    for (int i = 0; i < Array.Length; i++)
    {
        Line = Line + Array[i].ToString() + ", ";
    }

    Line = Line.Remove(Line.Length - 2);
    Line = Line + "]";
    Console.WriteLine(Line);
}

PrintArray(ReadArray("Введите последовательность чисел через запятую"));
