using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;
using QL_KTX.DataAcessLayer.IDAL;
using QL_KTX.DataAcessLayer;
namespace QL_KTX.Businisse
{
    class BLLphong 
    {
        private IPhongDAL pdal = new DALphong();
        public List<Phongkt> LPhong()
        {
            return pdal.Lphong();
        }
        public void themphong(Phongkt p)
        {
            if (!string.IsNullOrEmpty(p.Maph))
            {
                pdal.themphong(p);
            }
            else
                throw new Exception("du lieu sai");
            
        }
          public void xoaphong(string maphong)
        {
            int i;
            List<Phongkt> list = LPhong();
            for ( i = 0; i < list.Count; i++)
                if (list[i].Maph == maphong) break;
            if(i<list.Count)
            {
                list.RemoveAt(i);
                pdal.Update(list);
            }
            else
            {
                throw new Exception("khong ton tai phong nay");
            }
            
        }

        public void suaphong(Phongkt p)
        {
            int i;
            List<Phongkt> list = LPhong();
            for (i = 0; i < list.Count; i++)
                if (list[i].Maph == p.Maph) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(p);
                pdal.Update(list);
            }
            else
            {
                throw new Exception("khong ton tai phong nay");
            }
        }
        public List<Phongkt> timphong(Phongkt p)
        {
            List<Phongkt> list = LPhong();
            List<Phongkt> tim = new List<Phongkt>();
            if(string.IsNullOrEmpty(p.Maph)&&string.IsNullOrEmpty(p.Tenday))
            {
                tim = list;
            }
            if(!string.IsNullOrEmpty(p.Maph))
            {
                for (int i = 0; i < list.Count; i++)
                    if(list[i].Maph.IndexOf(p.Maph)>=0)
                {
                        tim.Add(new Phongkt(list[i]));
                }
            }
            return tim;
        }
    }
}
