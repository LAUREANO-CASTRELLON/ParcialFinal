using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public Paciente(string cedula, string nombre, int edad, string sexo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }
        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Edad},{Sexo}";
        }
    }
}
