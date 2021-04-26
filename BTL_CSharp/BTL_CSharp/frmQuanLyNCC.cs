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
            MessageBox.Show("Tác vụ thành công");
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
                using(DBEntites db = new DBEntites())
                {
                    var entry = db.Entry(ncc);
                    if (entry.State == EntityState.Detached)
                        db.NCCs.Attach(ncc);
                    db.NCCs.Remove(ncc);
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Xóa thành công");
                }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            int maTraCuu = int.Parse(txtTraCuu.Text.ToString());


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
