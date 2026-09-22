Solution solution = new Solution();
solution.numerosMaiores([7, 3, 8, 7, 5]);
public class Solution
{
    public List<int> numerosMaiores(List<int> numeros)
    {
        List<int> resultado = new List<int>();
        for (int i = 0; i < numeros.Count; i++)
        {
            int count = 0;
            foreach(int numero in numeros)
            {
                if (numero > numeros[i])
                {
                    count++;
                }
            }
            resultado.Add(count);
        }
        Console.WriteLine(string.Join(", ", resultado));
        return resultado;
    }
}