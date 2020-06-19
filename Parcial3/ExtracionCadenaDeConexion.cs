using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Parcial3
{
    public class ExtracionCadenaDeConexion
    {
        public static String CadenaConexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
