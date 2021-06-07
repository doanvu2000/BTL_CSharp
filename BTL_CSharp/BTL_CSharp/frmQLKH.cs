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
    public partial class frmQLKH : Form
    {
        DBEntites db = new DBEntites();
        KhachHang kh = new KhachHang();
        TaiKhoan user;
        string sdt="";
        public frmQLKH()
        {
            InitializeComponent();
        } 
        public frmQLKH(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }
        public frmQLKH(string sd,TaiKhoan x)
        {
            InitializeComponent();
            sdt = sd;
            user = x;
        } 
        
        
        private void frmQLKH_Load(object sender, EventArgs e)
        {
            HienThi();
            setAutoSizeMode(dgvKhachHang);
            clear();
            txtmakh.Enabled = true;
            txtdienthoai.Text = sdt;
        }
        public void setAutoSizeMode(DataGridView dg)
        {
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void HienThi()
        {
            dgvKhachHang.DataSource = db.KhachHangs.Select(x => new
            {
                MaKH = x.MaKH,
                TenKH = x.TenKH,
                SDT = x.SDT,
                DiaChi = x.DiaChi
            }).ToList();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenkh.Text == "" || txtdienthoai.Text == "" || txtdiachikh.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    kh.TenKH = txttenkh.Text.Trim();
                    kh.SDT = txtdienthoai.Text.Trim();
                    kh.DiaChi = txtdiachikh.Text.Trim();
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    frmQLKH_Load(sender, e);
                    clear();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewrow = dgvKhachHang.CurrentRow;
            txtmakh.Text = viewrow.Cells[0].Value + "";
            kh.MaKH = int.Parse(txtmakh.Text.ToString());
            txttenkh.Text = viewrow.Cells[1].Value + "";
            txtdienthoai.Text = viewrow.Cells[2].Value + "";
            txtdiachikh.Text = viewrow.Cells[3].Value + "";
            setAutoSizeMode(dgvKhachHang);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                kh.TenKH = txttenkh.Text.ToString();
                kh.SDT = txtdienthoai.Text.ToString();
                kh.DiaChi = txtdiachikh.Text.ToString();
                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();
                frmQLKH_Load(sender, e);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "" || txttenkh.Text == "" || txtdienthoai.Text == "" || txtdiachikh.Text == "")
            {
                MessageBox.Show("vui lòng chọn khách hàng cần xóa", "thông báo");
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    kh.MaKH = int.Parse(dgvKhachHang.CurrentRow.Cells[0] + "");
                    //var entry = db.Entry(kh);
                    db.Entry(kh).State = EntityState.Deleted;
                    db.KhachHangs.Attach(kh);
                    db.KhachHangs.Remove(kh);
                    db.SaveChanges();
                    frmQLKH_Load(sender, e);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void clear()
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtdienthoai.Clear();
            txtdiachikh.Clear();
            ActiveControl = txttenkh;
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
                dgvKhachHang.DataSource = db.KhachHangs.Select(x => new
                {
                    MaKH = x.MaKH,
                    TenKH = x.TenKH,
                    SDT = x.SDT,
                    Diachi = x.DiaChi
                }).Where(a => a.SDT.Contains(txttimkiem.Text.Trim().ToString())).ToList();
            }         
       }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            HienThi();
            txttimkiem.Clear();
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow viewRow = dgvKhachHang.CurrentRow;
                string sdt = viewRow.Cells[2].Value + "";
                var kh = db.KhachHangs.Select(s => s).Where(s => s.SDT == sdt).FirstOrDefault();
                frmLapHoaDon form = new frmLapHoaDon((KhachHang)kh, user, true);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
