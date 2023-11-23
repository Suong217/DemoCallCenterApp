using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCallCenterApp.DAO
{
    public class DuongDAO : Db
    {
        public DataTable LayDsDuong()
        {
            string sql = string.Format("Select * from Duong");

            return LayDuLieu(sql);
        }
    }
}
