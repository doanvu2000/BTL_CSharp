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
    public partial class frmQLDM : Form
    {
        DBModel db = new DBModel();
        public frmQLDM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
            setAutoSizeMode(dgvDanhMuc);
        }
        public void setAutoSizeMode(DataGridView dg)
        {
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }
        public void HienThiDanhMuc()
        {
            dgvDanhMuc.DataSource = db.DanhMucs.Select(x => new
            {
                MaDM = x.MaDM,
                TenDM = x.TenDM
            }).ToList();   
        }
        public void HienThiSanPham()
        {
            dgvSanPham.DataSource = db.DanhMucs.Select(x => new
            {
                MaDM = x.MaDM,
                TenDM = x.TenDM
            }).ToList();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvDanhMuc.CurrentRow;
            txtMaDM.Text = viewRow.Cells[0].Value+"";
            lblDMViewSP.Text = txtTenDM.Text = viewRow.Cells[1].Value+"";
            lblDMViewSP.Text = "Danh mục: " + lblDMViewSP.Text;
            string maDM = txtMaDM.Text + "";
            dgvSanPham.DataSource = db.SanPhams.Select(x => new
            {
                MaSP = x.MaSP,
                MaDM = x.MaDM,
                TenSp = x.TenSP,
                SoLuong = x.SLTon,
                Gia = x.Gia,
                MoTa = x.MoTa
            }).Where(x=> x.MaDM == maDM).ToList();
            setAutoSizeMode(dgvSanPham);
        }
    }
}
