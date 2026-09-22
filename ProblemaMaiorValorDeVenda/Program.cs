using ProblemaMaiorValorDeVenda;
using System.Globalization;
using System.Text.Json;

string jsonString = """
[
  {
    "name": "Barry Allen",
    "amount": 18196.0
  },
  {
    "name": "Logan",
    "amount": 4255.0
  },
  {
    "name": "Maria",
    "amount": 10298.0
  },
  {
    "name": "Ana",
    "amount": 26485.0
  },
  {
    "name": "Aurora",
    "amount": 19982.0
  },
  {
    "name": "Noah",
    "amount": 15820.0
  },
  {
    "name": "Leo",
    "amount": 21412.0
  },
  {
    "name": "Alex",
    "amount": 12000.0
  }
]
""";

// Configuração para ignorar a diferença entre maiúsculas e minúsculas
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

Vendedor[] vendedoresArray = JsonSerializer.Deserialize<Vendedor[]>(jsonString, options);

// Só para ver cada objeto do array(do tipo Vendedor) sendo impresso:
foreach (var item in vendedoresArray)
{
    Console.WriteLine($"Name: {item.Name} | Amount: {item.Amount.ToString("F1", CultureInfo.InvariantCulture)}");
}

Solution solution = new Solution();
solution.MaiorValorDeVenda(vendedoresArray);
public class Solution
{
    public Vendedor MaiorValorDeVenda(Vendedor[] vendedores)
    {
        if (vendedores == null || vendedores.Length == 0) return null;

        /*
         Mudei de new Vendedor() para null na inicialização da variável vendedor.
         Como o primeiro item do loop sempre será maior que decimal.MinValue, criar 
         um objeto vazio na memória com new seria um desperdício, já que ele será 
         substituído logo no primeiro passo do foreach:
         */
        Vendedor vendedor = null;
        decimal amount = decimal.MinValue;
        
        foreach (var item in vendedores)
        {
            if (item.Amount > amount)
            {
                vendedor = item;
                amount = item.Amount;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"O(A) vendedor(a) com maior venda foi o(a) {vendedor.Name} que vendeu o valor de {vendedor.Amount.ToString("F1", CultureInfo.InvariantCulture)}");

        return vendedor;
    }
}
