using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;

namespace Parcial3
{
    public partial class GuardarEnBaseDeDatos : Form
    {
        ServicionArcvMuestra servicionArcvMuestra = new ServicionArcvMuestra();
        ServicioBdMuestra servicioBdMuestra;
        public GuardarEnBaseDeDatos()
        {
            InitializeComponent();
            servicioBdMuestra = new ServicioBdMuestra(ExtracionCadenaDeConexion.CadenaConexion);
        }
        public void LLenarTabla(IList<Muestra> muestras)
        {
            foreach (var item in muestras)
            {
                DgvMuestras.Rows.Add(item.Secretaria.Codigo,item.Paciente.Cedula, item.Paciente.Nombre,
                    item.Paciente.Edad, item.Paciente.Sexo, item.Resultado, item.fecha.ToShortDateString());
            }
        }
        private void BtnConsultarArchivo_Click(object sender, EventArgs e)
        {
            
        }
        public IList<Muestra> ConsultarArchivo()
        {
            RespuestaConsulta<Muestra> respuesta;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string ruta = fileDialog.FileName;
            respuesta = servicionArcvMuestra.Consultar(ruta);
            return respuesta.ElementoConsultado;
        }

        private void BtnConsultarArchivo_Click_1(object sender, EventArgs e)
        {
            DgvMuestras.Rows.Clear();
            LLenarTabla(ConsultarArchivo());
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            GUardarEnBaseDeDatos();
        }
        public IList<Muestra> ObtenerMuestrasConsistentes()
        {
            String municipio = CmbSecretaria.Text;
            String codigoMunicipio = ObtenerCodigoMunicipio(municipio);
            DateTime fecha = DtpFecha.Value;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string ruta = fileDialog.FileName;
            IList<Muestra> muestras = servicionArcvMuestra.ObtenerMuestasConsistentes(fecha, codigoMunicipio,ruta);
            servicionArcvMuestra.GuardarMuestrasInConsistentes(fecha, codigoMunicipio, ruta);
            ReporteConsultaMuestra reporteConsultaMuestra = servicionArcvMuestra.ObtenerReporteConsultaMuestra(fecha, codigoMunicipio, ruta);
            CrearMensajeUsuario(reporteConsultaMuestra);
            return muestras;
        }
        public void CrearMensajeUsuario(ReporteConsultaMuestra reporteConsultaMuestra)
        {
            string respuestaUsuario = $"resultados de carga  :  repotes :{reporteConsultaMuestra.CantidadReportados}, cargados sastifactoriamente : {reporteConsultaMuestra.CatidadaSastifactorio}  con error : {reporteConsultaMuestra.CantidadErrores}";
            Mensajes.MostrarInformacion(respuestaUsuario);
        }

        public String ObtenerCodigoMunicipio(String Municipio )
        {
            switch (Municipio)
            {
                case "Valledupar" :     return "001"; 
                case "Robles la Paz":   return "621";
                case "Agustín Codazzi": return "013";
            }
            return null;
        }
        public void GUardarEnBaseDeDatos()
        {
            foreach (var item in ObtenerMuestrasConsistentes())
            {
                RespuestaProceso<Muestra> respuesta = servicioBdMuestra.Guardar(item);
                if (respuesta.Error == true)
                {
                    Mensajes.MostrarError(respuesta.Mesaje);
                }
            }
        }

        private void BtnConsultasPacientes_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
        }
    }
}
