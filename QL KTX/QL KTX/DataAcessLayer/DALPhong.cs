using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
using System.IO;
using QL_KTX.DataAcessLayer.IDAL;

namespace QL_KTX.DataAcessLayer
{
        class DALphong : IPhongDAL
        {
            private string ptxtflie = "Data/Phong.txt";
            public List<Phongkt> Lphong()
            {
                List<Phongkt> list = new List<Phongkt>();
                StreamReader sr = File.OpenText(ptxtflie);
                string s = sr.ReadLine();
                while (s != null)
                {
                    if (s != "")
                    {
                        string[] a = s.Split('#');
                        list.Add(new Phongkt(a[0], a[1], int.Parse(a[2]), int.Parse(a[3]), a[4]));
                    }
                    s = sr.ReadLine();
                }
                sr.Close();
                return list;
            }
            public void themphong(Phongkt p)
            {
                StreamWriter fwrite = File.AppendText(ptxtflie);
                fwrite.WriteLine();
                fwrite.Write(p.Maph + "#" + p.Tenday + "#" + p.Soluongmax + "#" + p.Dango + "#" + p.Tinhtrang);
                fwrite.Close();

            }
            public void Update(List<Phongkt> list)
            {
                StreamWriter fwrite = File.CreateText(ptxtflie);
                for (int i = 0; i < list.Count; ++i)
                    fwrite.WriteLine(list[i].Maph + "#" + list[i].Tenday + "#" + list[i].Soluongmax + "#" + list[i].Dango + "#" + list[i].Tinhtrang);
                fwrite.Close();
            }
        }
    }


