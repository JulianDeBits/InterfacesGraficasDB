using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfacesGraficas
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            linkIniciarSesion.TabStop = false;
        }

        ConexionDB conexion = new ConexionDB();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string correo = txtCorreo.Text;
            string contrasena = txtPassword.Text;
            string confirmarContrasena = txtConfirmarPassword.Text;

            UsuarioRepository repo = new UsuarioRepository();

            bool registrado = repo.RegistrarUsuario(nombreUsuario, correo, contrasena, confirmarContrasena);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado exitosamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el usuario");
            }
        }

    }

public class UsuarioRepository
    {
        private ConexionDB conexionDb;

        public UsuarioRepository()
        {
            conexionDb = new ConexionDB(); 
        }

        public bool RegistrarUsuario(string nombreUsuario, string correo, string contrasena, string confirmarContrasena)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                Console.WriteLine("Todos los campos son obligatorios.");
                return false;
            }

            if (contrasena != confirmarContrasena)
            {
                Console.WriteLine("Las contraseñas no coinciden.");
                return false;
            }

            if (!IsValidEmail(correo))
            {
                Console.WriteLine("El correo electrónico no es válido.");
                return false;
            }

            if (ExisteUsuario(nombreUsuario, correo))
            {
                Console.WriteLine("El nombre de usuario o correo ya están registrados.");
                return false;
            }

            using (SqlConnection connection = new SqlConnection(conexionDb.ObtenerCadenaConexion())) 
            {
                string query = "INSERT INTO Usuarios (nombreUsuario, contrasena, correo) " +
                               "VALUES (@nombreUsuario, @contrasena, @correo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);  
                    command.Parameters.AddWithValue("@correo", correo);

                    try
                    {
                        connection.Open();  
                        command.ExecuteNonQuery();
                        Console.WriteLine("Usuario registrado exitosamente.");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al registrar el usuario: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private bool ExisteUsuario(string nombreUsuario, string correo)
        {
            using (SqlConnection connection = new SqlConnection(conexionDb.ObtenerCadenaConexion()))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE nombreUsuario = @nombreUsuario OR correo = @correo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@correo", correo);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al verificar el usuario: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private bool IsValidEmail(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }

}

