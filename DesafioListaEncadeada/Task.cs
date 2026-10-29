namespace DesafioListaEncadeada
{
    internal class Task
    {
        public int Id { get; }
        public string Descricao { get; set; }
        public TaskType Tipo { get; set; }
        public Status Status { get; set; }

        public Task(int id, string descricao, TaskType tipo, Status status)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nDescrição: {Descricao}\nTipo: {Tipo}\nStatus: {Status}\n";
        }

    }
}
