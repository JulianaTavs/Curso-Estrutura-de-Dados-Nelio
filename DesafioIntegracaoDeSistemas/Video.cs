namespace DesafioIntegracaoDeSistemas
{
    internal class Video
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmSegundos { get; set; }

        public Video(string id, string titulo, int duracao)
        {
            Id = id;
            Titulo = titulo;
            DuracaoEmSegundos = duracao;
        }
    }
}
