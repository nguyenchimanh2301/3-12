using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Entities
{
    class SV
    {
        private string maph;
        private string masv;
        private string tensv;
        private string gioitinh;
        private string tenlop;
        private string diachi;
        private int  Sdt;

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        public string Maph { get => maph; set => maph = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Sdt1 { get => Sdt; set => Sdt = value; }
        public SV(SV sv)

        {
            this.maph = sv.maph;
            this.masv = sv.masv;
            this.tensv = sv.tensv;
            this.gioitinh = sv.gioitinh;
            this.tenlop = sv.Tenlop;
            this.diachi = sv.Diachi;
            this.Sdt1 = sv.Sdt1;
            
        }
        public SV(string maph, string masv, string tensv, string gioitinh, string diachi, string tenlop, int Sdt)
        {
            this.maph = maph;
            this.masv = masv;
            this.tensv = tensv;
            this.gioitinh = gioitinh;
            this.tenlop = tenlop;
            this.diachi = diachi;
            this.Sdt1 = Sdt;
        }
        public SV()
        {
            
        }
    }
}
    

