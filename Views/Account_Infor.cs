using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.Views
{
    public partial class Account_Infor : Form
    {
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
        public Account_Infor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }

        private void Account_Infor_Load(object sender, EventArgs e)
        {
            var account = AccountDAO.Instance.GetAccountByID(Constants.userID);
            txbFullName.Text = account.Name;
            txbAddress.Text = account.Address;
            txbPosition.Text = account.Position;
            txbUserName.Text = account.UserName;
        }

        private void bntUpdateAccount_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == txbConfirmPass.Text)
            {
                var account = AccountDAO.Instance.GetAccountByID(Constants.userID);
                account.Name = txbFullName.Text;
                account.Address = txbAddress.Text;
                account.PassWord = txbConfirmPass.Text;
                KaraokeContext.Instance.SaveChanges();
            }
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
