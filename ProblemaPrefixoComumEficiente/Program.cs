static string LongestCommonPrefix(string[] v)
{
    if (v.Length == 0 || v == null) return "";
    if (v.Length == 1) return v[0];

    Array.Sort(v);

    string first = v[0];
    string last = v[v.Length - 1];

    int i = 0;
    while (i < first.Length && i < last.Length && first[i] == last[i]) // while ( i < Math.Min(first.Length, last.Length) && first[i] == last[i])
    {
        i++;
    }
    
    return first.Substring(0, i); // ou: last.Substring(0, i);  <--Tanto faz, as letras vão ser as mesmas pq é a parte igual
                                  // das 2 strings comparadas.
}

Console.WriteLine($""" "{LongestCommonPrefix(["flowers", "flow", "flight"])}" """);
Console.WriteLine($""" "{LongestCommonPrefix(["dog", "racecar", "car"])}" """);
Console.WriteLine($""" "{LongestCommonPrefix(["programmatically", "programmatic", "programmer"])}" """); // "programm"
Console.WriteLine($""" "{LongestCommonPrefix(["interspecies", "interstellar", "interstate"])}" """); // "inters"
Console.WriteLine($""" "{LongestCommonPrefix(["throne", "throne", "throne"])}" """); // "throne"
Console.WriteLine($""" "{LongestCommonPrefix(["apple", "ape", "april"])}" """); // "ap"
Console.WriteLine($""" "{LongestCommonPrefix([""])}" """);