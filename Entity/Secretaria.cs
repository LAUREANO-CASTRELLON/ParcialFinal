using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Secretaria
    {
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public Secretaria(string codigo)
        {
            Codigo = codigo;
        }
        public override string ToString()
        {
            return $"{Codigo}";
        }
    }
}
