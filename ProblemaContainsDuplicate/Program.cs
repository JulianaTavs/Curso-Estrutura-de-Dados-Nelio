Solution solution = new Solution();
solution.ContainsDuplicate([1, 2, 3, 1]);
Solution solution1 = new Solution();
solution1.ContainsDuplicate([1, 2, 3, 4]);
Solution solution2 = new Solution();
solution2.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);

public class Solution
{   public bool ContainsDuplicate(int[] nums)
    {

        // *** Usando LINQ ***:

        Console.WriteLine(nums.Distinct().Count() < nums.Length);
        return nums.Distinct().Count() < nums.Length;
        
        // *** Usando HashSet ***:
        //HashSet<int> valoresUnicos = new HashSet<int>();

        //foreach (int num in nums)
        //{
        //    if (valoresUnicos.Contains(num))
        //    {
        //        return true;
        //    } else
        //    {
        //        valoresUnicos.Add(num);
        //    }
        //}
        //return false;

        // *** Usando força bruta(loops aninhados) ***:
        //bool ehDuplicado = false;

        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] == nums[j])
        //        {
        //            ehDuplicado = true;
        //            return ehDuplicado;
        //        }
        //    }
        //}
        //Console.WriteLine($"[{string.Join(',', nums)}]: " + ehDuplicado);

        //return ehDuplicado;
    }
}
