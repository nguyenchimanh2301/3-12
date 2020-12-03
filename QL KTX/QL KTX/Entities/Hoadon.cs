using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Entities
{
    class Hoadon
    {
        private string maph;
        private int sowdien;
        private int sonuoc;
        private int  tienvesinh;
        private int tgiano;
        private int tkhac;
        private int tt;
       
        public string  Maph { get => maph; set => maph = value; }
        public int Soswdien { get => sowdien; set => sowdien = value; }
        public int Sonuoc { get => sonuoc; set => sonuoc = value; }
        public int Tienvesinh { get => tienvesinh; set => tienvesinh = value; }
        public int Tgiano { get => tgiano; set => tgiano = value; }
        public int Tkhac { get => tkhac; set => tkhac = value; }
        public int Tt { get => tt; set => tt = value; }

        public Hoadon(Hoadon d)
        {
            this.maph = d.maph;
            this.sowdien = d.sowdien;
            this.Tienvesinh = d.Tienvesinh;
            this.Tkhac = d.Tkhac;
            this.Tgiano = d.Tgiano;
            this.sonuoc = d.sonuoc;
            this.tt = d.tt;
        }
        public Hoadon(string maph, int sowdien, int sonuoc, int tgiano, int tienvesinh, int tkhac, int tt)
        {
            this.maph = maph;
            this.sowdien = sowdien;
            this.sonuoc = sonuoc;
            this.tienvesinh = tienvesinh;
            this.Tkhac = tkhac;
            this.Tgiano = tgiano;
            this.tt = tt;
        }
        public Hoadon()
        {

        }
    }
}

    

