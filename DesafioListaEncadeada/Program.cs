using DesafioListaEncadeada;
using MinhasTarefas = DesafioListaEncadeada.Task;

TaskList listaDeTarefas = new TaskList();

MinhasTarefas tarefa1 = new MinhasTarefas(1, "Revisando OOP", TaskType.Trabalho, Status.Pendente);
MinhasTarefas tarefa2 = new MinhasTarefas(2, "Pilates", TaskType.Saude, Status.Pendente);
MinhasTarefas tarefa3 = new MinhasTarefas(3, "Organizar sala", TaskType.Casa, Status.Concluida);
MinhasTarefas tarefa4 = new MinhasTarefas(4, "Estruturas de Dados Avançadas", TaskType.Trabalho, Status.Pendente);

listaDeTarefas.AddToList(tarefa1);
listaDeTarefas.AddToList(tarefa2, PositionToAddTask.INICIO);
listaDeTarefas.AddToList(tarefa3, PositionToAddTask.MEIO);
listaDeTarefas.AddToList(tarefa4);

Console.WriteLine("------------------------IMPRIMINDO TAREFAS EXISTENTES NA LISTA: ----------------------");

List<Node> nodes = listaDeTarefas.GetTasks();
foreach (Node item in nodes)
{
    Console.WriteLine(item.Tarefa);
}

Console.WriteLine("---------------------------IMPRIMINDO O TAMANHO DA LISTA: ---------------------------");

Console.WriteLine($"Tamanho da lista de tarefas: {listaDeTarefas.GetListSize()}");

Console.WriteLine("----------------------------- LISTA POR TIPO: TRABALHO ------------------------------");

List<Node> listaDeNos = listaDeTarefas.GetListByType(TaskType.Trabalho);

foreach (var item in listaDeNos)
{
    Console.WriteLine(item.Tarefa);
}

Console.WriteLine("----------------------------- TAREFA ENCONTRADA PELO ID: -----------------------------");

// Quero ver uma forma de se o retorno for null do método GetTaskById, não aparecer um erro de exceção de nulo:
Node no = listaDeTarefas.GetTaskById(1);

if (no == null)
{
    Console.WriteLine("Lista vazia ou id não existente na lista.");
}
else
{
    Console.WriteLine(no.Tarefa);
}

Console.WriteLine("----------------------------- DELETANDO TAREFA PELO ID: -----------------------------");

Node deletado = listaDeTarefas.DeleteTaskById(1);

if (deletado == null)
{
    Console.WriteLine($"Tarefa não encontrada pelo id informado.");
}else
{
    Console.WriteLine($"Tarefa deletada: \n{deletado.Tarefa}");

}

Console.WriteLine("----------------------------- CONCLUINDO TAREFA PELO ID: -----------------------------");

Node tarefaConcluida = listaDeTarefas.SetTaskToComcluded(5);

if (tarefaConcluida == null)
{
    Console.WriteLine($"Tarefa não encontrada pelo id informado.\n");
}
else
{
    Console.WriteLine($"Tarefa concluída: \n{tarefaConcluida.Tarefa}");
}

Console.WriteLine("----------------------------- EDITANDO TAREFA PELO ID: -----------------------------");

Node tarefaEditada = listaDeTarefas.EditTask2(2, descricao: "Pilates 2", tipo: TaskType.Casa, status: Status.Concluida);

if (tarefaEditada == null)
{
    Console.WriteLine($"Tarefa não encontrada pelo id informado.\n");
}
else
{
    Console.WriteLine($"Tarefa editada: \n{tarefaEditada.Tarefa}");
}
