using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Bll;
namespace Parcial3
{
    public partial class Consultas : Form
    {
        ServicioBdMuestra servicioBdMuestra;
        public Consultas()
        {
            InitializeComponent();
            servicioBdMuestra = new ServicioBdMuestra(ExtracionCadenaDeConexion.CadenaConexion);
        }
        public void LLenarTabla(IList<Muestra> muestras)
        {
            foreach (var item in muestras)
            {
                DgvMuestras.Rows.Add(item.Secretaria.Codigo, item.Paciente.Cedula, item.Paciente.Nombre,
                    item.Paciente.Edad, item.Paciente.Sexo, item.Resultado, item.fecha.ToShortDateString());
            }
        }
        public void LLenarTabla2(List<Muestra> muestras)
        {
            foreach (var item in muestras)
            {
                DgvMuestras.Rows.Add(item.Secretaria.Codigo, item.Paciente.Cedula, item.Paciente.Nombre,
                    item.Paciente.Edad, item.Paciente.Sexo, item.Resultado, item.fecha.ToShortDateString());
            }
        }
        private void BtnConsultarArchivo_Click_1(object sender, EventArgs e)
        {
           
        }

        public void Consultar()
        {
            DgvMuestras.Rows.Clear();
            RespuestaConsulta<Muestra> respuesta;
            IList<Muestra> muestras;
            String tipoConsulta = CmbSecretaria.Text;
            if (tipoConsulta.Equals("Todos"))
            {
                respuesta = servicioBdMuestra.Consultar();
                LLenarTabla(respuesta.ElementoConsultado);
            }
            else
            {
                if (tipoConsulta.Equals("Valledupar"))
                {
                    muestras = servicioBdMuestra.FiltrarPorMunicipio("Valledupar");
                    LLenarTabla(muestras);
                }
                else
                {
                    if (tipoConsulta.Equals("Robles la Paz"))
                    {
                        muestras = servicioBdMuestra.FiltrarPorMunicipio("Valledupar");
                        LLenarTabla(muestras);
                    }
                    else
                    {
                        if (tipoConsulta.Equals("Robles la Paz"))
                        {
                            muestras = servicioBdMuestra.FiltrarPorMunicipio("Agustín Codazzi");
                            LLenarTabla(muestras);
                        }
                    }
                }
                

            }
            
        }

        private void BtbConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
