using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QL_KTX.Entities;
using System.Threading.Tasks;

namespace QL_KTX.Businisse.IBLL
{
    interface IPhongktBLL
    {
        List <Phongkt> Lphong();
        void themphong(Phongkt p);
        void xoaphong(string maphong);
        void suaphong(Phongkt p);
        List<Phongkt> timphong(Phongkt p);
    }
        
}
