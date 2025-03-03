namespace InterfacesGraficas
{
    partial class agregarCategoria
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
            this.stringTituloCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.stringTituloDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stringTituloModulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stringTituloCategoria
            // 
            this.stringTituloCategoria.AutoSize = true;
            this.stringTituloCategoria.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTituloCategoria.Location = new System.Drawing.Point(376, 48);
            this.stringTituloCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stringTituloCategoria.Name = "stringTituloCategoria";
            this.stringTituloCategoria.Size = new System.Drawing.Size(142, 24);
            this.stringTituloCategoria.TabIndex = 8;
            this.stringTituloCategoria.Text = "Nombre Categoria:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(380, 74);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCategoria.Multiline = true;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(218, 36);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // stringTituloDescripcion
            // 
            this.stringTituloDescripcion.AutoSize = true;
            this.stringTituloDescripcion.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTituloDescripcion.Location = new System.Drawing.Point(667, 48);
            this.stringTituloDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stringTituloDescripcion.Name = "stringTituloDescripcion";
            this.stringTituloDescripcion.Size = new System.Drawing.Size(166, 24);
            this.stringTituloDescripcion.TabIndex = 10;
            this.stringTituloDescripcion.Text = "Descripción Categoria:";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(671, 75);
            this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionCategoria.Multiline = true;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(327, 191);
            this.txtDescripcionCategoria.TabIndex = 3;
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(764, 293);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarCategoria.TabIndex = 4;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarModificacio_Click);
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearCategoria.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCategoria.Location = new System.Drawing.Point(903, 293);
            this.btnCrearCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(95, 40);
            this.btnCrearCategoria.TabIndex = 1;
            this.btnCrearCategoria.Text = "Crear";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfacesGraficas.Properties.Resources.categoria;
            this.pictureBox1.Location = new System.Drawing.Point(91, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 145);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // stringTituloModulo
            // 
            this.stringTituloModulo.AutoSize = true;
            this.stringTituloModulo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTituloModulo.Location = new System.Drawing.Point(47, 39);
            this.stringTituloModulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stringTituloModulo.Name = "stringTituloModulo";
            this.stringTituloModulo.Size = new System.Drawing.Size(233, 37);
            this.stringTituloModulo.TabIndex = 14;
            this.stringTituloModulo.Text = "NUEVA CATEGORIA";
            // 
            // agregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 361);
            this.Controls.Add(this.stringTituloModulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.stringTituloDescripcion);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.stringTituloCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Name = "agregarCategoria";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringTituloCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label stringTituloDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnCrearCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stringTituloModulo;
    }
}