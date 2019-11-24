using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Lib
{
    class Cefre
    {
        int id;
        string gyumolcs;
        int alkohol;
        int egysegar;
        int fozde_id;

        public Cefre(int id, string gyumolcs, int alkohol, int egysegar, int fozde_id)
        {
            this.id = id;
            this.gyumolcs = gyumolcs;
            this.alkohol = alkohol;
            this.egysegar = egysegar;
            this.fozde_id = fozde_id;
        }

        public int Id { get => id; }
        public string Gyumolcs { get => gyumolcs; set => gyumolcs = value; }
        public int Alkohol { get => alkohol; set => alkohol = value; }
        public int Egysegar { get => egysegar; set => egysegar = value; }
        public int Fozde_id { get => fozde_id; set => fozde_id = value; }

        public override string ToString()
        {
            return Gyumolcs;
        }
    }

    
}
