using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BTL_CSharp
{
    public partial class frmMenuAction : Form
    {
        public TaiKhoan user;
        public frmMenuAction()
        {
            InitializeComponent();
        }
        public frmMenuAction(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }

        private void frmMenuAction_Load(object sender, EventArgs e)
        {
            string role;
            if (user.Role == 1)
            {
                role = "admin";
            }
            else
            {
                role = "nhân viên";
                tabControl1.Controls.Remove(tabControl1.TabPages["tabQLNV"]);
                tabControl1.Controls.Remove(tabControl1.TabPages["tabQLTK"]);
            }
            DBEntites db = new DBEntites();
            int manv = user.NhanVien.MaNV;
            var nv = db.NhanViens.Where(s => s.MaNV == manv).Select(s => s).FirstOrDefault();
            lblWelcome.Text = "Xin chào " + nv.TenNV + ", Chức vụ: " + role;
            checkTab(tabControl1.SelectedIndex);
        }
        public void checkTab(int index)
        {
            string tabName = tabControl1.TabPages[index].Name;

            if (tabName == "tabQLDMSP")
            {//QLDM
                frmQLDMSP frm = new frmQLDMSP();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabQLHD")
            {//QLHD
                frmHoaDon frm = new frmHoaDon(user);
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabQLNCC")
            {//QLNCC
                frmQuanLyNCC frm = new frmQuanLyNCC();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabQLNV")
            {//QLNV
                frmQLNV frm = new frmQLNV();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabQLKH")
            {//QLKH
                frmQLKH frm = new frmQLKH(user);
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabCreateBill")
            {//Create Bill
                frmBeforeCreateBill frm = new frmBeforeCreateBill(user);
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabStatistic")
            {//frmStatistic
                frmStatistic frm = new frmStatistic();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (tabName == "tabQLTK")
            {//frmStatistic
                frmQLTK frm = new frmQLTK();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            checkTab(index);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuAction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();

        }
    }
}
