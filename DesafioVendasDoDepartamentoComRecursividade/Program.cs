using System.Globalization;
using System;
using System.Collections.Generic;

Solution solution = new Solution();
solution.TotalSales([
 "8349,14/09/2024,899.9,ESPORTE", 
 "4837,17/09/2024,530.0,VESTUARIO",   
 "15281,21/09/2024,1253.99,ESPORTE",
 "15344,27/09/2024,1000.9,VESTUARIO",   
 "18317,04/10/2024,250.4,VESTUARIO",   
 "18972,11/10/2024,385.5,JARDINAGEM"],
 "VESTUARIO"
);
public class Solution
{
    public double[] TotalSales(List<string> sales, string department)
    {
        double[] resultado = FuncaoRecursiva(sales, department, 0, 0, 0);
        Console.WriteLine($"{resultado[0]} VENDAS");
        Console.WriteLine($"TOTAL = $ {resultado[1].ToString("F2", CultureInfo.InvariantCulture)}");

        return resultado;
    }
    public double[] FuncaoRecursiva(List<string> sales, string department, int indice, double contador, double total)
    {
        if (indice >= sales.Count)
        {
            return new double[] { contador, total };
        }

        string[] partes = sales[indice].Split(',');
        double valor = double.Parse(partes[2], CultureInfo.InvariantCulture);
        string departamento = partes[3];

        if (departamento.Equals(department, StringComparison.OrdinalIgnoreCase))
        {
            contador++;
            total += valor;
        }
        return FuncaoRecursiva(sales, department, indice + 1, contador, total);
    }
}