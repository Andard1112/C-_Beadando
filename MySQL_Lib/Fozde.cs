using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Lib
{
    class Fozde
    {
        int id;
        string nev;
        string tulajdonos;
        DateTime alapitas;

        public Fozde(int id, string nev, string tulajdonos, DateTime alapitas)
        {
            this.id = id;
            this.nev = nev;
            this.tulajdonos = tulajdonos;
            this.alapitas = alapitas;
        }

        public int Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public string Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
        public DateTime Alapitas { get => alapitas; set => alapitas = value; }

        public override string ToString()
        {
            return nev;
        }
    }
}
