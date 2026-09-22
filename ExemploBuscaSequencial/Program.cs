Solution solution = new Solution();
Console.WriteLine(solution.Busca(32, [15, 82, 79, 32, 41, 28])); 
Console.WriteLine(solution.Busca(82, [15, 82, 79, 32, 41, 28])); 
Console.WriteLine(solution.Busca(22, [15, 82, 79, 32, 41, 28]));
Console.WriteLine(solution.Busca(15, []));
public class Solution
{
    public int Busca(int numero, List<int> ints)
    {
        if (ints == null || ints.Count == 0)
            return -2;
        if (ints.Contains(numero))
        {
            return ints.IndexOf(numero);
        }
        return -1;
    }
}
