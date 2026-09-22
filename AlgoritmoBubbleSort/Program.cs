Solution solution = new Solution();
solution.BubbleSort([20, 9, 86, -2, 16]);
public class Solution
{
    public int[] BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool houveTroca = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    houveTroca = true;
                }
            }
            if (houveTroca == false)
                break;
        }
        Console.WriteLine(string.Join(", ", array));
        return array;
    }
}