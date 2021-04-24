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
    public partial class Form1 : Form
    {
        DBModel db = new DBModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = db.SanPhams.Select(x => new
            {
                MaSP = x.MaSP,
                TenSp = x.TenSP,
                SoLuong = x.SLTon,
                Gia = x.Gia,
                MoTa = x.MoTa,
            }).Where(x=>x.SoLuong > 200).ToList();

            for (int i = 0 ; i < dgvSanPham.ColumnCount; i++)
            {
                dgvSanPham.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
