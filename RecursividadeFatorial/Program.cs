Solution solution = new Solution();
Console.WriteLine(solution.Fatorial(4));

public class Solution
{
    public int Fatorial(int n)
    {
        if (n == 0)
        {
            return 1; 
        }
        return n * Fatorial(n - 1);
    }
}