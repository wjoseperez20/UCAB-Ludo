using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoServer.Services;
using LudoServer.Common.Entities;

namespace LudoServer.View
{
    public partial class ServerView : Form
    {
        Connection Connection = new Connection();

        public ServerView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Create_Connection(this, 1, Game.GetGame);
        }

        private void ServerView_Load(object sender, EventArgs e)
        {

        }
    }
}
