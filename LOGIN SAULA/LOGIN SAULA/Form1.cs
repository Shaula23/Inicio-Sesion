using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_SAULA
{
    public partial class disney : Form
    {
        public disney()
        {
            InitializeComponent();
        }


        private void Continuar_Click(object sender, EventArgs e)
        {
            string usuario = rusuario.Text;
            string contraseña = rcontraseña.Text;
            if (usuario == "juancho" & contraseña == "123tamarindo")
            {
                MessageBox.Show("Bienvenido a empresas Disney");
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
