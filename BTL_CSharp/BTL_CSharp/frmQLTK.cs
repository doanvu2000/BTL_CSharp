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
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
            var nv = db.NhanViens.ToList();
            List<int> tk = db.TaiKhoans.Select(t => t.manv).Cast<int>().ToList();
            List<int> list_MaNV = new List<int>();

            foreach (var x in nv)
            {
                list_MaNV.Add(x.MaNV);
            }
            cblNV.DataSource = list_MaNV;

        }
        DBEntites db = new DBEntites();
        private void frmQLTK_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            dgvTaiKhoan.DataSource = null;
            dgvTaiKhoan.DataSource = db.TaiKhoans.Select(t => new
            {
                UserName = t.UserName,
                PassWord = t.PassWord,
                Role = t.Role,
                MaNV = t.manv
            }).OrderBy(t=>t.UserName).ToList();
            clearData();
        }
        public void clearData()
        {
            rdRoleStaff.Checked = true;
            txtUserName.Text = txtPassword.Text = "";
            ActiveControl = txtUserName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
            {
                MessageBox.Show("Enter data to textbox: UserName and PassWord!");
                return;
            }
            int manv = int.Parse(cblNV.SelectedItem.ToString());
            var acc_ = db.TaiKhoans.Where(t => t.UserName == userName).FirstOrDefault();
            if (acc_ != null)
            {
                MessageBox.Show("This UserName already exists, double Click in Table to Delete Account!");
                return;
            }

            var acc = db.TaiKhoans.Where(t => t.manv == manv).FirstOrDefault();
            if (acc != null)
            {
                MessageBox.Show("This person already has an account, double Click in Table to Delete Account!");
                return;
            }

            int role = 1;
            if (rdRoleStaff.Checked == true) role = 2;
            var newAccount = new TaiKhoan 
                                { UserName = userName, PassWord = passWord, Role = role, manv = manv };
            db.TaiKhoans.Add(newAccount);
            db.SaveChanges();
            showData();
        }
        
        private void cblNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manv = int.Parse(cblNV.SelectedItem.ToString());
            var nv = db.NhanViens.Where(t => t.MaNV == manv).Select(t => new
            {
                tennv = t.TenNV,
                SDT = t.SDT,
                DiaChi = t.DiaChi
            }).FirstOrDefault();
            if (nv != null)
            {
                lblTenNV.Text = nv.tennv;
                lblDiaChi.Text = nv.DiaChi;
                lblSDT.Text = nv.SDT;
            }
        
        }

        private void cblNV_DataSourceChanged(object sender, EventArgs e)
        {
            int manv = int.Parse(cblNV.SelectedItem.ToString());
            var nv = db.NhanViens.Where(t => t.MaNV == manv).Select(t => new
            {
                tennv = t.TenNV,
                SDT = t.SDT,
                DiaChi = t.DiaChi
            }).FirstOrDefault();
            if (nv != null)
            {
                lblTenNV.Text = nv.tennv;
                lblDiaChi.Text = nv.DiaChi;
                lblSDT.Text = nv.SDT;
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvTaiKhoan.CurrentRow;
            string username = viewRow.Cells[0].Value + "";
            if (MessageBox.Show("Are you sure to delete this account?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var nv = db.TaiKhoans.Where(t => t.UserName == username).FirstOrDefault();
                var entry = db.Entry(nv);
                if (entry.State == EntityState.Detached)
                    db.TaiKhoans.Attach(nv);
                db.TaiKhoans.Remove(nv);
                db.SaveChanges();
                showData();
            }
        }
    }
}
