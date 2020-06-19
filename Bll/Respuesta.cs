using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Respuesta
    {
        public String  Mesaje { get; set; }
    }
    public class RespuestaConsulta <G> : Respuesta
    {
        public IList<G> ElementoConsultado { get; set; }
    }
    public class RespuestaProceso<G> : Respuesta
    {
        public bool Error { get; set; }
    }
}
