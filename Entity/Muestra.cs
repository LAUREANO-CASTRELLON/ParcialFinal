using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Muestra
    {
        public Paciente Paciente { get; set; }
        public Secretaria Secretaria { get; set; }
        public string Resultado { get; set; }
        public DateTime fecha { get; set; }

        public Muestra(Paciente paciente, Secretaria secretaria, string resultado)
        {
            Paciente = paciente;
            Secretaria = secretaria;
            Resultado = resultado;
        }

        public override string ToString()
        {
            return $"{Secretaria.ToString()};{Paciente.ToString()};{fecha.ToShortDateString()};{Resultado}";
        }
    }
}
