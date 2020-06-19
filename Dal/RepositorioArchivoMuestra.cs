using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Collections.Generic;
using System.IO;

namespace Dal
{
    public class RepositorioArchivoMuestra
    {
        private IList<Muestra> muestras = new List<Muestra>();

        public void Guardar(string muestraLogError,String ruta)
        {
            FileStream flujoDelFichero = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(flujoDelFichero);
            escritor.WriteLine(muestraLogError);
            escritor.Close();
            flujoDelFichero.Close();
        }

        public IList<Muestra> Consultar(String rutaConsulta)
        {
            muestras.Clear();
            string linea = string.Empty;
            FileStream fileStream = new FileStream(rutaConsulta, FileMode.Open);
            StreamReader lector = new StreamReader(fileStream);

            while ((linea = lector.ReadLine()) != null)
            {
                Muestra muestra = MapearMuestra(linea);
                muestras.Add(muestra);
            }
            lector.Close();
            fileStream.Close();
            return muestras;
        }
        public Muestra MapearMuestra(string linea)
        {
            String[] datos = linea.Split(';');
            String codigoSecretaria = datos[0];
            String cedula = datos[1];
            String nombre = datos[2];
            int edad = int.Parse(datos[3]);
            String sexo = datos[4];
            DateTime fecha = DateTime.Parse(datos[5]);
            String resultado = datos[6];
            Secretaria  secretaria = new Secretaria(codigoSecretaria); 
            Paciente paciente = new Paciente(cedula,nombre,edad,sexo);
            Muestra muestra = new Muestra(paciente,secretaria,resultado);
            muestra.fecha = fecha;
            return muestra;
        }
    }
}
