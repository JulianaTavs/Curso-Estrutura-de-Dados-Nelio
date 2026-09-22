Solution solution = new Solution();
solution.CompactarSequencia([1, 1, 1, 2, 3, 3, 1, 1]);
public class Solution
{
    public List<string> CompactarSequencia(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            return new List<string>();
        }

        List<string> resultado = FuncaoRecursiva(numeros, 1, 1, numeros[0], new List<string>());
        Console.WriteLine(string.Join(", ", resultado));
        return resultado;

        static List<string> FuncaoRecursiva(List<int> numeros, int indice, int contador, int numeroAtual, List <string> listaAcumuladora)
        {
            if (indice >= numeros.Count)
            {
                listaAcumuladora.Add($"{numeroAtual}x{contador}");
                return listaAcumuladora;
            }
            int proximoNumero = numeros[indice];

            if (proximoNumero == numeroAtual)
            {
                return FuncaoRecursiva(numeros, indice + 1, contador + 1, numeroAtual, listaAcumuladora);
            } else
            {
                listaAcumuladora.Add($"{numeroAtual}x{contador}");
                return FuncaoRecursiva(numeros, indice + 1, 1, proximoNumero, listaAcumuladora);
            }

        }
            
    }
}
