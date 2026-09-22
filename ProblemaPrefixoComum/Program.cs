static string LongestCommonPrefix(string[] v)
{
    if (v == null || v.Length == 0 || v[0] == "") return "";
    if (v.Length == 1)
    {
        return v[0];
    }
    // Ordena strings pelo tamanho, do maior para o menor
    Array.Sort(v, (a, b) =>
    {
        Console.WriteLine($"Comparando {b} com {a}");
        return b.Length.CompareTo(a.Length);
    });

    // Ordenação manual:
    // for (int i = 0; i < v.Length - 1; i++)
    // {
    //    for (int j = 0; j < v.Length - 1 - i; j++)
    //    {
    //        if (v[j].Length < v[j + 1].Length)
    //        {
    //            string temp = v[j];
    //            v[j] = v[j + 1];
    //            v[j + 1] = temp;
    //        }
    //    }
    // }
    // string result = string.Join(",", v);
    // Console.WriteLine(result);

    List<string> listStrings = new List<string>();

    

    for (int i = 0; i < v.Length - 1; i++)
    {
        List<char> listResult = new List<char>();

        for (int j = 0; j < v[i + 1].Length; j++)
        {

            if (v[i].ElementAt(j) == v[i + 1].ElementAt(j))
            {
                listResult.Add(v[i].ElementAt(j));
            }
            else
            {
                break;
            }
        }
        listStrings.Add(new string(listResult.ToArray()));
    }
    string resultado = new string('a', 201);

    foreach (string a in listStrings)
    {
        if (a.Length < resultado.Length)
        {
            resultado = a;
        }
    }
    return resultado;
}

Console.WriteLine($""" "{LongestCommonPrefix(["flowers", "flow", "flight"])}" """);
Console.WriteLine($""" "{LongestCommonPrefix(["dog", "racecar", "car"])}" """);
Console.WriteLine($""" "{LongestCommonPrefix(["programmatically", "programmatic", "programmer"])}" """); // "programm"
Console.WriteLine($""" "{LongestCommonPrefix(["interspecies", "interstellar", "interstate"])}" """); // "inters"
Console.WriteLine($""" "{LongestCommonPrefix(["throne", "throne", "throne"])}" """); // "throne"
Console.WriteLine($""" "{LongestCommonPrefix(["apple", "ape", "april"])}" """); // "ap"
Console.WriteLine($""" "{LongestCommonPrefix([""])}" """);

