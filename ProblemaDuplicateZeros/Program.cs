
Solution solution = new Solution();
solution.DuplicateZeros([1, 0, 2, 3, 0, 4, 5, 0]);
public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int j = 0;
        int[] output = new int[arr.Length];

        for (int i = 0; j < arr.Length; i++)
        {
            output[j] = arr[i];
            
            if (arr[i] == 0 && j < arr.Length - 1)
            {
                output[j + 1] = 0;
                j++;
            }
            j++;
        }

        Array.Copy(output, arr, output.Length);

        Console.WriteLine(string.Join(",", arr));
    }
}