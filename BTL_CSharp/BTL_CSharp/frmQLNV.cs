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
    public partial class frmQLNV : Form
    {
        DBEntites db = new DBEntites();
        NhanVien nv = new NhanVien();
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            HienThi();
            setAutoSizeMode(dgvNhanVien);
            txtmanv.Enabled = true;
            clear();
        }
        public void HienThi()
        {
            dgvNhanVien.DataSource = db.NhanViens.Select(x => new
            {
                MaNV = x.MaNV,
                TenNV = x.TenNV,
                SDT = x.SDT,
                DiaChi = x.DiaChi,
                Luong = x.Luong
            }).ToList();
        }
        public void setAutoSizeMode(DataGridView dg)
        {
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewrow = dgvNhanVien.CurrentRow;
            txtmanv.Text = viewrow.Cells[0].Value + "";
            nv.MaNV =int.Parse(txtmanv.Text.ToString());
            txttennv.Text = viewrow.Cells[1].Value + "";
            txtsdt.Text = viewrow.Cells[2].Value + "";
            txtdiachi.Text = viewrow.Cells[3].Value + "";
            txtluong.Text = viewrow.Cells[4].Value + "";
            setAutoSizeMode(dgvNhanVien);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttennv.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtluong.Text == "")
                {

                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    nv.TenNV = txttennv.Text.Trim();
                    nv.SDT = txtsdt.Text.Trim();
                    nv.DiaChi = txtdiachi.Text.Trim();
                    nv.Luong = int.Parse(txtluong.Text.Trim());
                    db.NhanViens.Add(nv);
                    db.SaveChanges();
                    MessageBox.Show("thêm Thành Công", "Thông Báo");
                    frmQLNV_Load(sender, e);
                    clear();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("vui lòng nhập đủ thông tin","thông báo");
            }
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                nv.TenNV = txttennv.Text.ToString();
                nv.SDT = txtsdt.Text.ToString();
                nv.DiaChi = txtdiachi.Text.ToString();
                nv.Luong = int.Parse(txtluong.Text.ToString());
                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
                frmQLNV_Load(sender, e);
                clear();
            }
            catch (Exception)
            {

                MessageBox.Show("vui lòng nhập đủ thông tin cần sửa", "thông báo");
            }
            
        }

        public void clear()
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txtluong.Clear();
            ActiveControl = txttennv;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "" || txttennv.Text == "" || txtsdt.Text == "" || txtdiachi.Text == ""||txtluong.Text=="")
            {
                MessageBox.Show("vui lòng chọn nhân Viên cần xóa", "thông báo");
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //var entry = db.Entry(nv);
                db.Entry(nv).State = EntityState.Deleted;
                db.NhanViens.Attach(nv);
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                frmQLNV_Load(sender, e);
                clear();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clear();
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("vui lòng nhập số điện thoại", "thông báo");

            }
           
            else
            {
                string b = txttimkiem.Text.Trim().ToString();
                    dgvNhanVien.DataSource = db.NhanViens.Select(x => new
                    {
                        MaNV = x.MaNV,
                        TenNV = x.TenNV,
                        SDT = x.SDT,
                        Diachi = x.DiaChi,
                        Luong = x.Luong
                    }).Where(a => a.SDT.Contains(b)==true).ToList() ;
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            HienThi();
            txttimkiem.Clear();
            clear();
        }
    }
}
