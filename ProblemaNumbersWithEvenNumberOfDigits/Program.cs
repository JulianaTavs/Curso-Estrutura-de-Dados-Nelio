Solution solution = new Solution();
solution.FindNumbers([12, 345, 2, 6, 7896]);
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int contador = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i].ToString().Length);

            if (nums[i].ToString().Length % 2 == 0)
            {
                contador++;
            }
        }
        return contador;
    }
}