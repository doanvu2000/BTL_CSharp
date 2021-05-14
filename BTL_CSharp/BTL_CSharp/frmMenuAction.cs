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
        public  TaiKhoan user;
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
            }
            lblWelcome.Text = "Xin chào " + user.UserName + ", Chức vụ: " + role;
            checkTab(tabControl1.SelectedIndex);
        }
        public void checkTab(int index)
        {
            if (index == 0)
            {//QLDM
                frmQLDMSP frm = new frmQLDMSP();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (index == 1)
            {//QLHD
                frmHoaDon frm = new frmHoaDon();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (index == 2)
            {//QLNCC
                frmQuanLyNCC frm = new frmQuanLyNCC();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (index == 3)
            {//QLNV
                frmQLNV frm = new frmQLNV();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (index == 4)
            {//QLKH
                frmQLKH frm = new frmQLKH();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }
            else if (index == 5)
            {//Create Bill
                frmBeforeCreateBill frm = new frmBeforeCreateBill();
                frm.TopLevel = false; // set parent != desktop
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Parent = tabControl1.SelectedTab;
                frm.Show();
            }else
            {//frmStatistic

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            checkTab(index);
        }
    }
}
