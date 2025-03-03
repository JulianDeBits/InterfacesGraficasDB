using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    public partial class editarRegistro : Form
    {
        private DataGridViewRow fila;
        private string tareaSeleccionada;
        private string descripcionSeleccionada;
        private string estadoSeleccionado;
        private string categoriaSeleccionada;
        ConexionDB conexiondb = new ConexionDB();

        public editarRegistro(DataGridViewRow fila, String tareaSeleccionada, String descripcionSeleccionada, String estadoSeleccionado, string categoriaSeleccionada)
        {
            InitializeComponent();
            this.fila = fila;
            this.tareaSeleccionada = tareaSeleccionada;
            this.descripcionSeleccionada = descripcionSeleccionada;
            this.estadoSeleccionado = estadoSeleccionado;
            this.categoriaSeleccionada = categoriaSeleccionada;  

            ObtenerDatosRegistro();
        }

        private void ObtenerDatosRegistro()
        {
            CargarCategorias();

            txt2NombreTarea.Text = tareaSeleccionada;
            txt2DescripcionTarea.Text = descripcionSeleccionada;
            cbox2EstadoTarea.SelectedItem = estadoSeleccionado;

            if (cboxCategoriasTareas2.Items.Contains(categoriaSeleccionada))
            {
                cboxCategoriasTareas2.SelectedItem = categoriaSeleccionada;  
            }
            else
            {
                MessageBox.Show("Categoría no encontrada en el ComboBox.");
            }
        }


        private void CargarCategorias()
        {
            string query = "SELECT nombre FROM Categorias";  

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    cboxCategoriasTareas2.Items.Clear();

                    while (reader.Read())
                    {
                        string categoria = reader["nombre"].ToString();
                        cboxCategoriasTareas2.Items.Add(categoria);
                    }

                    if (cboxCategoriasTareas2.Items.Count > 0)
                    {
                        if (cboxCategoriasTareas2.Items.Contains(categoriaSeleccionada))
                        {
                            cboxCategoriasTareas2.SelectedItem = categoriaSeleccionada;
                        }
                        else
                        {
                            cboxCategoriasTareas2.SelectedIndex = 0;
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message);
                }
            }
        }


        private void btnCancelarModificacio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt2NombreTarea.Text) || string.IsNullOrEmpty(txt2DescripcionTarea.Text) || string.IsNullOrEmpty(cbox2EstadoTarea.Text) || string.IsNullOrEmpty(cboxCategoriasTareas2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas editar este registro?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string nombreTarea = txt2NombreTarea.Text;
                        string descripcionTarea = txt2DescripcionTarea.Text;
                        string estadoTarea = cbox2EstadoTarea.SelectedItem.ToString();
                        string categoriaTarea = cboxCategoriasTareas2.SelectedItem.ToString(); 

                        int estadoId = ObtenerEstadoId(estadoTarea);  
                        int categoriaId = ObtenerCategoriaId(categoriaTarea);  

                        if (estadoId == -1)
                        {
                            MessageBox.Show("El estado seleccionado no es válido.");
                            return;
                        }

                        DateTime fechaVencimiento = DateTime.Now;
                        if (estadoTarea == "Completado")
                        {
                            fechaVencimiento = DateTime.Now;  
                        }

                        string query = "UPDATE Tareas SET titulo = @nombre, Descripcion = @descripcion, EstadoId = @estadoId, categoriaId = @categoriaId, fechaVencimiento = @fechaVencimiento WHERE titulo = @nombreTarea";

                        using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@nombre", nombreTarea);
                            cmd.Parameters.AddWithValue("@descripcion", descripcionTarea);
                            cmd.Parameters.AddWithValue("@estadoId", estadoId);  
                            cmd.Parameters.AddWithValue("@categoriaId", categoriaId);  
                            cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);  
                            cmd.Parameters.AddWithValue("@nombreTarea", tareaSeleccionada);  

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            string categoriaNombre = ObtenerCategoriaNombre(categoriaId);  

                            fila.Cells[0].Value = nombreTarea;
                            fila.Cells[1].Value = categoriaNombre;  
                            fila.Cells[2].Value = descripcionTarea;
                            fila.Cells[3].Value = estadoTarea;

                            MessageBox.Show("Registro actualizado correctamente");

                            this.Close();  
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar el registro: " + ex.Message);
                    }
                }
            }
        }

        private string ObtenerCategoriaNombre(int categoriaId)
        {
            string query = "SELECT nombre FROM Categorias WHERE id = @categoriaId";

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoriaId", categoriaId);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el nombre de la categoría: " + ex.Message);
                    return string.Empty;
                }
            }
        }



        private int ObtenerEstadoId(string estado)
        {
            string query = "SELECT id FROM Estados WHERE nombreEstado = @estado";

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", estado);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el estado: " + ex.Message);
                    return -1;
                }
            }
        }
        private int ObtenerCategoriaId(string categoria)
        {
            string query = "SELECT id FROM Categorias WHERE nombre = @categoria";

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria", categoria);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la categoría: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
