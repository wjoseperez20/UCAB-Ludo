using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LudoClient.Common.Entities;

namespace LudoClient.View
{
    public partial class Board : Form
    {
        Game _game;
        Player principalPlayer;
        private static Board _board = null;

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        public static Board GetBoard
        {
            get
            {
                if (_board == null)
                    _board = new Board();

                return _board;
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
