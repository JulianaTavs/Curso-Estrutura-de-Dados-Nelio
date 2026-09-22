Solution solution = new Solution();
solution.AgruparCaracteresRepetidos(['a', 'a', 'a', 'b', 'b', 'c', 'a', 'a']);

public class Solution
{
    public List<string> AgruparCaracteresRepetidos(List<char> caracteres)
    {
        List<string> resultado = FuncaoRecursiva(caracteres, 1, 1, new string[caracteres.Count], 0, caracteres[0]);
        Console.WriteLine(string.Join(", ", resultado));
        return resultado;
    }
    private List<string> FuncaoRecursiva(List<char> caracteres, int indiceListaChar, int contador, string[] arrayAcumulador, int indiceListaString, char letraAtual)
    {
        if (indiceListaChar >= caracteres.Count)
        {
            // Grava o último grupo processado no array
            arrayAcumulador[indiceListaString] = $"{letraAtual}{contador}";

            // Retorna apenas as posições preenchidas, ignorando os valores nulos
            return arrayAcumulador.Where(s => s != null).ToList();
        }

        char proximaLetra = caracteres[indiceListaChar];

        if (proximaLetra == letraAtual)
        {
            return FuncaoRecursiva(
                caracteres, 
                indiceListaChar + 1, 
                contador + 1, 
                arrayAcumulador, 
                indiceListaString, 
                letraAtual
            );
        }
        else
        {
            // Letra diferente: grava a letra anterior com sua contagem no array
            arrayAcumulador[indiceListaString] = $"{letraAtual}{contador}";

            // Avança para a próxima posição do array, reseta o contador para 1 e atualiza a letra
            return FuncaoRecursiva(
                caracteres,
                indiceListaChar + 1,
                1,
                arrayAcumulador,
                indiceListaString + 1,
                proximaLetra
            );

        }

    }
}
