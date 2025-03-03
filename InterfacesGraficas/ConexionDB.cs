using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    class ConexionDB
    {
        private static readonly string cadenaConexion = "Data Source=GATOPERCEBE; Initial Catalog=TareasDB; User ID=Quintero; Password=Quintero; Encrypt=False; TrustServerCertificate=True;";

        public string ObtenerCadenaConexion()
        {
            return cadenaConexion;
        }
    }
}
