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
    public partial class frmQuanLyNCC : Form
    {
        NCC ncc = new NCC();
        public frmQuanLyNCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate(txtTenNCC.Text.Trim()) || !validate(txtSDT.Text.Trim()) ||
                !validate(txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            ncc.TenNCC = txtTenNCC.Text.Trim();
            ncc.SDT = txtSDT.Text.Trim();
            ncc.DiaChi = txtDiaChi.Text.Trim();
            using (DBEntites db = new DBEntites())
            {
                if (ncc.MaNCC == 0)
                    db.NCCs.Add(ncc);
                else
                    db.Entry(ncc).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
        }
        void Clear()
        {
            txtMaNCC.Text = txtTenNCC.Text = txtSDT.Text = txtDiaChi.Text = "";
            btnThem.Text = "Them";
            btnXoa.Enabled = false;
            ncc.MaNCC = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmQuanLyNCC_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            Clear();
        }

        void PopulateDataGridView()
        {
            using (DBEntites db = new DBEntites())
            {
                var ncc = db.NCCs.Select(c => new
                {
                    MaNCC = c.MaNCC,
                    TenNCC = c.TenNCC,
                    SDT = c.SDT,
                    DiaChi = c.DiaChi,
                });
                dgvNCC.DataSource = ncc.ToList();
                for (int i = 0; i < dgvNCC.ColumnCount; i++)
                {
                    dgvNCC.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void dgvNCC_DoubleClick(object sender, EventArgs e)
        {
            if(dgvNCC.CurrentRow.Index != -1)
            {
                ncc.MaNCC = Convert.ToInt32(dgvNCC.CurrentRow.Cells["MaNCC"].Value);
                using(DBEntites db = new DBEntites())
                {
                    ncc = db.NCCs.Where(x => x.MaNCC == ncc.MaNCC).FirstOrDefault();
                    txtMaNCC.Text = Convert.ToString(ncc.MaNCC);
                    txtTenNCC.Text = ncc.TenNCC;
                    txtSDT.Text = ncc.SDT;
                    txtDiaChi.Text = ncc.DiaChi;
                }
                btnThem.Text = "Sửa";
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa dòng này?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (DBEntites db = new DBEntites())
                    {
                        var entry = db.Entry(ncc);
                        if (entry.State == EntityState.Detached)
                            db.NCCs.Attach(ncc);
                        db.NCCs.Remove(ncc);
                        db.SaveChanges();
                        PopulateDataGridView();
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NCC này đang phân phối hàng, không thể xóa! Mã lỗi: "+ex.Message);
                }
                
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            int maTraCuu = 0;
            

            try
            {
                maTraCuu = int.Parse(txtTraCuu.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (maTraCuu != 0)
            {
                using (DBEntites db = new DBEntites())
                {
                    var ncc = db.NCCs.Select(x => new
                    {
                        MaNCC = x.MaNCC,
                        TenNCC = x.TenNCC,
                        SDT = x.SDT,
                        DiaChi = x.DiaChi
                    }).Where(x => x.MaNCC == maTraCuu);
                    dgvNCC.DataSource = null;
                    dgvNCC.DataSource = ncc.ToList();
                    for (int i = 0; i < dgvNCC.ColumnCount; i++)
                    {
                        dgvNCC.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvNCC.CurrentRow;
            txtMaNCC.Text = viewRow.Cells[0].Value + "";
            txtTenNCC.Text = viewRow.Cells[1].Value + "";
            txtSDT.Text = viewRow.Cells[2].Value + "";
            txtDiaChi.Text = viewRow.Cells[3].Value + "";
        }
        public bool validate(string s)
        {
            if (String.IsNullOrWhiteSpace(s)) return false;
            return true;
        }
    }
}
