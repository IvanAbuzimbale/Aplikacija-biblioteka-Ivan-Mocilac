using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaKnjigaIvanMočilac20122012
{
    class Posudba
    {
        DateTime datum_p;
        DateTime datum_v;
        int id_knjige;
        int id_kor;
        
        public Posudba(DateTime datum_p, DateTime datum_v, int id_knjige, int id_kor)
        {
            this.datum_p = datum_p;
            this.datum_v = datum_v;
            this.id_knjige = id_knjige;
            this.id_kor = id_kor;
        }

        public DateTime Datum_p { get => datum_p; set => datum_p = value; }
        public DateTime Datum_v { get => datum_v; set => datum_v = value; }
        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public int Id_kor { get => id_kor; set => id_kor = value; }
    }
}
