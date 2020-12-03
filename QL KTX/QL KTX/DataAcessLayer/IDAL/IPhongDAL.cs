using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;

namespace QL_KTX.DataAcessLayer.IDAL
{
     interface IPhongDAL
    {
        List<Phongkt> Lphong();
        void themphong(Phongkt p);
        void Update(List<Phongkt> list);
    }
}
