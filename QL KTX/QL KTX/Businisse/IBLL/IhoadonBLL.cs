using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
namespace QL_KTX.Businisse.IBLL
{
    interface IhoadonBLL
    {
        List<Hoadon> Lhoadon();
        void themh(Hoadon h);
        void xoahd(string maph);
        void suahd(Hoadon h);
        List<Hoadon> timhd(Hoadon h);
    }
}
