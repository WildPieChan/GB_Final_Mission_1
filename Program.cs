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

string RandomText()
{   
    Random res = new Random();
    string alphanumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
    string text = "";
    int textLenght = new Random().Next(2, 10);
    int wordLenght = 0;
    for (int i = 0; i < textLenght; i++)
    {
        wordLenght = new Random().Next(1, 10);
        for (int j = 0; j < wordLenght; j++)
        {
            int symbol = res.Next(alphanumeric.Length);
            text = text + alphanumeric[symbol];
        }
        if (i < textLenght - 1) text += " ";
    }

    return text;
}

bool YesOrNo(string answer)
{
    if (answer == "N" | answer == "n" | answer == "Y" | answer == "y") return true;
    else return false;
}

string[] SortStringArray(string[] array)
{
    int i = 0;
    string element = string.Empty;
    while (i < array.Length)
    {
        int wordLength = 0;
        foreach (char c in array[i]) wordLength++;
        if (wordLength > 3)
        {
            element = array[i];
            int index = Array.IndexOf(array, element);
            array = array.Where((e, j) => j != index).ToArray();
            i--;
        }
        i++;
    }
    return array;
}

Console.WriteLine();
Console.WriteLine("~Computer~ Program initial...");

Console.WriteLine("~Computer~ Do you want create a random text?");
Console.Write("~Human~ Y/N: ");
bool check = false;
string answer = string.Empty;
while (!check)
{
    int i = 0;
    if (i > 0)
    {
        Console.Write("~Computer~ Enter \"N\" or \"Y\": ");
    }
    answer = Console.ReadLine()!;
    check = YesOrNo(answer);
}

string text = string.Empty;
if (answer == "n" | answer == "N")
{
    Console.WriteLine("~Computer~ Enter the elements of the future array " + Environment.NewLine
                    + "           separating them with a Space.");
    Console.WriteLine("~Computer~ Press Enter to finish typing.");
    Console.Write("~Human~ Enter any text: ");
    text = Console.ReadLine()!;
} else text = RandomText();


Console.WriteLine("~Computer~ Creating a string array...");
Console.WriteLine();

string[] textArray = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.Write("~Computer~ Your string array: ");
PrintStringArray(textArray);
Console.WriteLine();

textArray = SortStringArray(textArray);
Console.Write("~Computer~ Your sorted array: ");
PrintStringArray(textArray);
Console.WriteLine();

Console.WriteLine("~Computer~ End of the programm...");
Console.WriteLine();