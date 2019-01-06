using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoClient.Common.Entities
{
    public class Chip
    {
        private int _id;
        private bool _assigned;

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
    }
}
