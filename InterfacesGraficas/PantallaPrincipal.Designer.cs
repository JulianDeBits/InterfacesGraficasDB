namespace InterfacesGraficas
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.cboxEstadoTarea = new System.Windows.Forms.ComboBox();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            this.iconoApp = new System.Windows.Forms.PictureBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.dgvTablaTareas = new System.Windows.Forms.DataGridView();
            this.tituloTarea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTarea.Location = new System.Drawing.Point(44, 188);
            this.txtNombreTarea.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTarea.Multiline = true;
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(158, 36);
            this.txtNombreTarea.TabIndex = 0;
            // 
            // cboxEstadoTarea
            // 
            this.cboxEstadoTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstadoTarea.FormattingEnabled = true;
            this.cboxEstadoTarea.Items.AddRange(new object[] {
            "Pendiente",
            "Completado"});
            this.cboxEstadoTarea.Location = new System.Drawing.Point(44, 437);
            this.cboxEstadoTarea.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEstadoTarea.Name = "cboxEstadoTarea";
            this.cboxEstadoTarea.Size = new System.Drawing.Size(158, 36);
            this.cboxEstadoTarea.TabIndex = 2;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionTarea.Location = new System.Drawing.Point(44, 265);
            this.txtDescripcionTarea.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionTarea.Multiline = true;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(158, 134);
            this.txtDescripcionTarea.TabIndex = 1;
            // 
            // iconoApp
            // 
            this.iconoApp.Image = global::InterfacesGraficas.Properties.Resources.IconoTareas;
            this.iconoApp.Location = new System.Drawing.Point(44, 17);
            this.iconoApp.Margin = new System.Windows.Forms.Padding(2);
            this.iconoApp.Name = "iconoApp";
            this.iconoApp.Size = new System.Drawing.Size(142, 137);
            this.iconoApp.TabIndex = 3;
            this.iconoApp.TabStop = false;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(76, 485);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(83, 40);
            this.btnAgregarTarea.TabIndex = 4;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // dgvTablaTareas
            // 
            this.dgvTablaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTareas,
            this.dgvDescripcion,
            this.dgvEstado,
            this.dgvEditar,
            this.dgvBorrar});
            this.dgvTablaTareas.Location = new System.Drawing.Point(231, 17);
            this.dgvTablaTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaTareas.Name = "dgvTablaTareas";
            this.dgvTablaTareas.RowHeadersWidth = 51;
            this.dgvTablaTareas.RowTemplate.Height = 24;
            this.dgvTablaTareas.Size = new System.Drawing.Size(615, 508);
            this.dgvTablaTareas.TabIndex = 5;
            this.dgvTablaTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaTareas_CellClick);
            // 
            // tituloTarea
            // 
            this.tituloTarea.AutoSize = true;
            this.tituloTarea.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTarea.Location = new System.Drawing.Point(40, 162);
            this.tituloTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloTarea.Name = "tituloTarea";
            this.tituloTarea.Size = new System.Drawing.Size(49, 24);
            this.tituloTarea.TabIndex = 6;
            this.tituloTarea.Text = "Tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTareas.HeaderText = "Tareas";
            this.dgvTareas.MinimumWidth = 6;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.Width = 125;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDescripcion.HeaderText = "Descripción";
            this.dgvDescripcion.MinimumWidth = 6;
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Width = 125;
            // 
            // dgvEstado
            // 
            this.dgvEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.MinimumWidth = 6;
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 125;
            // 
            // dgvEditar
            // 
            this.dgvEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEditar.HeaderText = "Editar";
            this.dgvEditar.MinimumWidth = 6;
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvEditar.Text = "";
            this.dgvEditar.ToolTipText = "Eliminar";
            // 
            // dgvBorrar
            // 
            this.dgvBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBorrar.HeaderText = "Borrar";
            this.dgvBorrar.MinimumWidth = 6;
            this.dgvBorrar.Name = "dgvBorrar";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloTarea);
            this.Controls.Add(this.dgvTablaTareas);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.iconoApp);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.cboxEstadoTarea);
            this.Controls.Add(this.txtNombreTarea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            ((System.ComponentModel.ISupportInitialize)(this.iconoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.ComboBox cboxEstadoTarea;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
        private System.Windows.Forms.PictureBox iconoApp;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.DataGridView dgvTablaTareas;
        private System.Windows.Forms.Label tituloTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEditar;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBorrar;
    }
}