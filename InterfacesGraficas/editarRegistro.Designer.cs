namespace InterfacesGraficas
{
    partial class editarRegistro
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
            this.tituloTarea = new System.Windows.Forms.Label();
            this.txt2NombreTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2DescripcionTarea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox2EstadoTarea = new System.Windows.Forms.ComboBox();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnCancelarModificacio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloTarea
            // 
            this.tituloTarea.AutoSize = true;
            this.tituloTarea.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTarea.Location = new System.Drawing.Point(21, 21);
            this.tituloTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloTarea.Name = "tituloTarea";
            this.tituloTarea.Size = new System.Drawing.Size(49, 24);
            this.tituloTarea.TabIndex = 8;
            this.tituloTarea.Text = "Tarea";
            // 
            // txt2NombreTarea
            // 
            this.txt2NombreTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2NombreTarea.Location = new System.Drawing.Point(25, 47);
            this.txt2NombreTarea.Margin = new System.Windows.Forms.Padding(2);
            this.txt2NombreTarea.Multiline = true;
            this.txt2NombreTarea.Name = "txt2NombreTarea";
            this.txt2NombreTarea.Size = new System.Drawing.Size(158, 36);
            this.txt2NombreTarea.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripción";
            // 
            // txt2DescripcionTarea
            // 
            this.txt2DescripcionTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2DescripcionTarea.Location = new System.Drawing.Point(216, 47);
            this.txt2DescripcionTarea.Margin = new System.Windows.Forms.Padding(2);
            this.txt2DescripcionTarea.Multiline = true;
            this.txt2DescripcionTarea.Name = "txt2DescripcionTarea";
            this.txt2DescripcionTarea.Size = new System.Drawing.Size(423, 97);
            this.txt2DescripcionTarea.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado";
            // 
            // cbox2EstadoTarea
            // 
            this.cbox2EstadoTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox2EstadoTarea.FormattingEnabled = true;
            this.cbox2EstadoTarea.Items.AddRange(new object[] {
            "Pendiente",
            "Completado"});
            this.cbox2EstadoTarea.Location = new System.Drawing.Point(673, 47);
            this.cbox2EstadoTarea.Margin = new System.Windows.Forms.Padding(2);
            this.cbox2EstadoTarea.Name = "cbox2EstadoTarea";
            this.cbox2EstadoTarea.Size = new System.Drawing.Size(158, 36);
            this.cbox2EstadoTarea.TabIndex = 11;
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditarTarea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarea.Location = new System.Drawing.Point(748, 160);
            this.btnEditarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(95, 40);
            this.btnEditarTarea.TabIndex = 14;
            this.btnEditarTarea.Text = "Guardar";
            this.btnEditarTarea.UseVisualStyleBackColor = false;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // btnCancelarModificacio
            // 
            this.btnCancelarModificacio.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelarModificacio.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModificacio.Location = new System.Drawing.Point(640, 160);
            this.btnCancelarModificacio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarModificacio.Name = "btnCancelarModificacio";
            this.btnCancelarModificacio.Size = new System.Drawing.Size(95, 40);
            this.btnCancelarModificacio.TabIndex = 13;
            this.btnCancelarModificacio.Text = "Cancelar";
            this.btnCancelarModificacio.UseVisualStyleBackColor = false;
            this.btnCancelarModificacio.Click += new System.EventHandler(this.btnCancelarModificacio_Click);
            // 
            // editarRegistro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 211);
            this.Controls.Add(this.btnCancelarModificacio);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox2EstadoTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2DescripcionTarea);
            this.Controls.Add(this.tituloTarea);
            this.Controls.Add(this.txt2NombreTarea);
            this.Name = "editarRegistro";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloTarea;
        private System.Windows.Forms.TextBox txt2NombreTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2DescripcionTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox2EstadoTarea;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnCancelarModificacio;
    }
}