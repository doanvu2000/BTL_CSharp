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
    public partial class frmBeforeCreateBill : Form
    {
        TaiKhoan tk = new TaiKhoan();
        public frmBeforeCreateBill()
        {
            InitializeComponent();
        }
         public frmBeforeCreateBill(TaiKhoan x)
        {
            InitializeComponent();
            tk = x;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sdt = textBox1.Text;
            using (DBEntites db = new DBEntites())
            {
                var kh = db.KhachHangs.Select(s => s).Where(s => s.SDT == sdt).FirstOrDefault();
                if (kh == null)
                {
                    frmQLKH frmqlkh = new frmQLKH(sdt);
                    frmqlkh.ShowDialog();
                    List<KhachHang> khs = db.KhachHangs.ToList();
                    KhachHang newKH = khs[khs.Count - 1];
                    frmLapHoaDon form = new frmLapHoaDon(newKH,tk,false);                  
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    
                    frmLapHoaDon form = new frmLapHoaDon((KhachHang)kh, tk,true);
                    form.ShowDialog();
                    Close();
                }
            }
        }
    }
}
