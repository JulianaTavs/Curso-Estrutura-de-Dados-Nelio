Solution solution = new Solution();
Console.WriteLine(solution.Soma(5));
public class Solution
{
    // *** Usando a própria função para fazer recursividade: ***
    public int Soma(int n)
    {
        if (n == 0)
        {
            return 0;
        } 
        return n + Soma(n - 1);
        
    }

    // *** Sem usar a função para fazer recursividade: ***

    //public int Soma(int n)
    //{
    //    int soma = 0;

    //    while (n >= 0)
    //    {
    //        soma += n;
    //        n--;
    //    }
    //    Console.WriteLine(soma);
    //    return soma;
    //}
}
