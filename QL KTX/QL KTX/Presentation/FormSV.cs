using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;
using QL_KTX.Businisse;
using QL_KTX.DataAcessLayer;

namespace QL_KTX.Presentation
{
    class FormSV
    {
        private BLLSV svbll = new BLLSV();
        GD gd = new GD(100, 50);
      
        public void menusv()
            {
            FormMENU menu = new FormMENU();

            for (int i = 8; i < 25; ++i)
                {

                    gd.pain("║", 7, i);
                    gd.pain("║", 92, i);
                }

                gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 13);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);

                for (int i = 11; i < 25; ++i)
                {

                    gd.pain("║", 39, i);
                }
                gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 25);
                gd.pain("CÁC THAO TÁC QUẢN LÍ SINH VIÊN", 30, 9);
                gd.pain("F1", 9, 12); gd.pain("THÊM SINH VIÊN", 60, 12);
                gd.pain("F2", 9, 15); gd.pain("HIỆN THÔNG TIN", 60, 15);
                gd.pain("F3", 9, 18); gd.pain("SỬA THÔNG TIN SINH VIÊN", 60, 18);
                gd.pain("F4", 9, 21); gd.pain("XÓA SINH VIÊN", 60, 21);
                gd.pain("F5", 9, 24); gd.pain("TRỞ LẠI", 60, 24);
            sv: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1: Console.Clear(); them(); break;
                    case ConsoleKey.F2: Console.Clear(); hien(); break;
                    case ConsoleKey.F3: Console.Clear(); suasv();break;
                    case ConsoleKey.F4: Console.Clear(); xoasv(); break;
                    case ConsoleKey.F5: Console.Clear(); menu.menu(); break;
                default:
                        goto sv;
                }
            }
            public void them()
            {
            Console.InputEncoding = Encoding.UTF8;
            SV sv = new SV();
            gd.pain("THÊM SINH VIÊN", 40, 9);
                for (int i = 8; i < 31; ++i)
                {
                    gd.pain("║", 7, i);
                    gd.pain("║", 92, i);

                }
                gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
                gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 25);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 28);

            for (int i = 11; i < 31; ++i)
                {

                    gd.pain("║", 39, i);
                }
                gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 31);
            maph: gd.pain("", 60, 9); ;
                try
                {
                    Console.SetCursorPosition(9, 12); Console.WriteLine("Nhập mã phòng");
                    Console.SetCursorPosition(50, 12); sv.Maph = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin moi nhap lai");
                    goto maph;
                }

            masv: gd.pain("", 50, 15);
                try
                {
                    Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập mã sinh viên");
                    Console.SetCursorPosition(50, 15); sv.Masv = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                    goto masv;
                }
            ht: gd.pain("", 50, 18);
                try
                {
                    Console.SetCursorPosition(9, 18); Console.WriteLine("Nhập tên sinh viên");
                    Console.SetCursorPosition(50, 18); sv.Tensv = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                    goto ht;
                }
            gt: gd.pain("", 50, 21);
                try
                {
                    Console.SetCursorPosition(9, 21); Console.WriteLine("giới tính học sinh là");
                    Console.SetCursorPosition(50, 21); sv.Gioitinh = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                    goto gt;
                }
            dc: gd.pain("", 50, 24);
                try
                {
                    Console.SetCursorPosition(9, 24); Console.WriteLine("nhập địa chỉ");
                    Console.SetCursorPosition(50, 24); sv.Diachi = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                    goto dc;
                }
          tl: gd.pain("", 50, 27);
            try
            {
                Console.SetCursorPosition(9, 27); Console.WriteLine("nhập tên lớp");
                Console.SetCursorPosition(50, 27); sv.Tenlop = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto tl;
            }
        sdt: gd.pain("", 50, 24);
            try
            {
                Console.SetCursorPosition(9, 30); Console.WriteLine("nhập số điện thoại");
                Console.SetCursorPosition(50, 30); sv.Sdt1 = int.Parse( Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto sdt;
            }
            svbll.themsv(sv);
            svs:
                gd.pain("F1", 20, 33); gd.pain("THÊM VÀ NHẬP TIẾP", 30,33);
                gd.pain("F2", 20, 34); gd.pain("HIỆN THÔNG TIN", 30, 34);
                gd.pain("F3", 20, 35); gd.pain("TRỞ LẠI", 30,35);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:;Console.Clear(); them(); Console.Clear(); break;
                    case ConsoleKey.F2: Console.Clear(); hien(); break;
                    case ConsoleKey.F3: Console.Clear(); menusv(); break;
                    default:
                    Console.WriteLine("sai thao tác!! mời nhập lại");
                        goto svs;
                }
            }
            public void hien()
            {
            List<SV> list = svbll.LSV();
                Console.WriteLine("\n\n\n\n\n\n\n");
                foreach (var p in list)
                {

                    Console.WriteLine("   "+ p.Maph + "        " + p.Masv + "        " + p.Tensv + "        " + p.Gioitinh+ "    "+ p.Diachi+"     "+p.Tenlop+"       "+p.Sdt1);
                }
                for (int i = 5; i < 45; ++i)
                {
                    gd.pain("║", 2, i);
                    gd.pain("║", 95, i);
                }
                gd.pain("MÃ PHÒNG", 3, 6); gd.pain(" MÃ SV", 14, 6); gd.pain("HỌ TÊN", 30, 6); gd.pain("GIỚI TÍNH", 44, 6); gd.pain("ĐỊA CHỈ", 55, 6); gd.pain("TÊN LỚP",67, 6); gd.pain("SỐ ĐT", 85, 6);

            gd.pain("╔════════╦═══════════╦═══════════════════╦═════════╦═══════════╦═══════════╦═════════════════╗", 2, 4);
            gd.pain("╚════════╩═══════════╩═══════════════════╩═════════╩═══════════╩═══════════╩═════════════════╝", 2, 45);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦════════════════════════════════════╣", 7, 7);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 10);
            //gd.pain("╠══════════════╦════════════╬══════════════════╦═══════════════════╦════════════════╣", 7, 13);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 16);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 19);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 22);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 25);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 28);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 31);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 34);
            //gd.pain("╠══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╣", 7, 37);
            for (int i = 5; i < 45; ++i)
                {
                    gd.pain("║", 11, i);
                    gd.pain("║", 23, i);
                    gd.pain("║", 43, i);
                    gd.pain("║", 53, i);
                    gd.pain("║", 65, i);
                    gd.pain("║", 77, i);
            }
               
                gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
                ConsoleKeyInfo kt = Console.ReadKey();
            menuss:
                switch (kt.Key)
                {
                    case ConsoleKey.Tab: Console.Clear();menusv(); break;
                    default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto menuss;
            }

            }
            public void suasv()
            {
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();
                Console.WriteLine("SỬA THÔNG TIN SINH VIÊN");
                List<SV> list = svbll.LSV();
                string masv;
                Console.Write("Nhập mã sinh viên cần sửa:");
                masv = Console.ReadLine();
                int i = 0;
                for (i = 0; i < list.Count; ++i)
                    if (list[i].Maph == masv)break;

                if (i < list.Count)
                {
                    SV s = new SV(list[i]);
                    Console.Write("Nhập mã phòng mới:");
                    string mpm = Console.ReadLine();
                if (!string.IsNullOrEmpty(mpm)) s.Maph = mpm;
                    Console.Write("Nhập tên sv mới");
                    string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) s.Tensv = ten;
                    Console.WriteLine("giới tính mới");
                    string gtm = Console.ReadLine();
                if (!string.IsNullOrEmpty(gtm)) s.Gioitinh = gtm;
                Console.WriteLine("địa chỉ mới");
                string dcm = Console.ReadLine();
                if (!string.IsNullOrEmpty(dcm)) s.Diachi = dcm;
                Console.WriteLine("tên lớp mới");
                string tlm = Console.ReadLine();
                if (!string.IsNullOrEmpty(tlm)) s.Tenlop = tlm;
                Console.WriteLine("số điện thoại mới");
                int sdtm = int.Parse(Console.ReadLine());
                if (sdtm>0) s.Sdt1 = sdtm;
                svbll.suattsv(s);
                }
                else
                {
                    Console.WriteLine("không tồn tại mã sinh viên");
                }

                gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
                ConsoleKeyInfo kt = Console.ReadKey();
            suasv:
                switch (kt.Key)
                {
                    case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                    default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto suasv;
            }

            }
            public void xoasv()
            {
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("XOÁ THÔNG TIN SINH VIÊN");
                List<SV> list = svbll.LSV();
                string masv;
                Console.Write("nhập mã sinh viên muốn xóa");
                masv = Console.ReadLine();
                int i = 0;
                for (i = 0; i < list.Count; ++i)
                    if (list[i].Masv == masv) break;

                if (i < list.Count)
                {
                    SV  sv = new SV(list[i]);
                svbll.xoasv(masv);
                }
                else
                {
                    Console.WriteLine("không tồn tại mã sv");
                }
            xoasv:
                gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                   
                    case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                    default:
                        Console.WriteLine("sai thao tác! mời nhập lại");
                        goto xoasv;
                }

            }
        }

    }




