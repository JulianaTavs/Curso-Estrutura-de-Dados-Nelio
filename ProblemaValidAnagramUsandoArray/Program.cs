static bool IsAnagram(string s, string t)
{
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    int k = 0;
    int f = 0;
    int[] countS = new int[26];
    int[] countT = new int[26];
    
    //For aninhado para contagem de quantas letras de cada tem na string s:
    for (int m = 0; m < alphabet.Length; m++)
    {
        for (int n = 0; n < s.Length; n++)
        {
            if (alphabet[m] == s[n])
            {
                countS[k]++;
            }
        }
        k++;
    }


    // For aninhado para percorrer cada caractere da string t e ver quantas letras de cada ela tem para comparar com a contagem da string s
    // e ver se elas são anagramas. 
    for (int o = 0; o < alphabet.Length; o++)
    {
        for (int p = 0; p < t.Length; p++)
        {
            if (alphabet[o] == t[p])
            {
                countT[f]++;
            }
        }
        f++;
    }
    // A forma como pensei:
    return string.Join(",", countS) == string.Join(",", countT);
    
    // E o que é ideal fazer:
    // for (int i = 0; i < 26; i++) {
    //   if (countS[i] != countT[i]) {
    //      return false;
    //   } 
    // }
    // return true;     
}

Console.WriteLine(IsAnagram("anagram", "nagaram"));
Console.WriteLine(IsAnagram("rat", "cat"));






