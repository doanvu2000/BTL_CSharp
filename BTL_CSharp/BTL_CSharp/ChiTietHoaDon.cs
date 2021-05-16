using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CSharp
{
    public partial class ChiTietHoaDon : Form
    {
        ChiTietHD chiTietHD = new ChiTietHD();
        public int MaHD { get; set; }
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public ChiTietHoaDon(int MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            lbMaHD.Text = chiTietHD.MaHD.ToString();
            getThongTin(this.MaHD);
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            using (DBEntites db = new DBEntites())
            {

                var ct = db.ChiTietHDs.Join(db.SanPhams,
                 p => p.MaSP,
                 c => c.MaSP,
                 (p, c) => new
                 {
                     hd = p,
                     sp = c
                 }).Where(p => p.hd.MaHD == MaHD).Select(p => new
                 {
                     MaSP = p.hd.MaSP,
                     TenSP = p.sp.TenSP,
                     SLBan = p.hd.SLBan,
                     DonGia = p.sp.Gia,
                     ThanhTien = p.hd.SLBan * p.sp.Gia,
                 });
                dgvChiTietHoaDon.DataSource = ct.ToList();
                for (int i = 0; i < dgvChiTietHoaDon.ColumnCount; i++)
                {
                    dgvChiTietHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                int sum = 0;
                for (int i = 0; i < dgvChiTietHoaDon.RowCount; i++)
                {
                    DataGridViewRow row = dgvChiTietHoaDon.Rows[i];
                    sum += int.Parse(row.Cells[4].Value + "");
                }
                var nv = db.HoaDons.Where(s => s.MaHD == MaHD).FirstOrDefault();
                lbMaHD.Text = nv.MaHD + "";
                var rs = db.NhanViens.Where(s => s.MaNV == nv.MaNV).FirstOrDefault();
                lbTenNV.Text = rs.TenNV;
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                string total = sum.ToString("#,###.###", cul.NumberFormat);
                lbTongTien.Text = total + "VNĐ";
            }
        }
        void getThongTin(int MaHD)
        {
            using (DBEntites db = new DBEntites())
            {
                var hoadon = db.HoaDons.Where(c => c.MaHD == MaHD).SingleOrDefault();
                lbNgayBan.Text = hoadon.NgayLap.ToString();
                var nv = db.NhanViens.Where(c => c.MaNV == hoadon.MaNV).SingleOrDefault();
                lbMaNV.Text = nv.MaNV.ToString();
                lbTenNV.Text = nv.TenNV;
                var kh = db.KhachHangs.Where(c => c.MaKH == hoadon.MaKH).SingleOrDefault();
                lbTenKH.Text = kh.TenKH;
                lbDiaChi.Text = kh.DiaChi;
                lbSDT.Text = kh.SDT;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            
            excelApp.Cells[rowIndex, 1] = "Chi tiết hóa đơn";
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Mã hóa đơn: ";
            excelApp.Cells[rowIndex, 2] = lbMaHD.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Ngày bán: ";
            excelApp.Cells[rowIndex, 2] = lbNgayBan.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Tên khách hàng: ";
            excelApp.Cells[rowIndex, 2] = lbTenKH.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Địa chỉ KH: ";
            excelApp.Cells[rowIndex, 2] = lbDiaChi.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Số điện thoại KH: ";
            excelApp.Cells[rowIndex, 2] = lbSDT.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Nhân viên lập HĐ: ";
            excelApp.Cells[rowIndex, 2] = lbTenNV.Text;
            rowIndex++;
            //header table
            for (int i = 1; i < dgvChiTietHoaDon.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i] = dgvChiTietHoaDon.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            for (int i = 0; i < dgvChiTietHoaDon.Rows.Count; i++)
            {
                for (int j = 0; j < dgvChiTietHoaDon.Columns.Count; j++)
                {

                    excelApp.Cells[i + rowIndex, j + 1] = dgvChiTietHoaDon.Rows[i].Cells[j].Value.ToString();
                }

            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

        }
    }
}
