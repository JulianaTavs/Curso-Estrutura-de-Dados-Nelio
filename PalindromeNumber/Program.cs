Solution solution = new Solution();
Console.WriteLine(solution.IsPalindrome(-121));
public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Números negativos não são palíndromos (ex: -121 vira 121-)
        if (x < 0) return false;

        string xString = x.ToString();
        char[] array = xString.ToArray();
        string xInvertido = string.Join("", array.Reverse());

        return xString.Equals(xInvertido);
    }
}

//Solution solution = new Solution();
//Console.WriteLine(solution.IsPalindrome(123));

//public class Solution
//{
//    public bool IsPalindrome(int x)
//    {
//        if (x < 0) return false;

//        int original = x;
//        long invertido = 0;

//        while (x > 0)
//        {
//            int ultimoDigito = x % 10;
//            invertido = (invertido * 10) + ultimoDigito;
//            x /= 10;
//        }
//        return original == invertido;
//    }
//}