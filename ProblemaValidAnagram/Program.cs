static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    char[] s2 = s.ToCharArray();
    char[] t2 = t.ToCharArray();

     Array.Sort(s2);
     Array.Sort(t2);

    return new string(s2) == new string(t2);
}

bool result = IsAnagram("anagram", "nagaram");
Console.WriteLine(result);

bool result2 = IsAnagram("rat", "car");
Console.WriteLine(result2);
