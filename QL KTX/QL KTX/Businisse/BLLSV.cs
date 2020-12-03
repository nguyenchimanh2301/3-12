using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
using QL_KTX.DataAcessLayer;
using QL_KTX.DataAcessLayer.IDAL;
using QL_KTX.Businisse.IBLL;

namespace QL_KTX.Businisse
{
    class BLLSV : ISVBLL
    {
        private ISVDAL dalsv = new DALSV();
        public List<SV> LSV()
        {
            return dalsv.LSV();
        }
        public void themsv(SV s)
        {
            if (!string.IsNullOrEmpty(s.Masv))
            {
                dalsv.themSV(s);
            }
            else
                throw new Exception("dữ liệu sai");
        }

        public void xoasv(string masv)
        {
            int i;
            List<SV> list = dalsv.LSV();
            for (i = 0; i < list.Count; i++)
                if (list[i].Masv == masv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                dalsv.Update(list);
            }
            else
                throw new Exception("không tồn tại mã sv");
        }
        public void suattsv(SV s)
        {
            int i;
            List<SV> list = dalsv.LSV();
            for (i = 0; i < list.Count; i++)
                if (list[i].Masv == s.Masv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(s);
                dalsv.Update(list);
            }
            else
                throw new Exception("không tồn tại mã sv");
        }

        public List<SV> timsv(SV  s)
        {
            List<SV> list = dalsv.LSV();
            List<SV> timsv = new List<SV>();
            if (string.IsNullOrEmpty(s.Masv) && string.IsNullOrEmpty(s.Tensv) && string.IsNullOrEmpty(s.Tenlop))
            {
                timsv = list;
            }
            else if (!string.IsNullOrEmpty(s.Tensv))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Masv.IndexOf(s.Masv) >= 0)
                    {
                        timsv.Add(new SV(list[i]));
                    }
            }
            else if (!string.IsNullOrEmpty(s.Masv))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Masv.IndexOf(s.Masv) >= 0)
                    {
                        timsv.Add(new SV(list[i]));
                    }
            }
            else if (!string.IsNullOrEmpty(s.Maph))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Maph.IndexOf(s.Maph) >= 0)
                    {
                        timsv.Add(new SV(list[i]));
                    }
            }
            else if (!string.IsNullOrEmpty(s.Tenlop))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Tenlop.IndexOf(s.Tenlop) >= 0)
                    {
                        timsv.Add(new SV(list[i]));
                    }
            }

            else
                timsv = null;
            return timsv;
        }
    }
}
