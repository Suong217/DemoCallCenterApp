using DemoCallCenterApp.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCallCenterApp.BUS
{
    public class DuongBUS
    {
        DuongDAO duongDAO = new DuongDAO();
        public DataTable LayDsDuong()
        {
            return duongDAO.LayDsDuong();
        }
    }
}
