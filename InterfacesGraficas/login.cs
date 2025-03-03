using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            linkRegistrarse.TabStop = false;
        }

        private string nombreUsuario;
        private string contrasena;
        ConexionDB conexiondb = new ConexionDB();
        private string query = "SELECT COUNT(*) FROM Usuarios WHERE nombreUsuario = @nombreUsuario AND contrasena = @contrasena";

        PantallaPrincipal pantallaIngreso = new PantallaPrincipal();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            nombreUsuario = txtUsuario.Text;  
            contrasena = txtPassword.Text;
            Comparar();
        }

        private void Comparar()
        {
            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario); 
                cmd.Parameters.AddWithValue("@contrasena", contrasena); 

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        pantallaIngreso.Show();
                        this.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registro = new Register();
            this.Hide();
            registro.Show();
        }
    }
}
