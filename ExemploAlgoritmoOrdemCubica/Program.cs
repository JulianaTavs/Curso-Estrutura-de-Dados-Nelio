Solution solution = new Solution();

try
{
    solution.MultiplicacaoMatrizes(
    new int[,] 
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    new int[,]
    {
        { 7, 8 },
        { 9, 10 },
        { 11, 12 }
    }
    );
} catch (ArgumentException ex)
{
    Console.WriteLine($"Erro de validação: {ex.Message}");
}
catch (Exception ex)
{
    // Opcional: captura qualquer outro erro inesperado
    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
}
public class Solution
{
    public int[,] MultiplicacaoMatrizes(int[,] matrizA, int[,] matrizB)
    {
        if (matrizA == null || matrizB == null)
        {
            throw new ArgumentNullException("As matrizes não podem ser nulas.");
        }

        if (matrizA.GetLength(1) != matrizB.GetLength(0))
        {
            throw new ArgumentException("O número de colunas da matriz A deve ser igual ao número de linhas da matriz B.");
        }

        int[,] matrizC = new int[matrizA.GetLength(0), matrizB.GetLength(1)]; // new int[2, 2];
        
        for (int i = 0; i < matrizA.GetLength(0); i++) // i < 2
        {
            for ( int j = 0; j < matrizB.GetLength(1); j++) // j < 2
            {
                int count = 0;
                for (int k = 0; k < matrizB.GetLength(0); k++) // k < 3
                {
                    count += matrizA[i, k] * matrizB[k, j];
                }
                matrizC[i, j] = count;
            }
        }
        return matrizC;
    }
}