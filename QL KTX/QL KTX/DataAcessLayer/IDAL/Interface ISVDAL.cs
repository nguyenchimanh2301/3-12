using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Entities;

namespace QL_KTX.DataAcessLayer.IDAL
{
    interface ISVDAL
    { 
            List<SV> LSV();
            void themSV(SV s);
            void Update(List<SV> list);
        }
    }


