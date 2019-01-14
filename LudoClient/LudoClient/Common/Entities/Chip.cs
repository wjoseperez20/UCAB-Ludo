using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoClient.Common.Entities
{
    public class Chip
    {
        private int _id;
        private Label _image;
        private bool _assigned;
        private string _name;
        private int _casilla;


        public Chip(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get { return _id; }
        }

        public Label Image
        {
            get { return _image; }
        }

        public bool Assigned
        {
            get { return _assigned; }
            set { _assigned = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int Casilla { get => _casilla; set => _casilla = value; }

        public void AssignLabel(Label label, Point startPoint)
        {
            _image = label;
            _image.Visible = true;
            _image.Location = startPoint;

        }
    }
}
