using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace InterfacesGraficas
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string usuario;
        private string contrasena;
        ConexionDB conexiondb = new ConexionDB();
        private string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario AND contraseña = @contraseña";

        PantallaPrincipal pantallaIngreso = new PantallaPrincipal();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            contrasena = txtPassword.Text;
            Comparar();

        }

        private void Comparar()
        {

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contrasena);

                try
                {
                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        pantallaIngreso.Show();
                        this.Hide();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
