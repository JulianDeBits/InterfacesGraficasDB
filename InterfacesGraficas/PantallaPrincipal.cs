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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            cboxEstadoTarea.SelectedIndex = 0;
            CargarTareas();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreTarea.Text) || string.IsNullOrEmpty(txtDescripcionTarea.Text) || string.IsNullOrEmpty(cboxEstadoTarea.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            else
            {
                string nombreTarea = txtNombreTarea.Text;
                string descripcionTarea = txtDescripcionTarea.Text;
                string estadoTarea = cboxEstadoTarea.SelectedItem.ToString();

                string query = "INSERT INTO Tareas (Nombre, Descripcion, Estado) VALUES (@nombre, @descripcion, @estado)";
                using (SqlConnection conn = new SqlConnection("Data Source=GATOPERCEBE; Initial Catalog=InterfacesGraficas; User ID=Quintero; Password=Quintero; Encrypt=False; TrustServerCertificate=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombreTarea);
                    cmd.Parameters.AddWithValue("@descripcion", descripcionTarea);
                    cmd.Parameters.AddWithValue("@estado", estadoTarea);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tarea agregada correctamente");

                        txtNombreTarea.Text = "";
                        txtDescripcionTarea.Text = "";
                        cboxEstadoTarea.SelectedIndex = 0;

                        CargarTareas();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar tarea: " + ex.Message);
                    }
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

                        string query = "DELETE FROM Tareas WHERE Nombre = @nombre";

                        using (SqlConnection conn = new SqlConnection("Data Source=GATOPERCEBE; Initial Catalog=InterfacesGraficas; User ID=Quintero; Password=Quintero; Encrypt=False; TrustServerCertificate=True;"))
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
                    string descripcionSeleccionada = fila.Cells[1].Value.ToString();
                    string estadoSeleccionado = fila.Cells[2].Value.ToString();
                    editarRegistro editar = new editarRegistro(fila, tareaSeleccionada, descripcionSeleccionada, estadoSeleccionado);
                    editar.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar tarea: " + ex.Message);
                }
            }
        }

        private void CargarTareas()
        {
            string query = "SELECT Nombre, Descripcion, Estado FROM Tareas";

            using (SqlConnection conn = new SqlConnection("Data Source=GATOPERCEBE; Initial Catalog=InterfacesGraficas; User ID=Quintero; Password=Quintero; Encrypt=False; TrustServerCertificate=True;"))
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
                            row["Nombre"],       
                            row["Descripcion"],  
                            row["Estado"],       
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
    }
}

