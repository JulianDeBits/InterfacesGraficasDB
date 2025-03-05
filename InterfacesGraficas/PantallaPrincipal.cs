using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    public partial class PantallaPrincipal : Form
    {

        private string usuarioActual;
        public PantallaPrincipal(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            CargarTareas();
            CargarEstados();
            CargarCategorias();
            dgvTablaTareas.TabStop = false;
            btnNuevaCategoria.TabStop = false;
            this.usuarioActual = usuarioActual;
        }

        ConexionDB conexiondb = new ConexionDB();

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


        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreTarea.Text) || string.IsNullOrEmpty(txtDescripcionTarea.Text) || string.IsNullOrEmpty(cboxEstadoTarea.Text) || string.IsNullOrEmpty(cboxCategoriaTarea.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {
                string nombreTarea = txtNombreTarea.Text;
                string descripcionTarea = txtDescripcionTarea.Text;
                string estadoTarea = cboxEstadoTarea.SelectedItem.ToString();
                string categoriaTarea = cboxCategoriaTarea.SelectedItem.ToString();  

                int categoriaId = ObtenerCategoriaId(categoriaTarea);

                if (categoriaId == -1)
                {
                    MessageBox.Show("La categoría seleccionada no existe. Por favor, selecciona una categoría válida.");
                    return;  
                }

                int estadoId = ObtenerEstadoId(estadoTarea);

                int usuarioId = 1;  

                string query = "INSERT INTO Tareas (titulo, descripcion, categoriaId, usuarioId, estadoId) " +
                               "VALUES (@titulo, @descripcion, @categoriaId, @usuarioId, @estadoId)";

                using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@titulo", nombreTarea);
                    cmd.Parameters.AddWithValue("@descripcion", descripcionTarea);
                    cmd.Parameters.AddWithValue("@categoriaId", categoriaId); 
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId); 
                    cmd.Parameters.AddWithValue("@estadoId", estadoId); 

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tarea agregada correctamente");

                        txtNombreTarea.Text = "";
                        txtDescripcionTarea.Text = "";
                        cboxEstadoTarea.SelectedIndex = 0;
                        CargarEstados();  
                        CargarTareas();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar tarea: " + ex.Message);
                    }
                }
            }
        }

        public void CargarCategorias()
        {
            string query = "SELECT id, nombre FROM Categorias";  

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    cboxCategoriaTarea.Items.Clear();

                    while (reader.Read())
                    {
                        string categoria = reader["nombre"].ToString();  
                        cboxCategoriaTarea.Items.Add(categoria);
                    }

                    if (cboxCategoriaTarea.Items.Count > 0)
                    {
                        cboxCategoriaTarea.SelectedIndex = 0;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las categorías: " + ex.Message);
                }
            }
        }


        private void CargarEstados()
        {
            string query = "SELECT id, nombreEstado FROM Estados";  

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    cboxEstadoTarea.Items.Clear();

                    while (reader.Read())
                    {
                        string estado = reader["nombreEstado"].ToString();  
                        cboxEstadoTarea.Items.Add(estado);
                    }

                    if (cboxEstadoTarea.Items.Count > 0)
                    {
                        cboxEstadoTarea.SelectedIndex = 1;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los estados: " + ex.Message);
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
                    return result != null ? Convert.ToInt32(result) : 1; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el estado: " + ex.Message);
                    return 1; 
                }
            }
        }

        private void dgvTablaTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTablaTareas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro.");
                return;
            }

            if (dgvTablaTareas.Columns[e.ColumnIndex].Name == "dgvBorrar")
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow fila = dgvTablaTareas.CurrentRow;
                        string nombreTarea = fila.Cells[0].Value.ToString();

                        string query = "DELETE FROM Tareas WHERE titulo = @nombre";

                        using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@nombre", nombreTarea);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            dgvTablaTareas.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Tarea eliminada correctamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar tarea: " + ex.Message);
                    }
                }
            }

            if (dgvTablaTareas.Columns[e.ColumnIndex].Name == "dgvEditar")
            {
                try
                {
                    DataGridViewRow fila = dgvTablaTareas.CurrentRow;

                    string tareaSeleccionada = fila.Cells[0].Value.ToString();
                    string categoriaSeleccionada = fila.Cells[1].Value.ToString();
                    string descripcionSeleccionada = fila.Cells[2].Value.ToString();  
                    string estadoSeleccionado = fila.Cells[3].Value.ToString();  
                    editarRegistro editarForm = new editarRegistro(fila, tareaSeleccionada, descripcionSeleccionada, estadoSeleccionado, categoriaSeleccionada);
                    editarForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar tarea: " + ex.Message);
                }
            }

        }

        private void CargarTareas()
        {
            string query = "SELECT t.titulo, t.descripcion, e.nombreEstado, c.nombre FROM Tareas t " +
                           "JOIN Estados e ON t.estadoId = e.id " +
                           "JOIN Categorias c ON t.categoriaId = c.id";

            using (SqlConnection conn = new SqlConnection(conexiondb.ObtenerCadenaConexion()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    dgvTablaTareas.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvTablaTareas.Rows.Add(
                            row["titulo"],          
                            row["nombre"],          
                            row["descripcion"],     
                            row["nombreEstado"],    
                            "Editar",               
                            "Borrar"                
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar tareas: " + ex.Message);
                }
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            agregarCategoria categoria = new agregarCategoria();
            categoria.Show();
        }
    }
}
