Solution solution = new Solution();
Console.WriteLine(solution.RomanToInt("III"));
Console.WriteLine(solution.RomanToInt("LVIII"));
Console.WriteLine(solution.RomanToInt("MCMXCIV"));

// Meu raciocínio:
//public class Solution
//{
//    public int RomanToInteger(string s)
//    {
//        int acumulador = 0;
//        int i = 0;
//        while (i < s.Length - 1)
//        {
//            if (s[i] == 'I')
//            {
//                if (s[i + 1] == 'V')
//                {
//                    acumulador += 4;
//                    i = i + 2;
//                } else if (s[i + 1] == 'X')
//                {
//                    acumulador += 9;
//                    i = i + 2;
//                } else
//                {
//                    acumulador += 1;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                }
//            } else if (s[i] == 'X')
//            {
//                if (s[i + 1] == 'L')
//                {
//                    acumulador += 40;
//                    i = i + 2;
//                } else if (s[i + 1] == 'C')
//                {
//                    acumulador += 90;
//                    i = i + 2;
//                } else
//                {
//                    acumulador += 10;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                }
//            } else if (s[i] == 'C')
//            {
//                if (s[i + 1] == 'D')
//                {
//                    acumulador += 400;
//                    i = i + 2;
//                } else if (s[i + 1] == 'M')
//                {
//                    acumulador += 900;
//                    i = i + 2;
//                }
//                else
//                {
//                    acumulador += 100;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                }
//            } else
//            {
//                if (s[i] == 'V')
//                {
//                    acumulador += 5;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                } else if (s[i] == 'L')
//                {
//                    acumulador += 50;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                } else if (s[i] == 'D')
//                {
//                    acumulador += 500;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                }
//                else
//                {
//                    acumulador += 1000;
//                    i++;
//                    if (i == s.Length - 1)
//                    {
//                        char last = s[s.Length - 1];
//                        if (last == 'I') acumulador += 1;
//                        else if (last == 'V') acumulador += 5;
//                        else if (last == 'X') acumulador += 10;
//                        else if (last == 'L') acumulador += 50;
//                        else if (last == 'C') acumulador += 100;
//                        else if (last == 'D') acumulador += 500;
//                        else if (last == 'M') acumulador += 1000;

//                        return acumulador;
//                    }
//                }
//            }
//        }
//        return acumulador;
//    }
//}
public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int valorAtual = ObterValor(s[i]);

            if (i < s.Length - 1 && valorAtual < ObterValor(s[i + 1]))
            {
                total -= valorAtual;
            }
            else
            {
                total += valorAtual;
            }
        }

        return total;
    }

    private int ObterValor(char c) => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };
}
