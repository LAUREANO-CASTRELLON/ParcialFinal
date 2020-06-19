using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReporteConsultaMuestra
    {
        public int CantidadReportados { get; set; }
        public int CatidadaSastifactorio { get; set; }
        public int CantidadErrores { get; set; }

        public ReporteConsultaMuestra(int cantidadReportados, int catidadaSastifactorio, int cantidadErrores)
        {
            CantidadReportados = cantidadReportados;
            CatidadaSastifactorio = catidadaSastifactorio;
            CantidadErrores = cantidadErrores;
        }
    }
}
