using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;

namespace QL_KTX.DataAcessLayer.IDAL
{
    interface IhoadonDAL
    {
        List<Hoadon> LHOADON();
        void themhdon(Hoadon h);
        void update(List<Hoadon> list);

    }
}
