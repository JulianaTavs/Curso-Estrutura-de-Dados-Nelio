using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioVendasDoDepartamento
{
    internal class Sale
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public double PrecoTotal { get; set; }
        public string Departamento { get; set; }
    }
}
