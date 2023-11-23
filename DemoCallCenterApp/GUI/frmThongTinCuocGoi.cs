using DemoCallCenterApp.BUS;
using DemoCallCenterApp.DAO;
using DemoCallCenterApp.DTO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DemoCallCenterApp
{
    public partial class frmThongTinCuocGoi : Form
    {
        ThongTinCuocGoiBUS cuocGoiBUS = new ThongTinCuocGoiBUS();
        DuongBUS duongBUS = new DuongBUS();
        public frmThongTinCuocGoi()
        {
            InitializeComponent();
            
        }

        private void cboPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataTable = duongBUS.LayDsDuong();
            cboDuong.DataSource = dataTable;
            cboDuong.DisplayMember = "ten";
            cboThanhPho.SelectedIndex = 0;
        }

        private void btnDieuPhoi_Click(object sender, EventArgs e)
        {
            ThongTinCuocGoi cuocGoi = LayThongTinCuocgoi();

            var kq = cuocGoiBUS.Them(cuocGoi);

            if(kq > 0)
            {
                MessageBox.Show("Thêm cuốc gọi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string thongbao = "";
                switch (kq)
                {
                    case -1:
                        thongbao = "Phai nhap so dien thoai!!!!";
                        break;
                    case -2:
                        thongbao = "Chua co dia chi don!!!!";
                        break;
                }

                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ThongTinCuocGoi LayThongTinCuocgoi()
        {
            ThongTinCuocGoi kq = new ThongTinCuocGoi();

            kq.TenKH = txtTenKH.Text;
            kq.SDT = txtSDT.Text;
            kq.SoNha = txtSoNha.Text;
            kq.Duong = cboDuong.Text;
            kq.Phuong = cboPhuong.Text;
            kq.Quan = cboQuan.Text;
            kq.ThanhPho = cboThanhPho.Text;

            var loaiXe = this.groupBox2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            kq.LoaiXe = int.Parse(loaiXe.Tag.ToString());
            
            return kq;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {

            var dataTable = cuocGoiBUS.LayDsCuocGoiGanNhat(txtSDT.Text);

            int stt = 1;
            foreach(DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(stt++.ToString());
                item.SubItems.Add(row["ThoiGian"].ToString());
                item.SubItems.Add(row["DiaChiDon"].ToString());
                item.SubItems.Add(row["LoaiXe"].ToString());
                item.SubItems.Add(row["TinhTrang"].ToString());

                lstCuocGoiGanNhat.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}