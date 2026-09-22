// RECURSÃO SIMPLES:

//Solution solution = new Solution();
//solution.ValorPosicao(8);
//public class Solution
//{
//    public int ValorPosicao(int posicao)
//    {
//        int resultado = FuncaoRecursiva(posicao);
//        Console.WriteLine($"Valor da posição {posicao}: {resultado}");

//        return resultado;
//    }

//    private int FuncaoRecursiva(int posicao)
//    {
//        if (posicao == 0)
//            return 0;
//        if (posicao == 1)
//            return 1;
//        return FuncaoRecursiva(posicao - 1) + FuncaoRecursiva(posicao - 2);
//    }

//}

// RECURSÃO DE CAUDA:

Solution solution = new Solution();
solution.ValorPosicao(8);
public class Solution
{
    public int ValorPosicao(int posicao)
    {
        if (posicao < 0)
            throw new ArgumentException("O valor da posição não pode ser negativo.");

        int resultado = FuncaoRecursivaCauda(posicao, 0, 1);
            Console.WriteLine($"Valor da posição {posicao}: {resultado}");

            return resultado;
        

    }

    private int FuncaoRecursivaCauda(int posicao, int atual, int proximo)
    {
        if (posicao == 0)
            return atual;

        return FuncaoRecursivaCauda(posicao - 1, proximo, atual + proximo);
    }

}