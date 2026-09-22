using DesafioVendasDoDepartamento;
using System.Globalization;

Solution solution = new Solution();
solution.TotalSales([
"8349,14/09/2024,899.9,ESPORTE",
"4837,17/09/2024,530.0,VESTUARIO",
"15281,21/09/2024,1253.99,ESPORTE",
"15344,27/09/2024,1000.9,VESTUARIO",
"18317,04/10/2024,250.4,VESTUARIO",
"18972,11/10/2024,385.5,JARDINAGEM"
], "VESTUARIO");

public class Solution
{
    public double[] TotalSales(List<string> sales, string department)
    {
        List<Sale> vendas = new List<Sale>();

        for (int i = 0; i < sales.Count; i++)
        {
            string[] partes = sales[i].Split(',');
            Sale sale = new Sale();
            sale.Id = int.Parse(partes[0]);
            sale.Date = DateOnly.Parse(partes[1]);

            string valorComVirgula = partes[2].Replace('.', ',');
            sale.PrecoTotal = double.Parse(valorComVirgula);
            sale.Departamento = partes[3];
            vendas.Add(sale);
        }
        double count = 0;
        double total = 0;
        foreach(Sale venda in vendas)
        {
            if (department.Equals(venda.Departamento))
            {
                count++;
                total += venda.PrecoTotal;
            }
        }

        double[] resultado = new double[2];
        resultado[0] = count;
        resultado[1] = total;

        Console.WriteLine($"{resultado[0]} VENDAS");
        Console.WriteLine($"TOTAL = $ {resultado[1].ToString("F2", CultureInfo.InvariantCulture)}");
        return resultado;
    }
}