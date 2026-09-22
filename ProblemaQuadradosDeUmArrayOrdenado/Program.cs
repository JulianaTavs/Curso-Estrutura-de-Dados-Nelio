
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.SortedArray([-4, -1, 0, 3, 10]);
        solution.SortedArray([-7, -3, 2, 3, 11]);
    }
}
public class Solution
{
    public int[] SortedArray(int[] nums)
    {
        int[] resultado = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            resultado[i] = (int)Math.Pow(nums[i], 2);
        }
        Array.Sort(resultado);


        // Só para eu ver os itens do array ordenados:
        Console.WriteLine(string.Join(',', resultado));
        
        return resultado;
    }

}