using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
namespace Bll
{
    public class ServicionArcvMuestra
    {
        RepositorioArchivoMuestra archivoMuestra;

        public ServicionArcvMuestra()
        {
            archivoMuestra = new RepositorioArchivoMuestra();
        }
        public RespuestaConsulta<Muestra> Consultar(string ruta)
        {

            RespuestaConsulta<Muestra> respuestaConsulta = new RespuestaConsulta<Muestra>();
            try
            {
                respuestaConsulta.ElementoConsultado = archivoMuestra.Consultar(ruta);
                if (respuestaConsulta.ElementoConsultado != null)
                {
                    respuestaConsulta.Mesaje = "archivo encontrado con exito";
                }
                else
                {
                    respuestaConsulta.Mesaje = "La lista esta nula";
                }
                
                return respuestaConsulta;
            }
            catch (Exception e)
            {
                respuestaConsulta.Mesaje = $"No hay datos error  {e.Message}";
                return respuestaConsulta;
            }
        }
        public IList<Muestra> ObtenerMuestasConsistentes (DateTime fecha ,string codigoMunicipio, string ruta )
        {
            IList<Muestra> muestras = new List<Muestra>();
            foreach (var item in archivoMuestra.Consultar(ruta))
            {
                if (item.Secretaria.Codigo.Equals(codigoMunicipio) && SonFechasConsistentes(fecha, item.fecha))
                {
                    muestras.Add(item);
                }
            }
            return muestras;
        }
        public void GuardarMuestrasInConsistentes(DateTime fecha, string codigoMunicipio, string ruta)
        {
            int resgistro = 1;
            IList<Muestra> muestras = new List<Muestra>();
            foreach (var item in archivoMuestra.Consultar(ruta))
            {
                string rutaLogError = CrearLineaLogError(codigoMunicipio);
                if (!item.Secretaria.Codigo.Equals(codigoMunicipio))
                {
                    string linea = $"{item.ToString()}  Registro {resgistro} Error : Codigo de Municipio";
                    archivoMuestra.Guardar(linea, rutaLogError);
                }
                if (!SonFechasConsistentes(fecha, item.fecha))
                {
                    string linea = $"{item.ToString()}  Registro {resgistro} Error : Codigo de Municipio";
                    archivoMuestra.Guardar(linea, rutaLogError);
                }
                resgistro = resgistro + 1;
            }
        }
        public String CrearLineaLogError(string codigo)
        {
            DateTime fecha = DateTime.Now;
            String municipio = ObtenerMunicipio(codigo);
            string ruta = $"Log{municipio}{fecha.Day}{fecha.Month}{fecha.Year}.txt";
            return ruta;
        }
        public bool SonFechasConsistentes(DateTime fechaEviada, DateTime fechaArchivo)
        {
            if (fechaEviada.Year.Equals(fechaArchivo.Year) && fechaEviada.Day.Equals(fechaArchivo.Day) && fechaEviada.Month.Equals(fechaArchivo.Month))
            {
                return true;
            }
            return false;
        }
        public String ObtenerMunicipio(String codigo)
        {
            switch (codigo)
            {
                case "001": return "Valledupar";
                case "621": return "Robles la Paz";
                case "013": return "Agustín Codazzi";
            }
            return null;
        }
        public ReporteConsultaMuestra ObtenerReporteConsultaMuestra(DateTime fecha, string codigoMunicipio, string ruta)
        {
            IList<Muestra> muestras = archivoMuestra.Consultar(ruta);
            int reportes = muestras.Count();
            int existosos = 0;
            int fallido = 0;
            foreach (var item in muestras)
            {
                if (item.Secretaria.Codigo.Equals(codigoMunicipio) && SonFechasConsistentes(fecha, item.fecha))
                {
                    existosos = existosos + 1;
                }
                else
                {
                    fallido = fallido + 1;
                }
            }
            ReporteConsultaMuestra reporteConsultaMuestra = new ReporteConsultaMuestra(reportes,existosos,fallido);
            return reporteConsultaMuestra;
        }
    }
}
