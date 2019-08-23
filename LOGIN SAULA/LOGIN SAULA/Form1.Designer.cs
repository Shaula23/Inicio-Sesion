namespace LOGIN_SAULA
{
    partial class disney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disney));
            this.titulo = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.rusuario = new System.Windows.Forms.TextBox();
            this.rcontraseña = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.Continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(30, 24);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(176, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Ingresa tus datos";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.Transparent;
            this.usuario.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(544, 182);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(68, 20);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuario:";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.BackColor = System.Drawing.Color.Transparent;
            this.contraseña.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(526, 224);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(86, 20);
            this.contraseña.TabIndex = 2;
            this.contraseña.Text = "Cotraseña:";
            // 
            // rusuario
            // 
            this.rusuario.Location = new System.Drawing.Point(626, 182);
            this.rusuario.Name = "rusuario";
            this.rusuario.Size = new System.Drawing.Size(100, 20);
            this.rusuario.TabIndex = 3;
            // 
            // rcontraseña
            // 
            this.rcontraseña.Location = new System.Drawing.Point(626, 226);
            this.rcontraseña.Name = "rcontraseña";
            this.rcontraseña.Size = new System.Drawing.Size(100, 20);
            this.rcontraseña.TabIndex = 4;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(35, 401);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(77, 33);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Continuar
            // 
            this.Continuar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuar.Location = new System.Drawing.Point(626, 401);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(99, 33);
            this.Continuar.TabIndex = 6;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // disney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 446);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.rcontraseña);
            this.Controls.Add(this.rusuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.titulo);
            this.Name = "disney";
            this.Text = "Disney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox rusuario;
        private System.Windows.Forms.TextBox rcontraseña;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button Continuar;
    }
}

