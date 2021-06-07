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
    public partial class frmQLDMSP : Form
    {
        DBEntites db = new DBEntites();
        DanhMuc dm = new DanhMuc();
        SanPham sp = new SanPham();
        public frmQLDMSP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
            setAutoSizeMode(dgvDanhMuc);
            var ncc = db.NCCs.Select(x => new { x.TenNCC }).ToList();
            cblNCC.DataSource = null;
            cblNCC.DataSource = ncc;
            cblNCC.DisplayMember = "TenNCC";
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
            txtMaDM.Text = viewRow.Cells[0].Value + "";
            lblDMViewSP.Text = txtTenDM.Text = viewRow.Cells[1].Value + "";
            lblDMViewSP.Text = "Danh mục: " + lblDMViewSP.Text;
            int maDM = int.Parse(txtMaDM.Text + "");
            dm.MaDM = maDM;
            var item = (from a in db.SanPhams.Where(a => a.MaDM == maDM)
                        select new
                        {
                            MaSP = a.MaSP,
                            TenSp = a.TenSP,
                            SoLuong = a.SLTon,
                            Gia = a.Gia,
                            MoTa = a.MoTa,
                            Ncc = a.MaNCC
                        }
                        );
            dgvSanPham.DataSource = item.ToList();
            setAutoSizeMode(dgvSanPham);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = txtTenDM.Text = "";
            ActiveControl = txtTenDM;
        }

        private void btnCancelSP_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = txtSoLuongTon.Text = txtGia.Text = txtMoTa.Text = "";
            cblNCC.SelectedIndex = 0;
            ActiveControl = txtTenSP;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvSanPham.CurrentRow;
            sp.TenSP = txtTenSP.Text = viewRow.Cells[1].Value + "";
            txtSoLuongTon.Text = viewRow.Cells[2].Value + "";
            txtGia.Text = viewRow.Cells[3].Value + "";
            sp.MoTa = txtMoTa.Text = viewRow.Cells[4].Value + "";
            int mancc = int.Parse(viewRow.Cells[5].Value + "");
            cblNCC.SelectedIndex = mancc - 1;
            sp.MaSP = int.Parse(viewRow.Cells[0].Value + "");
            sp.SLTon = int.Parse(txtSoLuongTon.Text.ToString());
            sp.Gia = int.Parse(txtGia.Text.ToString());
            sp.MaNCC = mancc;
            sp.MaDM = int.Parse(txtMaDM.Text.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenDM.Text.Trim()))
            {
                return;
            }
            dm.TenDM = txtTenDM.Text.Trim();
            db.DanhMucs.Add(dm);
            db.SaveChanges();
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dm.TenDM = txtTenDM.Text.Trim();
            db.Entry(dm).State = EntityState.Modified;
            db.SaveChanges();
            btnCancel_Click(sender, e);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var entry = db.Entry(dm);
                    if (entry.State == EntityState.Detached)
                        db.DanhMucs.Attach(dm);
                    db.DanhMucs.Remove(dm);
                    db.SaveChanges();
                    btnCancel_Click(sender, e);
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }             
            }
        }
        public bool ValidateProduct()
        {
            if (txtTenDM.Text == "DM") return false;
            if (string.IsNullOrWhiteSpace(txtTenSP.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtSoLuongTon.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtGia.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtMoTa.Text)) return false;
            return true;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                MessageBox.Show("Vui lòng nhập đủ các trường!");
                return;
            }
            try
            {
                sp.SLTon = int.Parse(txtSoLuongTon.Text.ToString());
                sp.Gia = int.Parse(txtGia.Text.ToString());
                sp.MaDM = int.Parse(txtMaDM.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }           
            sp.TenSP = txtTenSP.Text;
            sp.MoTa = txtMoTa.Text;
            sp.MaNCC = cblNCC.SelectedIndex + 1;
            db.SanPhams.Add(sp);
            db.SaveChanges();
            btnCancelSP_Click(sender, e);
            Form1_Load(sender, e);
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                sp.SLTon = int.Parse(txtSoLuongTon.Text.ToString());
                sp.Gia = int.Parse(txtGia.Text.ToString());
                sp.MaDM = int.Parse(txtMaDM.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            sp.TenSP = txtTenSP.Text;
            sp.MoTa = txtMoTa.Text;
            sp.MaNCC = cblNCC.SelectedIndex + 1;
            db.Entry(sp).State = EntityState.Modified;
            db.SaveChanges();
            btnCancelSP_Click(sender, e);
            Form1_Load(sender, e);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var entry = db.Entry(sp);
                    if (entry.State == EntityState.Detached)
                        db.SanPhams.Attach(sp);
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                    btnCancelSP_Click(sender, e);
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
