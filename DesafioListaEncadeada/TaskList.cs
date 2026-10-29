namespace DesafioListaEncadeada
{
    internal class TaskList
    {
        public Node? Head { get; private set; }
        public int Size { get; private set; }

        public TaskList()
        {
            Head = null;
            Size = 0;
        }

        public void AddToList(Task tarefa, PositionToAddTask posicao = PositionToAddTask.FIM)
        {
            Node newNode = new Node(tarefa);

            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }

            switch (posicao)
            {
                case PositionToAddTask.INICIO:
                    AddAtStart(newNode);
                    break;

                case PositionToAddTask.MEIO:
                    Console.WriteLine("Em qual posição você deseja inserir a tarefa?");
                    int index = int.Parse(Console.ReadLine());

                    AddInTheMiddle(newNode, index);
                    break;

                case PositionToAddTask.FIM:
                    AddInTheEnd(newNode);
                    break;

            }
        }
        private void AddAtStart(Node newNode)
        {
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }

        private void AddInTheMiddle(Node newNode, int index)
        {
            if (index < 0 || index > Size)
                return;
            if (index == 0)
            {
                AddAtStart(newNode);
                return;
            }
            if (index == Size)
            {
                AddInTheEnd(newNode);
                return;
            }

            Node previous = Head;
            Node current = Head.Next;
            int i = 1;

            while (current != null)
            {
                if (i == index)
                {
                    newNode.Next = current;
                    previous.Next = newNode;
                    Size++;
                    return;
                }
                previous = current;
                current = current.Next;
                i++;
            }
        }

        private void AddInTheEnd(Node newNode)
        {
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            Size++;
        }

        public List<Node> GetTasks()
        {
            Node current = Head;

            List<Node> nodes = new List<Node>();

            while (current != null)
            {
                nodes.Add(current);
                current = current.Next;
            }
            return nodes;
        }

        public List<Node> GetListByType(TaskType type)
        {
            List<Node> nodes = new List<Node>();
            Node current = Head;

            while (current != null)
            {
                if (current.Tarefa.Tipo.Equals(type))
                {
                    nodes.Add(current);
                }
                current = current.Next;
            }
            return nodes;
        }

        public int GetListSize()
        {
            return Size;
        }

        public Node GetTaskById(int id)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Tarefa.Id.Equals(id))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public Node DeleteTaskById(int id)
        {
            if (Head == null)
                return null;

            if (id == Head.Tarefa.Id)
            {
                Node removido = Head;
                Head = Head.Next;
                Size--;
                return removido;
            }

            Node previous = Head;
            Node current = Head.Next;

            while (current != null)
            {
                if (current.Tarefa.Id == id)
                {
                    Node removido = current;
                    previous.Next = current.Next;
                    Size--;
                    return removido;
                }
                previous = current;
                current = current.Next;
            }
            return null;
        }

        public Node SetTaskToComcluded(int id)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Tarefa.Id == id)
                {
                    current.Tarefa.Status = Status.Concluida;
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        // Vou fazer dois métodos Edittask: um que vai receber as edições dos campos da tarefa pelo console
        // durante a execução do método e outro que vai receber as edições como argumentos do método.
        
        public Node EditTask(int id)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Tarefa.Id == id)
                {
                    bool loopContinua = true;
                    while (loopContinua)
                    {
                        Console.Write("Digite a descrição da tarefa: ");
                        string descricaoNova = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(descricaoNova))
                        {
                            current.Tarefa.Descricao = descricaoNova;
                            loopContinua = false;
                        } else
                        {
                            Console.WriteLine("A descrição não pode estar em branco ou ser nula.");
                        }
                    }
                    
                    current.Tarefa.Tipo = ConvertionTextToTaskType();

                    current.Tarefa.Status = ConvertionTextToStatus();

                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        private TaskType ConvertionTextToTaskType()
        {
            bool loopContinua = true;
            TaskType taskType = new TaskType();

            while (loopContinua)
            {
                Console.WriteLine("Entre com o número do tipo da tarefa: ");
                Console.WriteLine("1 - Trabalho");
                Console.WriteLine("2 - Casa");
                Console.WriteLine("3 - Saúde");

                string type = Console.ReadLine();

                if (type == "1" || type == "2" || type == "3")
                {
                    if (Enum.TryParse(type, out TaskType result))
                    {
                        taskType = result;
                        loopContinua = false;
                    }
                }
                else
                {
                    Console.WriteLine("Entre com um dos valores: Ex: 1, 2 ou 3.");
                }
            }
            return taskType;
        }

        private Status ConvertionTextToStatus()
        {
            bool loopContinua = true;
            Status status = new Status();

            while (loopContinua)
            {
                Console.WriteLine("Entre com o número do status da tarefa: ");
                Console.WriteLine("1 - Pendente");
                Console.WriteLine("2 - Concluída");

                string statusTarefa = Console.ReadLine();

                if (statusTarefa == "1" || statusTarefa == "2")
                {
                    if (Enum.TryParse(statusTarefa, out Status result))
                    {
                        status = result;
                        loopContinua = false;
                    }
                }
                else
                {
                    Console.WriteLine("Entre com um dos valores: Ex: 1 ou 2.");
                }
            }
            return status;
        }

        public Node EditTask2(int id, string descricao = null, TaskType? tipo = null, Status? status = null)
        {
            Node noParaEditar = GetTaskById(id);

            if (noParaEditar == null)
                return null;

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                noParaEditar.Tarefa.Descricao = descricao;
            } 
            if (tipo.HasValue)
            {
                noParaEditar.Tarefa.Tipo = tipo.Value;
            }
            if (status.HasValue)
            {
                noParaEditar.Tarefa.Status = status.Value;
            }
            return noParaEditar;
        }
    }
}
