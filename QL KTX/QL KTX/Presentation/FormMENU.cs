using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Presentation
{
   public  class FormMENU
    {
        GD gd = new GD(100, 50);
        FormPhong fp = new FormPhong();
        FormSV fsv = new FormSV();
        Formhoadon fh = new Formhoadon();
        public void start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;
            gd.pain("╔", 0, 0);
            gd.pain("╚", 0, 45);
            gd.pain("╗", 99, 0);
            gd.pain("╝", 99, 45);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 45);
            for (int i = 1; i < 45; ++i)
            {
                gd.pain("║", 0, i);
                gd.pain("║", 99, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            gd.pain("CHUONG TRINH QUAN LI KI TUC XA TRUONG DAI HOC SPKT HY", 22, 1);
            gd.pain("KÍ TÚC XÁ", 44, 24);
            gd.pain("TRƯỜNG ĐẠI HỌC SƯ PHAM KĨ THUẬT HƯNG YÊN", 30, 25);
            gd.pain("GIẢNG VIÊN HƯỚNG DẪN                     THẦY NGUYỄN VĂN QUYẾT", 15, 28);
            gd.pain("SINH VIÊN THỰC HIỆN                      NGUYỄN CHÍ MẠNH", 15, 31);
            gd.pain("LỚP                                      101191", 15, 34);
            gd.pain("MÃ SINH VIÊN                             10119539", 15, 37);
            gd.pain("NGÀNH                                    CÔNG NGHỆ PHẦN MỀM", 15, 40);
            gd.pain("      ******   *****      **    **********   *********         ", 20, 15);
            gd.pain("   **          **  **     **        **           **            ", 20, 16);
            gd.pain("  **           **   **    **        **           **            ", 20, 17);
            gd.pain("  **           **    **   **        **           **            ", 20, 18);
            gd.pain(" ***           **     **  **        **           **            ", 20, 19);
            gd.pain("  **           **      ** **        **           **            ", 20, 20);
            gd.pain("   **          **       ****        **           **            ", 20, 21);
            gd.pain("     *******   **        ***        **           **            ", 20, 22);
            gd.pain("  NHẤN PHÍM ENTER ĐỂ VÀO GIAO DIỆN ĐĂNG NHẬP....      ", 20, 43);



            Console.ForegroundColor = ConsoleColor.Blue;
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 15; i < 45; ++i)
            {
                gd.pain("****", 3, i);
                gd.pain("****", 93, i);
            }
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            gd.pain("  *******              *****                   ***           ****         **   *****       ", 7, 5);
            gd.pain("  **      **        **       **               **  **         **  **       **    ***        ", 7, 6);
            gd.pain("  **       **      **          **            **    **        **    **     **    ***        ", 7, 7);
            gd.pain("  **        **    **           **           **********       **     **    **    ***        ", 7, 8);
            gd.pain(" ****       **    **           **          ************      **      **   **    ***        ", 7, 9);
            gd.pain("  **      **      **           **         **          **     **       **  **    ***        ", 7, 10);
            gd.pain("  **     **        **         **         **            **    **         ****    ***        ", 7, 11);
            gd.pain("  ******               *****            **              **   **          ***   *****        ", 7, 12);
            gd.pain("══════╦════════════════════════════════════════════════════════════════════════════════════╦══════", 1, 14);


            for (int i = 15; i < 45; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);
            }

            gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╣", 7, 23);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 26);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 29);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 32);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 35);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 38);
            for (int i = 27; i < 41; ++i)
            {
                gd.pain("║", 39, i);

            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 41);


        menu: Console.SetCursorPosition(68, 43);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Enter: Console.Clear(); menu1(); break;
                case ConsoleKey.Escape:Console.Clear();; break;   
                default:
                    gd.pain("SAI PHIM!!MỜI BẤM LẠI", 30, 45);
                    goto menu;
            }
        }
        public void menu1()
        {
            {
                for (int i = 8; i < 19; ++i)
                {
                    gd.pain("║", 7, i);
                    gd.pain("║", 92, i);

                }
                gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
                gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);


                for (int i = 11; i < 19; ++i)
                {

                    gd.pain("║", 39, i);
                }
                gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 19);
                gd.pain("KÍ TÚC XÁ ĐẠO HỌC SƯ PHẠM KĨ THUẬT HƯNG YÊN", 17, 9);
                gd.pain("F1", 9, 12); gd.pain("CHƯƠNG TRÌNH QUẢN LÍ", 60, 12);
                gd.pain("F2", 9, 15); gd.pain("THỐNG KÊ", 60, 15);
                gd.pain("F3", 9, 18); gd.pain("THOÁT", 60, 18);
                gd.pain("mời nhập thao tác..", 25, 25); Console.SetCursorPosition(60, 25);
            tt:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1: Console.Clear(); menu(); break;
                    case ConsoleKey.F3: Environment.Exit(0);break;
                    default:
                        gd.pain("SAI PHIM!!MOI BAM LAI", 30, 45);
                        goto tt;
                }
            }
        }

        public void menu()
        {
            for (int i = 8; i < 22; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);

            }
            gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);

            for (int i = 11; i < 22; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 22);
            gd.pain("CÁC THAO TÁC QUẢN LÍ KTX", 35, 8);
            gd.pain("F1", 9, 12); gd.pain("PHÒNG  KÍ TÚC", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("SINH VIEN", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("HÓA ĐƠN", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("TRỞ LẠI", 60, 21);
        den:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); fp.menuphong(); break;
                case ConsoleKey.F2: Console.Clear(); fsv.menusv(); break;
                case ConsoleKey.F3: Console.Clear(); fh.menuhd(); break;
                case ConsoleKey.F4: Console.Clear();menu1(); break;
                default:
                    gd.pain("SAI THAO TÁC,ẤN LẠI THAO TÁC", 26, 26);
                    goto den;
            }
        }
    }
}

    

