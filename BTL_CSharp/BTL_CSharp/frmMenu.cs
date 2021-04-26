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
    public partial class frmMenu : Form
    {
        private TaiKhoan user;
        public frmMenu(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }

        public TaiKhoan User { get => user; set => user = value; }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            string role;
            if (user.Role == 1)
            {
                role = "admin";
            }
            else
            {
                role = "nhân viên";
                btnQLNV.Visible = false;
                pictureBox6.Visible = false;
            }
            lblUser.Text = "Xin chào "+user.UserName +", Chức vụ: " + role;
            panel1.Location = new Point(0, 0);
            panel1.Width = 1920;
            panel1.Height = 93;
            panel2.Location = new Point(panel1.Location.X, panel1.Height+2);
            pnlAction.Location = new Point(panel2.Location.X + panel2.Width + 2, panel2.Location.Y);
            pnlAction.Height = 1920 - panel2.Width - 2;
            pnlAction.Height = panel2.Height;
        }
        public void setSize(Form f)
        {
            f.Width = pnlAction.Width;
            f.Height = pnlAction.Height;
        }
        private void btnQLDM_Click(object sender, EventArgs e)
        {
            pnlAction.Controls.Clear();
            frmQLDMSP f = new frmQLDMSP() {TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None};
            setSize(f);
            pnlAction.Controls.Add(f);
            f.Show();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            pnlAction.Controls.Clear();
            frmHoaDon f = new frmHoaDon() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            setSize(f);
            pnlAction.Controls.Add(f);
            f.Show();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            pnlAction.Controls.Clear();
            frmQuanLyNCC f = new frmQuanLyNCC() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            setSize(f);
            pnlAction.Controls.Add(f);
            f.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnlAction.Controls.Clear();
            frmQLNV f = new frmQLNV() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            setSize(f);
            pnlAction.Controls.Add(f);
            f.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            pnlAction.Controls.Clear();
            frmQLKH f = new frmQLKH() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            setSize(f);
            pnlAction.Controls.Add(f);
            f.Show();
        }
    }
}
