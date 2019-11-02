using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class Login_Form : Form
    {
        public string Position { get; set; }
        static KaraokeContext context = new KaraokeContext();
        AccountDAO accountDAO = new AccountDAO(context);
        private string passWord = "";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Login_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }

        private void Login_Form_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
            invalidUser.Visible = false;
            InvalidPass.Visible = false;
            invalidAccount.Visible = false;
            /*var data = new DefaultData(context);
            data.AddAccount();
            data.AddRoom();
            data.AddProducer_Food();*/
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_Login_Click(object sender, EventArgs e)
        {
            if (txb_UserName.Text.Equals("Tên đăng nhập"))
            {
                invalidUser.Visible = true;
                invalidUser.Text = "Vui lòng nhập \"Tên đăng nhập\"";
            }
            if (txb_Pass.Text.Equals("Mật khẩu"))
            {
                InvalidPass.Visible = true;
                InvalidPass.Text = "Vui lòng nhập \"Mật khẩu\"";
            }
            else if ((Position = accountDAO.ValidateAccount(txb_UserName.Text, passWord)) != "")
            {
                invalidUser.Visible = false;
                InvalidPass.Visible = false;
                invalidAccount.Visible = false;
                Main main = new Main();
                main.ShowDialog();
                this.Hide();
                this.Show();
            }
            else
            {
                invalidAccount.Visible = true;
                invalidAccount.Text = "Tài khoản không hợp lệ";
                txb_UserName.Text = "";
                txb_Pass.Text = "";
                invalidUser.Visible = true;
                invalidUser.Text = "Vui lòng nhập \"Tên đăng nhập\" hợp lệ";
                InvalidPass.Visible = true;
                InvalidPass.Text = "Vui lòng nhập \"Mật khẩu\" hợp lệ";
            }
        }

        private void txb_UserName_Enter(object sender, EventArgs e)
        {
            if (txb_UserName.Text.Equals("Tên đăng nhập"))
            {
                invalidUser.Visible = false;
                InvalidPass.Visible = false;
                invalidAccount.Visible = false;
                txb_UserName.Text = "";
                txb_UserName.ForeColor = Color.Black;
            }
        }

        private void txb_Pass_Enter(object sender, EventArgs e)
        {
            if (txb_Pass.Text.Equals("Mật khẩu"))
            {
                invalidUser.Visible = false;
                InvalidPass.Visible = false;
                invalidAccount.Visible = false;
                txb_Pass.Text = "";
                txb_Pass.ForeColor = Color.Black;
            }
        }

        private void txb_Pass_TextChanged(object sender, EventArgs e)
        {
            if (passWord.Length > txb_Pass.Text.Length)
            {
                passWord = passWord.Remove(passWord.Length - 1);
            }
            if (txb_Pass.Text != "")
            {
                char lastChar = txb_Pass.Text[txb_Pass.Text.Length - 1];
                passWord += lastChar;
                passWord = passWord.Replace("*", "");
                string replaced = "";
                for (int i = 0; i < txb_Pass.Text.Length; i++)
                {
                    replaced += '*';
                }
                txb_Pass.Text = replaced;

            }
            txb_Pass.Select(txb_Pass.Text.Length, 0);
        }

        private void txb_UserName_Leave(object sender, EventArgs e)
        {
            if (txb_UserName.Text.Equals(""))
            {
                invalidUser.Visible = false;
                InvalidPass.Visible = false;
                txb_UserName.Text = "Tên đăng nhập";
                txb_UserName.ForeColor = Color.DimGray;
            }
        }

        private void txb_Pass_Leave(object sender, EventArgs e)
        {
            if (txb_Pass.Text.Equals(""))
            {
                invalidUser.Visible = false;
                InvalidPass.Visible = false;
                txb_Pass.Text = "Mật khẩu";
                txb_Pass.ForeColor = Color.DimGray;
            }
        }
    }
}
