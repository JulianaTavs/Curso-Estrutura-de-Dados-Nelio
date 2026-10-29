namespace DesafioListaEncadeada
{
    internal class Node
    {
        public Task Tarefa { get; set; }
        public Node? Next { get; set; }

        public Node(Task tarefa)
        {
            Tarefa = tarefa;
        }
    }
}
