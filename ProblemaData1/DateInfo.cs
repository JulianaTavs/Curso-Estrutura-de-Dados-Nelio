namespace ProblemaData1
{
    public class DateInfo
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public DateInfo ExtractDateData(string date)
        {
            string[] partes = date.Split('/');
            Dia = int.Parse(partes[0]);
            Mes = int.Parse(partes[1]);
            Ano = int.Parse(partes[2]);

            return this;
        }

        public override string ToString()
        {
            return "\nSEM ZERO À ESQUERDA:" +
                   $"\nDia: {Dia}" +
                   $"\nMês: {Mes}" +
                   $"\nAno {Ano}" +
                   "\nCOM ZERO À ESQUERDA:" +
                   $"\nDia: {Dia:D2}" +
                   $"\nMês: {Mes:D2}" +
                   $"\nAno: {Ano}";
        }

    }
}
