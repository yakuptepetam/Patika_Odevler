using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev_ToDo
{
    internal class Card
    {
        private string baslik;
        public string Baslik
        {
            get { return baslik; }
            set { baslik = value; }
        }

        private string icerik;
        public string Icerik
        {
            get { return icerik; }
            set { icerik = value; }
        }

        private int teamid;
        public int Teamid
        {
            get { return teamid; }
            set { teamid = value; }
        }

        private string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public Card(string baslik, string icerik, int teamid, string size)
        {
            Baslik = baslik;
            Icerik = icerik;
            Teamid = teamid;
            Size = size;
        }
    }
}
