using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.DataAcessLayer;
using QL_KTX.DataAcessLayer.IDAL;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;

namespace QL_KTX.Businisse
{
    class HoadonBLL:IhoadonBLL
    {
        private IhoadonDAL hddal = new DALhoadon();

        public List<Hoadon> Lhoadon()
        {
            return hddal.LHOADON();
        }
        public void themh(Hoadon h)
        {
            if (!string.IsNullOrEmpty(h.Maph))
            {
                hddal.themhdon(h);
            }
            else
                throw new Exception("dữ liệu sai");

        }
        public void xoahd(string maph)
        {
            int i;
            List<Hoadon> list = Lhoadon();
            for (i = 0; i < list.Count; i++)
                if (list[i].Maph == maph) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hddal.update(list);
            }
            else
                throw new Exception("không tồn tại mã phòng");
        }
        public void suahd(Hoadon h)
        {
            int i;
            List<Hoadon> list = Lhoadon();
            for (i = 0; i < list.Count; i++)
                if (list[i].Maph ==h.Maph) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(h);
                hddal.update(list);
            }
            else
                throw new Exception("không tồn tại mã phòng");
        }

        
        public List<Hoadon> timhd(Hoadon h)
        {
            List<Hoadon> list = Lhoadon();
            List<Hoadon> hd = new List<Hoadon>();
            if(!string.IsNullOrEmpty(h.Maph))
            {
                hd = list;
            }
            if (!string.IsNullOrEmpty(h.Maph))
            {
                for (int i = 0; i < list.Count; i++)
                    if (list[i].Maph.IndexOf(h.Maph) >= 0)
                    {
                        hd.Add(new Hoadon(list[i]));
                    }
            }
            else hd = null;
            return hd;
        }   
    }
}
