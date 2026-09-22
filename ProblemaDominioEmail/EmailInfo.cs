namespace ProblemaDominioEmail
{
    public class EmailInfo
    {
        public string? Usuario { get; set; }
        public string? Dominio { get; set; }
        public string? EhBrasileiro { get; set; }

        public EmailInfo ExtractEmailInformation(string email)
        {
            string[] partes = email.Split('@');
            Usuario = partes[0];
            Dominio = partes[1];

            if (Dominio.EndsWith(".br"))
            {
                EhBrasileiro = "Sim";
            }else
            {
                EhBrasileiro = "Não";
            }
            return this;
        }

        public override string ToString()
        {
            return $"Usuário: {Usuario}" +
                   $"\nDomínio: {Dominio}" +
                   $"\nBrasileiro: {EhBrasileiro}";

        }

    }

}
