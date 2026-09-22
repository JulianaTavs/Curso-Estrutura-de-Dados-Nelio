
string cpfPuro = RemoveNonDigits("87409217293");
Console.WriteLine(cpfPuro);

string cpfPuro2 = RemoveNonDigits("874092172-93");
Console.WriteLine(cpfPuro2);

string cpfPuro3 = RemoveNonDigits("874.092.172-93");
Console.WriteLine(cpfPuro3);

static string RemoveNonDigits(string str)
{
    char[] array = str.ToArray();
    List<char> values = new List<char>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= '0' && array[i] <= '9')
        {
            values.Add(array[i]);
        }
    }
    return string.Concat(values);
     
}

// ou usando LINQ:

// static string RemoveNonDigits(string str)
//{
//    return new string(str.Where(char.IsDigit).ToArray());
//}

