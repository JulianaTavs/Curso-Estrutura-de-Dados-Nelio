using ListaDuplamenteEncadeada;

DoublyLinkedList<int> listaDuplamenteEncadeada = new DoublyLinkedList<int>();

Console.WriteLine("Adicionando elemento no final da lista duplamente encadeada:\n");
listaDuplamenteEncadeada.AddAtTheEnd(7);
listaDuplamenteEncadeada.AddAtTheEnd(8);
listaDuplamenteEncadeada.AddAtTheEnd(9);
listaDuplamenteEncadeada.AddAtTheEnd(10);

List<Node<int>> lista = listaDuplamenteEncadeada.PrintDoublyLinkedList();
foreach (Node<int> item in lista)
{
    Console.WriteLine($"{item}");
    Console.WriteLine("-------------------------------------");
}

Node<int> tail = listaDuplamenteEncadeada.PrintTheListTail();
Console.WriteLine($"A cauda da lista é: {tail.Value}");
Console.WriteLine("-------------------------------------");
//listaDuplamenteEncadeada.ClearList();

Console.WriteLine($"A lista está vazia? {listaDuplamenteEncadeada.IsEmpty()}\nTamanho da lista: {listaDuplamenteEncadeada.GetSize()}");
Console.WriteLine("-------------------------------------");


if (listaDuplamenteEncadeada.PrintDoublyLinkedList() == null)
    Console.WriteLine("A lista está vazia.");
else
{
    foreach (Node<int> item in listaDuplamenteEncadeada.PrintDoublyLinkedList())
    {
        Console.WriteLine($"{item}");
        Console.WriteLine("-------------------------------------");
    }
}

Console.WriteLine("Obtendo elemento em uma posição específica:");
Node<int> noEspecifico = listaDuplamenteEncadeada.GetElementAtAPosition(3);
if (noEspecifico == null)
{
    Console.WriteLine("Elemento nulo");
} else
{
    Console.WriteLine(noEspecifico);
}

Console.WriteLine("Adicionando elemento em uma posição específica.");
Console.WriteLine("PS: Se a posição passada como argumento for inválida, o programa encerra sem adicionar nenhum elemento.");
Node<int> node = new Node<int>(1);
listaDuplamenteEncadeada.AddElementAtPosition(4, node);

if (listaDuplamenteEncadeada.PrintDoublyLinkedList() == null)
    Console.WriteLine("A lista está vazia.");
else
{
    foreach (Node<int> item in listaDuplamenteEncadeada.PrintDoublyLinkedList())
    {
        Console.Write($"{item.Value} ");
    }
}
Console.WriteLine();
Console.WriteLine("Obtendo posição de um elemento:");
int posicao = listaDuplamenteEncadeada.ObterPosicaoElemento(7);
Console.WriteLine($"Posição do elemento 7: {posicao}");
int posicao2 = listaDuplamenteEncadeada.ObterPosicaoElemento(8);
Console.WriteLine($"Posição do elemento 8: {posicao2}");
int posicao3 = listaDuplamenteEncadeada.ObterPosicaoElemento(9);
Console.WriteLine($"Posição do elemento 9: {posicao3}");
int posicao4 = listaDuplamenteEncadeada.ObterPosicaoElemento(10);
Console.WriteLine($"Posição do elemento 10: {posicao4}");
int posicao5 = listaDuplamenteEncadeada.ObterPosicaoElemento(1);
Console.WriteLine($"Posição do elemento 1: {posicao5}");

Console.WriteLine("Removendo primeiro elemento da lista: ");
Node<int> removido = listaDuplamenteEncadeada.RemoveFirstElement();
Console.WriteLine($"Elemento removido: {removido.Value}");

if (listaDuplamenteEncadeada.PrintDoublyLinkedList() == null)
    Console.WriteLine("A lista está vazia.");
else
{
    foreach (Node<int> item in listaDuplamenteEncadeada.PrintDoublyLinkedList())
    {
        Console.Write($"{item.Value} ");
    }
}
Console.WriteLine();