using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AdministradorDeConexion
    {
            internal SqlConnection _conexion;
            public AdministradorDeConexion(string cadenaDeConexion)
            {
                _conexion = new SqlConnection(cadenaDeConexion);
            }
            public void AbrirConexion()
            {
                _conexion.Open();
            }
            public void CerrarConexion()
            {
                _conexion.Close();
            }
        
    }
}
