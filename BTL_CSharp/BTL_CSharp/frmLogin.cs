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
    public partial class frmLogin : Form
    {
        DBEntites db = new DBEntites();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaiKhoan user = checkUserName(username);
            if (user == null)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (user.PassWord != password)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                frmMenu f = new frmMenu(user);
                f.Closed += (s, args) => Close();
                f.Show();
            }
        }

        public TaiKhoan checkUserName(string username)
        {
            TaiKhoan x;
            x = db.TaiKhoans.Where(p=> p.UserName == username).Select(p => p).FirstOrDefault();
            return x;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

}
