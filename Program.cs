void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
        if (i == array.Length - 1) Console.Write("]");
    }
}

string[] SortStringArray(string[] array)
{
    int i = 0;
    string element = string.Empty;
    while (i < array.Length)
    {
        if (array[i].Length > 3)
        {
            element = array[i];
            array = Array.FindAll(array, e => e != element).ToArray();
        }
        i++;
    }
    return array;
}

Console.WriteLine();
Console.WriteLine("~Computer~ Program initial...");

Console.WriteLine("~Computer~ Enter the elements of the future array " + Environment.NewLine
                + "           separating them with a Space.");
Console.WriteLine("~Computer~ Press Enter to finish typing.");
Console.Write("~Computer~ Enter any text: ");
string text = Console.ReadLine()!;
Console.WriteLine("~Computer~ Creating a string array...");
Console.WriteLine();

string[] textArray = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("~Computer~ Your string array: ");
PrintStringArray(textArray);
Console.WriteLine();

textArray = SortStringArray(textArray);
Console.WriteLine("~Computer~ Your sorted array: ");
PrintStringArray(textArray);
Console.WriteLine();

Console.WriteLine("~Computer~ End of the programm...");
Console.WriteLine();