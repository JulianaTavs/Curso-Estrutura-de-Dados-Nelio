Solution solution = new Solution();
solution.InverterString("GEDOP");
public class Solution
{
    public string InverterString(string original)
    {
        string invertida = FuncaoRecursiva(original, original.Length - 1, "");
        Console.WriteLine(invertida);
        return invertida;
    }
    private string FuncaoRecursiva(string original, int indice, string acumulador)
    {
        if (indice < 0)
        {
            return acumulador;
        }

        char novaLetra = original[indice];
        return FuncaoRecursiva(original, indice - 1, acumulador + novaLetra);
    }
}