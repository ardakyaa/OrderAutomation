using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void UserLogin_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void UserLogin_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void UserLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        string userName;
        string password;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = mtxtPassword.Text;

            if (userName == "admin" && password == "123456")
            {
                FormMain form = new FormMain();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalıdır.", "Kullanıcı Girişi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.CheckState == CheckState.Checked)
            {
                mtxtPassword.PasswordChar = char.Parse("\0");
            }
            else if (cbShowPassword.CheckState == CheckState.Unchecked)
            {
                mtxtPassword.PasswordChar = char.Parse("*");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
