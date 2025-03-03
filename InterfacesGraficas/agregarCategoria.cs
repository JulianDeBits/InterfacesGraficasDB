using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfacesGraficas
{
    public partial class agregarCategoria: Form
    {

        ConexionDB conexiondb = new ConexionDB();
        public agregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarModificacio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = txtNombreCategoria.Text.Trim();
            string descripcionCategoria = txtDescripcionCategoria.Text.Trim();

            if (string.IsNullOrEmpty(nombreCategoria) || string.IsNullOrEmpty(descripcionCategoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CategoriaExiste(nombreCategoria))
            {
                MessageBox.Show("El nombre de la categoría ya existe. Por favor, elija otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GuardarCategoria(nombreCategoria, descripcionCategoria);
        }

        private bool CategoriaExiste(string nombreCategoria)
        {
            string query = "SELECT COUNT(*) FROM Categorias WHERE nombre = @nombreCategoria";
            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();  
                    return count > 0;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar la categoría: " + ex.Message);
                    return false;
                }
            }
        }

        private void GuardarCategoria(string nombreCategoria, string descripcionCategoria)
        {
            string query = "INSERT INTO Categorias (nombre, descripcion) VALUES (@nombre, @descripcion)";
            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", descripcionCategoria);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();  
                    MessageBox.Show("Categoría creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCategoria.Clear();
                    txtDescripcionCategoria.Clear();
                    PantallaPrincipal pantalla = new PantallaPrincipal();
                    pantalla.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
