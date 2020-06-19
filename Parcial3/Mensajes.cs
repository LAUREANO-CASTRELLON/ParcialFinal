using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public class Mensajes
    {
        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
