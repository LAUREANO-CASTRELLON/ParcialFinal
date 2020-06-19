using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
namespace Bll
{
    public class ServicioBdMuestra
    {
        private readonly RepositorioBdMuestra repositorioBdMuestra;
        private AdministradorDeConexion administradorDeConexion;

        public ServicioBdMuestra(String cadenaDeConexion)
        {
            administradorDeConexion = new AdministradorDeConexion(cadenaDeConexion);
            repositorioBdMuestra = new RepositorioBdMuestra(administradorDeConexion);
        }

        public RespuestaProceso<Muestra> Guardar(Muestra muestra)
        {
            RespuestaProceso<Muestra> respuesta = new RespuestaProceso<Muestra>();
            respuesta.Error = false;
            try
            {
                administradorDeConexion.AbrirConexion();
                repositorioBdMuestra.Guardar(muestra);
                administradorDeConexion.CerrarConexion();
                respuesta.Mesaje = $"guardado con exito";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mesaje = $"error l guardar las muestras  {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally
            {
                administradorDeConexion.CerrarConexion();
            }
        }

        public RespuestaConsulta<Muestra> Consultar()
        {
            RespuestaConsulta<Muestra> respuesta = new RespuestaConsulta<Muestra>();
            try
            {
                administradorDeConexion.AbrirConexion();
                IList<Muestra> muestras = repositorioBdMuestra.Consultar();
                administradorDeConexion.CerrarConexion();
                if (muestras.Count > 0)
                {
                    respuesta.Mesaje = "consulta realizada";
                    respuesta.ElementoConsultado = muestras;
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mesaje = $"error :  {e.Message}";
                return respuesta;
            }
            finally
            {
                administradorDeConexion.CerrarConexion();
            }
        }

        public IList<Muestra> FiltrarPorMunicipio(string municipio)
        {
            administradorDeConexion.AbrirConexion();
            IList<Muestra> muestras = repositorioBdMuestra.FiltrarPorMunicipio(municipio);
            administradorDeConexion.CerrarConexion();
            return muestras;
        }


    }
}
