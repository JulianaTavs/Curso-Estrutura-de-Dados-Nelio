using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Estrutura de teste: [ 1, 2, [ 3, 4, [ 5 ] ], 6, [ 7, 8 ] ]
        var estrutura = new List<object>
        {
            1,
            2,
            new List<object> { 3, 4, new List<object> { 5 } },
            6,
            new List<object> { 7, 8 }
        };

        int resultado = SomarEstruturaAninhada(estrutura);
        Console.WriteLine($"Soma total: {resultado}"); // Deve imprimir 36
    }

    public static int SomarEstruturaAninhada(List<object> lista)
    {
       int soma = 0;
       foreach (object item in lista)
       {
            if (item is int numero)
            {
                soma += numero;
            } else if (item is List<object> sublista)
            {
                soma += SomarEstruturaAninhada(sublista);
            }
       }
        Console.WriteLine(soma); // só pra ver o que o método vai retornando.
        return soma;
    }
}