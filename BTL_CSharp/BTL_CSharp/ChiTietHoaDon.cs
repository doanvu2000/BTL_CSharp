using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.MaHD = MaHD;
            InitializeComponent();
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
                 }).Select(p => new
                 {
                     MaSP = p.hd.MaSP,
                     TenSP = p.sp.TenSP,
                     SLBan = p.hd.SLBan,
                     DonGia = p.sp.Gia,
                     ThanhTien = p.hd.SLBan * p.sp.Gia,
                 }) ;
                dgvChiTietHoaDon.DataSource = ct.ToList();
                for(int i = 0; i < dgvChiTietHoaDon.ColumnCount; i++)
                {
                    dgvChiTietHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                int sum = 0;
                for (int i = 0; i < dgvChiTietHoaDon.RowCount; i++)
                {
                    DataGridViewRow row = dgvChiTietHoaDon.Rows[i];
                    sum += int.Parse(row.Cells[4].Value + "");
                }
                lbTongTien.Text = sum + "";
                
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
    }
}
