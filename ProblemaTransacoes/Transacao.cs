namespace ProblemaTransacoes
{
    internal class Transacao
    {
        public string Nome { get; set; }
        public int MinutosDaCompra { get; set; }
        public int ValorDaCompra { get; set; }
        public string CidadeDaCompra { get; set; }

        public Transacao(string nome, int minutos, int valor, string cidade)
        {
            Nome = nome;
            MinutosDaCompra = minutos;
            ValorDaCompra = valor;
            CidadeDaCompra = cidade;
        }

        public override string ToString()
        {
            return $"[\"{Nome},{MinutosDaCompra},{ValorDaCompra},{CidadeDaCompra}\"]";
        }
    }
}
