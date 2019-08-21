namespace InicioSesionShaula
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nombreusua = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.Label();
            this.rcontra = new System.Windows.Forms.TextBox();
            this.rnombre = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombreusua
            // 
            this.Nombreusua.AutoSize = true;
            this.Nombreusua.BackColor = System.Drawing.Color.Transparent;
            this.Nombreusua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombreusua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nombreusua.Location = new System.Drawing.Point(396, 78);
            this.Nombreusua.Name = "Nombreusua";
            this.Nombreusua.Size = new System.Drawing.Size(172, 23);
            this.Nombreusua.TabIndex = 0;
            this.Nombreusua.Text = "Nombre de usuario:";
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.BackColor = System.Drawing.Color.Transparent;
            this.contra.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.Location = new System.Drawing.Point(446, 137);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(104, 23);
            this.contra.TabIndex = 1;
            this.contra.Text = "Contraseña:";
            // 
            // rcontra
            // 
            this.rcontra.Location = new System.Drawing.Point(567, 139);
            this.rcontra.Name = "rcontra";
            this.rcontra.Size = new System.Drawing.Size(100, 22);
            this.rcontra.TabIndex = 2;
            // 
            // rnombre
            // 
            this.rnombre.ForeColor = System.Drawing.Color.Transparent;
            this.rnombre.Location = new System.Drawing.Point(583, 79);
            this.rnombre.Name = "rnombre";
            this.rnombre.Size = new System.Drawing.Size(100, 22);
            this.rnombre.TabIndex = 3;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(126, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(186, 27);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "Ingresa tus datos";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(27, 338);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // continuar
            // 
            this.continuar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.continuar.Location = new System.Drawing.Point(583, 338);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(84, 23);
            this.continuar.TabIndex = 6;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.rnombre);
            this.Controls.Add(this.rcontra);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.Nombreusua);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombreusua;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.TextBox rcontra;
        private System.Windows.Forms.TextBox rnombre;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button continuar;
    }
}

