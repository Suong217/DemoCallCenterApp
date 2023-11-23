using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCallCenterApp.DTO
{
    public class ThongTinCuocGoi
    {
        public int id { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChiDon
        {
            get
            {
                string kq = string.Join(", ",
                    new string[] { SoNha, Duong, Phuong, Quan, ThanhPho });
                return kq;
            }
        }

        public float DiaChiDon_Lat { get; set; }
        public float DiaChiDon_Long { get; set; }
        public string SoNha { get; set; }
        public string Duong { get; set; }
        public string Phuong { get; set; }
        public string Quan { get; set; }
        public string ThanhPho { get; set; }
        public int LoaiXe { get; set; }
        public int TinhTrang { get; set; }
        public DateTime ThoiGian { get; set; }

    }
}
