using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un usuario");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa una contraseña");
            }
            else
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBoxForm();

                resultado = mensaje.ShowDialog();
            }
        }

        private void txtUser_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
