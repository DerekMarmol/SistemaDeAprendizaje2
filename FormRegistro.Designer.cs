namespace SistemaDeAprendizaje2
{
    partial class FormRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIniciarSesion.Location = new System.Drawing.Point(429, 304);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(125, 45);
            this.btnIniciarSesion.TabIndex = 33;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrar.Location = new System.Drawing.Point(89, 304);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 45);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContraseña.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblContraseña.Location = new System.Drawing.Point(163, 199);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 19);
            this.lblContraseña.TabIndex = 30;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(249, 198);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 20);
            this.txtContraseña.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(195, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(248, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApellido.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblApellido.Location = new System.Drawing.Point(184, 91);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(249, 90);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 25;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombre.Location = new System.Drawing.Point(183, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(249, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 23;
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBoxFondo.Location = new System.Drawing.Point(-21, -2);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(681, 397);
            this.pictureBoxFondo.TabIndex = 31;
            this.pictureBoxFondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 392);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBoxFondo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
    }
}

