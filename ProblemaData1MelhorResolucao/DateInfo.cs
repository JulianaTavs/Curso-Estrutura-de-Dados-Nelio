namespace ProblemaData1MelhorResolucao
{
    internal class DateInfo
    {
        public int Dia { get; init; }
        public int Mes { get; init; }
        public int Ano { get; init; }

        public static DateInfo ExtractDateData(string date)
        {
            string[] partes = date.Split('/');
            
            return new DateInfo{
                Dia = int.Parse(partes[0]),
                Mes = int.Parse(partes[1]),
                Ano = int.Parse(partes[2])
            };
        }

        public override string ToString()
        {
            return $"Dia: {Dia}\nMês: {Mes}\nAno: {Ano}";
        }
    }
}
