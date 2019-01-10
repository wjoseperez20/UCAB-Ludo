using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using LudoClient.Services;
using LudoClient.Common.Entities;

namespace LudoClient.View
{
    public partial class Login : Form
    {
        Connection Connection = new Connection();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userNameText.Text) || string.IsNullOrEmpty(passwordText.Text))
                {
                    MessageBox.Show("El campo Usuario y Contraseña ¡No pueden ser vacios!", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                   
                if (!Connection.CreateConnection(this, userNameText.Text, passwordText.Text))
                    MessageBox.Show("Ha ocurrido un error en la conexión");
                else
                    bLoginUser.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
