using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;
using QL_KTX.Businisse;
using QL_KTX.DataAcessLayer;

namespace QL_KTX.Presentation
{
    class Formhoadon
    {
        private HoadonBLL hdbll = new HoadonBLL();
        GD gd = new GD(100, 50);
        //FormMENU menu = new FormMENU();
        public void menuhd()
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
            gd.pain("CÁC THAO TÁC QUẢN LÍ HÓA ĐƠN", 30, 9);
            gd.pain("F1", 9, 12); gd.pain("THÊM HÓA ĐƠN", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("HIỆN THÔNG TIN", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("SỬA THÔNG TIN HÓA ĐƠN", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("XÓA HÓA ĐƠN", 60, 21);
            gd.pain("F5", 9, 24); gd.pain("TRỞ LẠI", 60, 24);
        sv: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); them(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); suahd(); break;
                case ConsoleKey.F4: Console.Clear(); xoahd(); break;
                case ConsoleKey.F5: Console.Clear(); menu.menu(); break;
                default:
                    goto sv;
            }
        }
        public int tinhiennuoc()
        {
            int nc = 0;
            List<Hoadon> list = hdbll.Lhoadon();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Sonuoc <= 50)
                {
                    nc = list[i].Sonuoc * 20;
                }
                else if (list[i].Sonuoc > 50 && list[i].Soswdien < 100)
                {
                    nc = (50 * 20) + (list[i].Sonuoc - 50) * 40;
                }
                else
                    nc = (50 * 20) + (50 * 40) + (list[i].Soswdien - 100) * 60;
            }
            return nc;
        }
        public int tienphong()
        {
            int tp = 0;
            List<Hoadon> list = hdbll.Lhoadon();
            for (int i = 0; i < list.Count; i++)
            {
                tp = list[i].Tgiano * 120;
            }
            return tp;
        }
        public int tinhiendien()
        {
            int td = 0;
            List<Hoadon> list = hdbll.Lhoadon();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Soswdien <= 50)
                {
                    td = list[i].Soswdien * 20000;
                }
                else if (list[i].Soswdien > 50 && list[i].Soswdien < 100)
                {
                    td = (50 * 20000) + (list[i].Soswdien - 50) * 40000;
                }
                else
                    td = (50 * 20000) + (50 * 40000) + (list[i].Soswdien - 100) * 60000;
            }
            return td;
        }

        public void them()
        {
            Hoadon hd = new Hoadon();
            gd.pain("THÊM HÓA ĐƠN", 40, 9);
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
                Console.SetCursorPosition(50, 12); hd.Maph = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không  có thông tin mời nhập lại");
                goto maph;
            }

        sw: gd.pain("", 50, 15);
            try
            {
                Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập số điện đã dùng");
                Console.SetCursorPosition(50, 15); hd.Soswdien = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto sw;
            }
        sn: gd.pain("", 50, 18);
            try
            {
                Console.SetCursorPosition(9, 18); Console.WriteLine("Nhập số nước đã dùng");
                Console.SetCursorPosition(50, 18); hd.Sonuoc = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu sai,mời nhập lại");
                goto sn;
            }
        gt: gd.pain("", 50, 21);
            try
            {
                Console.SetCursorPosition(9, 21); Console.WriteLine("nhập thời gian ở");
                Console.SetCursorPosition(50, 21); hd.Tgiano = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto gt;
            }
        dc: gd.pain("", 50, 24);
            try
            {
                Console.SetCursorPosition(9, 24); Console.WriteLine("nhập tiền vệ sinh");
                Console.SetCursorPosition(50, 24); hd.Tienvesinh = int .Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto dc;
            }
        tl: gd.pain("", 50, 27);
            try
            {
                Console.SetCursorPosition(9, 27); Console.WriteLine("nhập tiền khác(nếu có)");
                Console.SetCursorPosition(50, 27); hd.Tkhac = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto tl;
            }
            Console.WriteLine(" tong tien");
            hd.Tt = hd.Tienvesinh + hd.Tkhac + tienphong() + tinhiendien() + tinhiennuoc();
            hdbll.themh(hd);
        svs:
            gd.pain("F1", 20, 33); gd.pain("THÊM VÀ NHẬP TIẾP", 30, 33);
            gd.pain("F2", 20, 34); gd.pain("THÊM VÀ TRỞ VỀ", 30, 34);
            gd.pain("F3", 20, 35); gd.pain("HIỆN THÔNG TIN", 30, 35);
            gd.pain("F4", 20, 36); gd.pain("TRỞ LẠI", 30, 36);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: hdbll.themh(hd); Console.Clear(); them(); Console.Clear(); break;
                case ConsoleKey.F2: Console.Clear(); them(); Console.Clear(); break;
                case ConsoleKey.F3: Console.Clear(); hien(); break;
                case ConsoleKey.F4: Console.Clear(); menuhd(); break;
                default:
                    Console.WriteLine("sai thao tác!! mời nhập lại");
                    goto svs;
            }
          
        }
        
        
        public void hien()
        {
            List<Hoadon> list = hdbll.Lhoadon();
            Console.WriteLine("\n\n\n\n\n\n\n");
            foreach (var p in list)
            {
                Console.WriteLine("   " + p.Maph + "\t\t" + p.Soswdien + "\t\t" + p.Sonuoc + "\t" + p.Tgiano + "\t\t" + p.Tienvesinh + "\t" + p.Tkhac + "\t\t"+p.Tt); 
            }
            for (int i = 5; i < 45; ++i)
            {
                gd.pain("║", 2, i);
                gd.pain("║", 95, i);
            }
            gd.pain("MÃ PHÒNG", 3, 6); gd.pain("SỐ ĐIỆN(kw)", 12, 6); gd.pain("SỐ NƯỚC(m/3)", 24, 6); gd.pain("TG thuê(tháng)",37, 6); gd.pain("$ VỆ SINH(VND)", 52, 6); gd.pain("$ KHÁC(VND)", 69, 6); gd.pain("TỔNG TIỀN(VND)",78, 6);

            gd.pain("╔════════╦═══════════╦════════════╦══════════════╦══════════════╦═════════════╦═════════════════╗", 2, 4);
            gd.pain("╚════════╩═══════════╩════════════╩══════════════╩══════════════╩═════════════╩═════════════════╝", 2, 45);
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
                gd.pain("║", 36, i);
                gd.pain("║", 51, i);
                gd.pain("║", 66, i);
                gd.pain("║", 81, i);
            }

            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU HÓA ĐƠN", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            menuhd:
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuhd(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto menuhd;
            }
        }
        public void suahd()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA HON");
            List<Hoadon> list = hdbll.Lhoadon();
            string maph;
            Console.Write("Nhập mã phòng cần sửa hóa đơn:");
            maph= Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == maph) break;

            if (i < list.Count)
            {
                Hoadon s = new Hoadon(list[i]);
                Console.Write("Nhập mã phòng mới:");
                string mpm = Console.ReadLine();
                if (!string.IsNullOrEmpty(mpm)) s.Maph = mpm;
                Console.Write("Nhập số điện mới");
                int sw = int.Parse(Console.ReadLine());
                if (sw>0) s.Soswdien= sw;
                Console.Write("Nhập số nước mới");
                int sn = int.Parse(Console.ReadLine());
                if (sn > 0) s.Sonuoc = sn;
                Console.Write("Nhập thời gian ở");
                int tg = int.Parse(Console.ReadLine());
                if (tg > 0) s.Tgiano = tg;
                Console.Write("Nhập tiền khác mới");
                int  tk = int.Parse(Console.ReadLine());
                if (tk >= 0) s.Tkhac = tk;
                hdbll.suahd(s);
            }
            else
            {
                Console.WriteLine("không tồn tại mã hóa đơn");
            }

            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU HÓA ĐƠN", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            menuhd:
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuhd(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto menuhd;
            }

        }
        public void xoahd()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("XOÁ THÔNG TIN HÓA ĐƠN");
            List<Hoadon> list = hdbll.Lhoadon();
            string maph;
            Console.Write("nhập mã phòng muốn xóa hóa đơn");
            maph = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == maph) break;

            if (i < list.Count)
            {
                Hoadon hd = new Hoadon(list[i]);
                hdbll.xoahd(maph);
            }
            else
            {
                Console.WriteLine("không tồn tại mã hóa đơn");
            }
        xoaphong:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {

                case ConsoleKey.Tab: Console.Clear();menuhd(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto xoaphong;
            }

        }
    }

}




