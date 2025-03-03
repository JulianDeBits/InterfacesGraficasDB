namespace InterfacesGraficas
{
    partial class Register
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
            this.correoTitulo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTitulo = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.passwordTitulo = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.stringRegistrate = new System.Windows.Forms.Label();
            this.linkIniciarSesion = new System.Windows.Forms.LinkLabel();
            this.imgRegistro = new System.Windows.Forms.PictureBox();
            this.confirmarPasswordTitulo = new System.Windows.Forms.Label();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // correoTitulo
            // 
            this.correoTitulo.AutoSize = true;
            this.correoTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTitulo.Location = new System.Drawing.Point(26, 149);
            this.correoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correoTitulo.Name = "correoTitulo";
            this.correoTitulo.Size = new System.Drawing.Size(165, 28);
            this.correoTitulo.TabIndex = 5;
            this.correoTitulo.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(30, 180);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(215, 28);
            this.txtCorreo.TabIndex = 2;
            // 
            // nombreUsuarioTitulo
            // 
            this.nombreUsuarioTitulo.AutoSize = true;
            this.nombreUsuarioTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioTitulo.Location = new System.Drawing.Point(27, 220);
            this.nombreUsuarioTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreUsuarioTitulo.Name = "nombreUsuarioTitulo";
            this.nombreUsuarioTitulo.Size = new System.Drawing.Size(171, 28);
            this.nombreUsuarioTitulo.TabIndex = 7;
            this.nombreUsuarioTitulo.Text = "Nombre de Usuario:";
            this.nombreUsuarioTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(31, 251);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Multiline = true;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(215, 28);
            this.txtNombreUsuario.TabIndex = 3;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTitulo
            // 
            this.passwordTitulo.AutoSize = true;
            this.passwordTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTitulo.Location = new System.Drawing.Point(27, 283);
            this.passwordTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordTitulo.Name = "passwordTitulo";
            this.passwordTitulo.Size = new System.Drawing.Size(93, 28);
            this.passwordTitulo.TabIndex = 9;
            this.passwordTitulo.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(31, 314);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(215, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(89, 424);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(111, 46);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // stringRegistrate
            // 
            this.stringRegistrate.AutoSize = true;
            this.stringRegistrate.Location = new System.Drawing.Point(75, 485);
            this.stringRegistrate.Name = "stringRegistrate";
            this.stringRegistrate.Size = new System.Drawing.Size(67, 13);
            this.stringRegistrate.TabIndex = 12;
            this.stringRegistrate.Text = "Registrate  ó";
            // 
            // linkIniciarSesion
            // 
            this.linkIniciarSesion.AutoSize = true;
            this.linkIniciarSesion.LinkColor = System.Drawing.Color.Black;
            this.linkIniciarSesion.Location = new System.Drawing.Point(148, 485);
            this.linkIniciarSesion.Name = "linkIniciarSesion";
            this.linkIniciarSesion.Size = new System.Drawing.Size(65, 13);
            this.linkIniciarSesion.TabIndex = 11;
            this.linkIniciarSesion.TabStop = true;
            this.linkIniciarSesion.Text = "Inicia sesion";
            this.linkIniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // imgRegistro
            // 
            this.imgRegistro.Image = global::InterfacesGraficas.Properties.Resources.register;
            this.imgRegistro.Location = new System.Drawing.Point(89, 7);
            this.imgRegistro.Name = "imgRegistro";
            this.imgRegistro.Size = new System.Drawing.Size(135, 128);
            this.imgRegistro.TabIndex = 13;
            this.imgRegistro.TabStop = false;
            // 
            // confirmarPasswordTitulo
            // 
            this.confirmarPasswordTitulo.AutoSize = true;
            this.confirmarPasswordTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarPasswordTitulo.Location = new System.Drawing.Point(25, 354);
            this.confirmarPasswordTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmarPasswordTitulo.Name = "confirmarPasswordTitulo";
            this.confirmarPasswordTitulo.Size = new System.Drawing.Size(182, 28);
            this.confirmarPasswordTitulo.TabIndex = 15;
            this.confirmarPasswordTitulo.Text = "Confirmar Password:";
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarPassword.Location = new System.Drawing.Point(31, 384);
            this.txtConfirmarPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarPassword.Multiline = true;
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.PasswordChar = '*';
            this.txtConfirmarPassword.Size = new System.Drawing.Size(215, 28);
            this.txtConfirmarPassword.TabIndex = 5;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 511);
            this.Controls.Add(this.confirmarPasswordTitulo);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.imgRegistro);
            this.Controls.Add(this.stringRegistrate);
            this.Controls.Add(this.linkIniciarSesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.passwordTitulo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.nombreUsuarioTitulo);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.correoTitulo);
            this.Controls.Add(this.txtCorreo);
            this.Name = "Register";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.imgRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correoTitulo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label nombreUsuarioTitulo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label passwordTitulo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label stringRegistrate;
        private System.Windows.Forms.LinkLabel linkIniciarSesion;
        private System.Windows.Forms.PictureBox imgRegistro;
        private System.Windows.Forms.Label confirmarPasswordTitulo;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
    }
}