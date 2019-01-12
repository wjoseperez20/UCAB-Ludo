using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.Common.Entities
{
    public class Chip
    {
        private int _id;
        private bool _assigned;
        private string _name;
        private Dictionary<int, Point> _coordinates;

        public Chip(int id)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
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
    }
}
