using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using QL_KTX.DataAcessLayer;
using QL_KTX.DataAcessLayer.IDAL;
using QL_KTX.Entities;

namespace QL_KTX.DataAcessLayer
{
    class DALhoadon : IhoadonDAL
    {
        private string file = "Data/hoadon.txt";
        public List<Hoadon> LHOADON()
        {
            List<Hoadon> list = new List<Hoadon>();
            StreamReader sr = File.OpenText(file);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = new string[7];
                     a = s.Split('#');
                    list.Add(new Hoadon(a[0], int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5]),int.Parse(a[6])));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }

        public void themhdon(Hoadon h)
        {
            StreamWriter fwrite = File.AppendText(file);
            fwrite.WriteLine();
            fwrite.Write(h.Maph + "#" + h.Soswdien + "#" + h.Sonuoc + "#" + h.Tgiano + "#" + h.Tienvesinh + "#" + h.Tkhac+"#"+h.Tt);
            fwrite.Close();
        }


        public void update(List<Hoadon> list)
        {
            StreamWriter sw = File.CreateText(file);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].Maph + "#" + list[i].Soswdien + "#" + list[i].Sonuoc + "#" + list[i].Tgiano + "#" + list[i].Tienvesinh + "#" + list[i].Tkhac+"#"+list[i].Tt);
            sw.Close();
        }
    }
}
