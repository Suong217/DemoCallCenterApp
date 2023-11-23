using DemoCallCenterApp.DAO;
using DemoCallCenterApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCallCenterApp.BUS
{
    public class ThongTinCuocGoiBUS
    {
        ThongTinCuocGoiDAO cuocGoiDAO = new ThongTinCuocGoiDAO();
        public int Them(ThongTinCuocGoi cuocGoi)
        {
            if (string.IsNullOrEmpty(cuocGoi.SDT)) return -1;
            if (string.IsNullOrEmpty(cuocGoi.SoNha)) return -2;

            return cuocGoiDAO.Them(cuocGoi);
        }

        public DataTable LayDsCuocGoiGanNhat(string sdt)
        {
            return cuocGoiDAO.LayDsCuocGoiGanNhat(sdt);
        }
    }
}
