Solution solution = new Solution();
solution.DotProductTwoArrays([1, 0, 0, 2, 3], [0, 3, 0, 4, 0]);
solution.DotProductTwoArrays([0, 1, 0, 0, 0], [0, 1, 0, 0, 0]);
solution.DotProductTwoArrays([0, 1, 0, 0, 2, 0, 0], [1, 0, 0, 0, 3, 0, 4]);
public class Solution
{
    public int DotProductTwoArrays(int[] nums1, int[] nums2)
    {
        int soma = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            soma += nums1[i] * nums2[i];
        }
        Console.WriteLine(soma);
        return soma;
    }
}