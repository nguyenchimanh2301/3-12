using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;
namespace QL_KTX.Businisse.IBLL
{
    interface ISVBLL
    {
        List<SV> LSV();
        void themsv(SV s);
        void xoasv(string masv);
        void suattsv(SV s);
        List<SV> timsv(SV s);
    }
}
