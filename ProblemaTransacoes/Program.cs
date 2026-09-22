using ProblemaTransacoes;

static List<string> InvalidTransactions(string[] transactions)
{
    List<Transacao> transacoes = new List<Transacao>();

    for (int i = 0; i < transactions.Length; i++)
    {
        string[] partes = transactions[i].Split(',');
        string nomeDoComprador = partes[0];
        int minutosDaCompra = int.Parse(partes[1]);
        int valorDaCompra = int.Parse(partes[2]);
        string cidadeDaCompra = partes[3];

        transacoes.Add(new Transacao(nomeDoComprador, minutosDaCompra, valorDaCompra, cidadeDaCompra));
    }

    // Mudamos para HashSet para evitar duplicidade de objetos de forma nativa e eficiente
    // 🚫 Sem Duplicados: Garante a unicidade dos elementos de forma nativa.
    HashSet<Transacao> transacoesInvalidas = new HashSet<Transacao>();

    // 1ª Validação: Valor > 1000
    for (int i = 0; i < transacoes.Count; i++)
    {
        if (transacoes[i].ValorDaCompra > 1000)
        {
            transacoesInvalidas.Add(transacoes[i]);
        }
    }

    // 2ª Validação: Mesmos nomes, cidades diferentes em menos de(ou igual a) 60 min
    for (int i = 0; i < transacoes.Count - 1; i++)
    {
        for (int j = i + 1; j < transacoes.Count; j++)
        {
            if (transacoes[i].Nome.Equals(transacoes[j].Nome) &&
                transacoes[i].CidadeDaCompra != transacoes[j].CidadeDaCompra && 
                 Math.Abs(transacoes[j].MinutosDaCompra - transacoes[i].MinutosDaCompra) <= 60)
            {
                transacoesInvalidas.Add(transacoes[i]);
                transacoesInvalidas.Add(transacoes[j]);
            }
        }

    }
    List<string> resultado = new List<string>();

    foreach (var item in transacoesInvalidas)
    {
        resultado.Add($"{item.Nome},{item.MinutosDaCompra},{item.ValorDaCompra},{item.CidadeDaCompra}");
    }

    // Meu pensamento inicial:
    // Console.Write("[");
    // foreach (var item in resultado)
    // {
    //    if (item.Equals(resultado.Last()))
    //    {
    //        Console.Write($""" "{item}" """);
    //    } else
    //    {
    //        Console.Write($""" "{item}", """);
    //    }
    //  }
    // Console.Write("]");
    // Console.WriteLine();


    // IEnumerable: Apenas leitura, item por item (com foreach ou Join).
    /* No C#, quando precisamos apenas "olhar" ou "passar" pelos dados (como em uma impressão ou um filtro rápido), 
     usamos IEnumerable. Quando precisamos manipular, adicionar ou guardar os dados, usamos List.*/

    // IMPRESSÃO FORMATADA ULTRA SIMPLIFICADA:
    // O string.Join coloca a vírgula exatamente ENTRE os itens, evitando o erro do Last()
    IEnumerable<string> itensFormatados = resultado.Select(item => $""" "{item}" """);
    Console.WriteLine($"[{string.Join(",", itensFormatados)}]");
    return resultado;
}

InvalidTransactions(["alice,20,800,mtv", "alice,50,100,beijing"]);
InvalidTransactions(["alice,20,800,mtv", "alice,50,1200,mtv"]);
InvalidTransactions(["alice,20,800,mtv", "bob,50,1200,mtv"]);