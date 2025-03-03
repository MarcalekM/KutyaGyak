using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaGyak
{
    internal class Gazda
    {
        public int Id { get; private set; }
        public string Nev { get; private set; }
        public string Tel { get; private set; }

        public Gazda(int id, string nev, string tel)
        {
            Id = id;
            Nev = nev;
            Tel = tel;
        }
    }
}
