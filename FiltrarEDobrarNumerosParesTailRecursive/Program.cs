Solution solution = new Solution();
solution.ProcessarPares([ 1, 2, 3 ,4, 5, 6]);

public class Solution
{
    public List<int> ProcessarPares(List<int> numeros)
    {
        List<int> resultado = ProcessarParesTail(numeros, 0, new List<int>());
        Console.WriteLine("Resultado: " + string.Join(", ", resultado));
        return resultado;
    }
    private List<int> ProcessarParesTail(List<int> numeros, int indice, List<int> acumulador)
    {
        if (indice >= numeros.Count)
        {
            return acumulador;
        }
        if (numeros[indice] % 2 == 0)
        {
            acumulador.Add(numeros[indice] * 2);
        }
        return ProcessarParesTail(numeros, indice + 1, acumulador);
    }
}