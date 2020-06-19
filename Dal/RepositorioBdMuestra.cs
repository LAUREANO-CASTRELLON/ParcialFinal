using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public class RepositorioBdMuestra
    {
        private readonly SqlConnection _connection;
        public RepositorioBdMuestra(AdministradorDeConexion administradorDeConexion)
        {
            _connection = administradorDeConexion._conexion;
        }

        public void Guardar(Muestra muestra)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO muestra VALUES (@codigo,@cedula,@nombre,@edad,@sexo,@fecha,@resultado)";
                command.Parameters.AddWithValue("@codigo", muestra.Secretaria.Codigo);
                command.Parameters.AddWithValue("@cedula", muestra.Paciente.Cedula);
                command.Parameters.AddWithValue("@nombre", muestra.Paciente.Nombre);
                command.Parameters.AddWithValue("@edad", muestra.Paciente.Edad);
                command.Parameters.AddWithValue("@sexo", muestra.Paciente.Sexo);
                command.Parameters.AddWithValue("@fecha", muestra.fecha.ToShortDateString());
                command.Parameters.AddWithValue("@resultado", muestra.Resultado);
                var filas = command.ExecuteNonQuery();
            }

        }

        public IList<Muestra> Consultar()
        {
            SqlDataReader dataReader;
            List<Muestra> muestras = new List<Muestra>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from muestra";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Muestra muestra = MapearMuestra(dataReader);
                        muestras.Add(muestra);
                    }
                }
            }
            return muestras;
        }

        public Muestra MapearMuestra(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            string codigo = (string)dataReader["codigo"];
            string municipio = ObtenerMunicipio(codigo);
            string cedula = (string)dataReader["cedula"];
            string nombre = (string)dataReader["nombre"];
            int edad = (int)dataReader["edad"];
            string sexo = (string)dataReader["sexo"];
            string fecha = (string)dataReader["fecha"];
            DateTime fechaReal = DateTime.Parse(fecha);
            string resultado = (string)dataReader["resultado"];
            Paciente paciente = new Paciente(cedula,nombre,edad,sexo);
            Secretaria secretaria = new Secretaria(codigo);
            secretaria.Nombre = municipio;
            Muestra muestra = new Muestra(paciente,secretaria,resultado);
            muestra.fecha = fechaReal;
            return muestra;
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
        public IList<Muestra> FiltrarPorMunicipio(string municipio)
        {
            IList<Muestra> muestras = Consultar();
            return muestras.Where(m => m.Secretaria.Nombre.Equals(municipio)).ToList();
        }
    }
}
