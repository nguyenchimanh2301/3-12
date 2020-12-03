using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
using System.IO;
using QL_KTX.DataAcessLayer.IDAL;
namespace QL_KTX.DataAcessLayer
{
    class DALSV: ISVDAL
    {
        private string filesv = "Data/Sinhvien.txt";
        public List<SV> LSV()
        {
            List<SV> list = new List<SV>();
            StreamReader sr = File.OpenText(filesv);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new SV(a[0], a[1], a[2], a[3], a[4], a[5], int.Parse(a[6])));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public void themSV(SV sv)
        {
            StreamWriter fwrite = File.AppendText(filesv);
            fwrite.WriteLine();
            fwrite.Write(sv.Maph + "#" + sv.Masv + "#" + sv.Tensv + "#" + sv.Gioitinh + "#" + sv.Diachi + "#" + sv.Tenlop + "#" + sv.Sdt1);
            fwrite.Close();

        }

        public void Update(List<SV> list)
        {
            StreamWriter sw = File.CreateText(filesv);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].Maph + "#" + list[i].Tensv + "#" + list[i].Gioitinh + "#" + list[i].Diachi + "#" + list[i].Tenlop+"#"+list[i].Sdt1);
            sw.Close();
        }
    }
}
