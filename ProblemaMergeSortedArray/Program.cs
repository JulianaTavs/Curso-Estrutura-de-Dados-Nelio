Solution solution = new Solution();
solution.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int j = n - 1;
        for (int i = nums1.Length - 1; i >= m; i--)
        {
            nums1[i] = nums2[j];
            j--;
        }
        Array.Sort(nums1);
        Console.WriteLine(string.Join(',', nums1));
    }
}