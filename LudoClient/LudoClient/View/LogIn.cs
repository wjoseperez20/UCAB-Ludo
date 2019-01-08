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
            Connection.CreateConnection(this,"wilmer", "1234");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
