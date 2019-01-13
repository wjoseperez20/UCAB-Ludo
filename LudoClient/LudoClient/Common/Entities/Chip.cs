﻿using System;
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
        private Dictionary<int, Point> _coordinates;

        public Chip(int id, string name)
        {
            _id = id;
            _name = name;
            _coordinates = new Dictionary<int, Point>();
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

        public Dictionary<int, Point> Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        public void AssingCoordinateChip(int Square, int x, int y)
        {
            _coordinates.Add(Square, new Point(x, y));
        }

        public void AssignLabel(Label label)
        {
            _image = label;
        }
    }
}
