Solution solution = new Solution();

Console.WriteLine(solution.FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
Console.WriteLine(solution.FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]));

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int[] contadorArray = new int[nums.Length];
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int contador = 0;

            if (nums[i] == 1)
            {
                contador++;
                contadorArray[k] += contador;
            } else
            {
                k++;
            }
        }
        return contadorArray.Max();
    }
}

