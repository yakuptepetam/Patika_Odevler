using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_ToDo
{
    internal class Team
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public Team(int id, string ad)
        {
            Id = id;
            Ad = ad;
        }
    }
}
