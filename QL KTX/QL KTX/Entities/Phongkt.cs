using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Entities
{
    class Phongkt
    {
        private string maph;
        private string tenday;
        private int soluongmax;
        private int dango;
        private string tinhtrang;

        public string Maph { get => maph; set => maph = value; }
        public string Tenday { get => tenday; set => tenday = value; }
        public int Soluongmax { get => soluongmax; set => soluongmax = value; }
        public int Dango { get => dango; set => dango = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public Phongkt(Phongkt p)
        {
            this.maph = p.maph;
            this.tenday = p.tenday;
            this.soluongmax = p.soluongmax;
            this.tinhtrang = p.tinhtrang;
            this.dango = p.dango;
        }
        public Phongkt(string maph, string tenday, int soluongmax, int dango, string tinhtrang)
        {
            this.maph = maph;
            this.tenday = tenday;
            this.soluongmax = soluongmax;
            this.tinhtrang = tinhtrang;
            this.dango = dango;
        }
        public Phongkt() { }
    }
}
   

    
    

