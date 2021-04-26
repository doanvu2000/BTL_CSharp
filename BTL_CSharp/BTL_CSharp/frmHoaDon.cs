using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CSharp
{
    public partial class frmHoaDon : Form
    {
        HoaDon hd = new HoaDon();
        ChiTietHD chiTietHD = new ChiTietHD();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        void PopulateDataGridView()
        {
            using (DBEntites db = new DBEntites())
            {
                var hd = db.HoaDons.Select(x => new
                {
                    MaHD = x.MaHD,
                    NgayLap = x.NgayLap,
                    MaKH = x.MaKH,
                    MaNV = x.MaNV
                });
                dgvHoaDon.DataSource = hd.ToList();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            for(int i = 0; i < dgvHoaDon.ColumnCount; i++)
            {
                dgvHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            hd.MaHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
            if (MessageBox.Show("Bạn có muốn xóa trường này", "EF CRUD Operatio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using(DBEntites db = new DBEntites())
                {
                    hd = db.HoaDons.Where(x => x.MaHD == hd.MaHD).FirstOrDefault();
                    chiTietHD = db.ChiTietHDs.Where(x => x.MaHD == hd.MaHD).FirstOrDefault();
                    var entry = db.Entry(hd);
                    //if (entry.State == EntityState.Detached)
                    //    db.HoaDons.Attach(hd);
                    db.HoaDons.Remove(hd);
                    db.ChiTietHDs.Remove(chiTietHD);
                    db.SaveChanges();
                    MessageBox.Show("Xoa thanh cong");
                }
            PopulateDataGridView();
        }

        private void frmHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if(dgvHoaDon.CurrentRow.Index != -1)
            {
                hd.MaHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                using (DBEntites db = new DBEntites())
                {
                    hd = db.HoaDons.Where(x => x.MaHD == hd.MaHD).FirstOrDefault();
                    btnXemHD_Click(sender, e, hd.MaHD);
                }   
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var tuNgay = Convert.ToDateTime(txtTuNgay.Text.Trim());
            var denNgay = Convert.ToDateTime(txtDenNgay.Text.Trim());
            using (DBEntites db = new DBEntites())
            {
                var hd = db.HoaDons.Select(x => new
                {
                    MaHD = x.MaHD,
                    NgayLap = x.NgayLap,
                    MaKH = x.MaKH,
                    MaNV = x.MaNV
                }).Where(c => c.NgayLap >= tuNgay && c.NgayLap <= denNgay);
                dgvHoaDon.DataSource = hd.ToList();
            }
        }

        private void btnXemHD_Click(object sender, EventArgs e, int MaHD)
        {
            DataGridViewRow viewRow = dgvHoaDon.CurrentRow;
            int ma = int.Parse(viewRow.Cells["MaHD"].Value + "");
            ChiTietHoaDon ss = new ChiTietHoaDon(ma);
            ss.Show();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvHoaDon.CurrentRow;
            int ma = int.Parse(viewRow.Cells["MaHD"].Value + "");
            ChiTietHoaDon ss = new ChiTietHoaDon(ma);
            ss.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
