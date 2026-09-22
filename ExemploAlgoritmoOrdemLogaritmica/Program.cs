Solution solution = new Solution();
Console.WriteLine(solution.PosicaoElementoBinaria(39, [7, 13, 20, 25, 28, 31, 35, 39, 40, 45, 46, 48, 57, 59, 63, 71]));
Console.WriteLine(solution.PosicaoElementoBinaria(46, [7, 13, 20, 25, 28, 31, 35, 39, 40, 45, 46, 48, 57, 59, 63, 71]));
Console.WriteLine(solution.PosicaoElementoBinaria(22, [7, 13, 20, 25, 28, 31, 35, 39, 40, 45, 46, 48, 57, 59, 63, 71]));

public class Solution
{
    //Após decidir a metade correta do vetor, esse algoritmo faz uma busca linear:

    //public int PosicaoElemento(int valorElemento, int[] vetor)
    //{
    //    // Proteção para vetor nulo ou vazio
    //    if (vetor == null || vetor.Length == 0)
    //        return -1;

    //    int metade = vetor.Length / 2;

    //    if (valorElemento < vetor[metade])
    //    {
    //        for (int i = 0; i < metade; i++)
    //        {
    //            if (vetor[i] == valorElemento)
    //            {
    //                return i;
    //            }
    //        }

    //    }
    //    else if (valorElemento >= vetor[metade])
    //    {
    //        for (int i = metade; i < vetor.Length; i++)
    //        {
    //            if (vetor[i] == valorElemento)
    //            {
    //                return i;
    //            }
    //        }
    //    }
    //    // Retorna -1 se o elemento não estiver presente no vetor
    //    return -1;
    //}

    // Busca Binária Real:
    //public int PosicaoElementoBinaria(int valorElemento, int[] vetor)
    //{
    //    if (vetor == null || vetor.Length == 0)
    //        return -1;

    //    int inicio = 0;
    //    int fim = vetor.Length - 1;

    //    while (inicio <= fim)
    //    {
    //        int meio = inicio + (fim - inicio) / 2;

    //        if (valorElemento == vetor[meio])
    //            return meio;

    //        if (valorElemento < vetor[meio])
    //            fim = meio - 1;
    //        else
    //            inicio = meio + 1;
    //    }
    //    return -1;
    //}

    // Busca Binária com Recursividade de Cauda:

    public int PosicaoElementoBinaria(int valorElemento, int[] vetor)
    {
        if (vetor == null || vetor.Length == 0)
            return -1;

        int resultado = FuncaoRecursiva(valorElemento, vetor, 0, vetor.Length - 1);
        return resultado;
    }
    private int FuncaoRecursiva(int valorElemento, int[] vetor, int inicio, int fim)
    {
        if (inicio > fim)
            return -1;

        int meio = inicio + (fim - inicio) / 2;

        if (valorElemento == vetor[meio])
            return meio;

        if (valorElemento < vetor[meio])
            fim = meio - 1;
        else
            inicio = meio + 1;
        return FuncaoRecursiva(valorElemento, vetor, inicio, fim);
    }
}