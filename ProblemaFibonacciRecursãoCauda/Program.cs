Solution solution = new Solution();
solution.ValorNaPosicao(6);

public class Solution
{
    public int ValorNaPosicao(int posicao)
    {
        int[] fibonacci = new int[10];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int i = 2; i < 10; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine(string.Join(',', fibonacci));

        Console.WriteLine(fibonacci[posicao]);
        return fibonacci[posicao];
    }
}