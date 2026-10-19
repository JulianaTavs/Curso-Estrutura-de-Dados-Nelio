using MinhaLista = MinhaLinkedList.LinkedList<int>;

MinhaLista listaEncadeada = new MinhaLista();
listaEncadeada.AddAtEnd(10);

Console.WriteLine($"Head: {listaEncadeada.Head.Value}");
Console.WriteLine(listaEncadeada.Size);

listaEncadeada.AddAtEnd(20);
Console.WriteLine($"Head.Next: {listaEncadeada.Head.Next.Value}");
Console.WriteLine(listaEncadeada.Size);

listaEncadeada.AddAtEnd(30);
listaEncadeada.AddAtEnd(40);
listaEncadeada.PrintLinkedListElements();
//listaEncadeada.GetListSize();
//listaEncadeada.IsEmpty();
//listaEncadeada.ClearList();
//listaEncadeada.AddAtStart(0);
//listaEncadeada.PrintLinkedListElements();
//listaEncadeada.AddAtStart(-10);
//listaEncadeada.PrintLinkedListElements();
//listaEncadeada.GetElementByValue(0);
Console.WriteLine(listaEncadeada.GetElementAtPosition(2).Value);
listaEncadeada.AddAtPosition(0, 15);
listaEncadeada.PrintLinkedListElements();
Console.WriteLine($"Posição do elemento procurado: {listaEncadeada.ElementPosition(40)}");
Console.WriteLine($"O elemento procurado está na lista?: {listaEncadeada.IsItInTheList(40)}");


Console.WriteLine(listaEncadeada.RemoveFromASpecificPosition(0)?.Value.ToString() ?? "Lista vazia ou posição inválida.");
listaEncadeada.PrintLinkedListElements();

Console.WriteLine(listaEncadeada.RemoveSpecificElement(40));
listaEncadeada.PrintLinkedListElements();


