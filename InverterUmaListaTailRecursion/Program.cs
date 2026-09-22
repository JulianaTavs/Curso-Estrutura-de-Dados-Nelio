Solution solution = new Solution();
solution.InverterLista([10, 20, 30, 40]);

public class Solution
{
    public List<int> InverterLista(List<int> numeros)
    {
        List<int> numerosInvertidos = FuncaoRecursiva(numeros, numeros.Count - 1, new List<int>());
        Console.WriteLine(string.Join(", ", numerosInvertidos));
        return numerosInvertidos;
    }
    private List<int> FuncaoRecursiva(List<int> numeros, int indice, List<int> listaAcumuladora)
    {
        if (indice < 0)
        {
            return listaAcumuladora;
        }
        listaAcumuladora.Add(numeros[indice]);
        return FuncaoRecursiva(numeros, indice - 1, listaAcumuladora);
    }
}
