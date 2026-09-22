using System.Numerics;

Solution solution = new Solution();
Console.WriteLine(solution.FatorialDeCauda(1000));
public class Solution
{
    public BigInteger FatorialDeCauda(BigInteger n, BigInteger acumulador = default)
    {
        // Se for a primeira chamada, inicializa o acumulador com 1
        if (acumulador == 0) acumulador = 1; 
        
        if (n <= 1) return acumulador;
        return FatorialDeCauda(n - 1, acumulador * n);
    }
}
