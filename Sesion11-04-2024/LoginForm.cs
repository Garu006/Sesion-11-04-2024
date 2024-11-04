using MetroFramework;
using Sesion11_04_2024.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion11_04_2024.Servicios;
using System.Security.Cryptography;


namespace Sesion11_04_2024
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MetroMessageBox.Show(this, "Llene todos los campos", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string user = tbUsuario.Text;
            string password = tbPassword.Text;
            
            if (user == "admin" && password == "1234")
            {
                MessageBox.Show("Bienvenido");
                Menu menu = new Menu();
            }
            else
            {
                MessageBox.Show("No ha completado todos los campos");
            }
        }
    }
}
