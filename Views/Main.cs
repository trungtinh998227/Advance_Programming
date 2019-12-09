using KaraokeApp.Controllers;
using KaraokeApp.Models;
using KaraokeApp.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class Main : Form
    {
        static int RoomWidth = 160;
        static int RoomHeight = 90;
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
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
            LoadRoom();
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadRoom()
        {
            fPanel_Room_Normal.Controls.Clear();
            fPanel_Room_VIP.Controls.Clear();
            List<Room> roomNormals = RoomDAO.Instance.GetRoomNormal();
            List<Room> roomVIPs = RoomDAO.Instance.GetRoomVIP();
            foreach (Room room in roomNormals)
            {
                ToolTip tt = new ToolTip() { ToolTipTitle = "Hướng dẫn:", ToolTipIcon = ToolTipIcon.Info };
                RoundedButton bnt_Normal = new RoundedButton() { Width = RoomWidth, Height = RoomHeight };
                tt.SetToolTip(bnt_Normal, "\"Double Click\" để đặt phòng!");
                bnt_Normal.Text = room.Name + Environment.NewLine + room.RoomStatus;
                bnt_Normal.Tag = room;
                bnt_Normal.DoubleClick += Bnt_Normal_Double_Click;
                bnt_Normal.Click += Bnt_Normal_Click;
                bnt_Normal.LostFocus += bnt_Normal_LostFocus;
                switch (room.RoomStatus)
                {
                    case nameof(Constants.ROOM_STATUS.FULL):
                        bnt_Normal.BackColor = Constants.RoomFull;
                        break;
                    case nameof(Constants.ROOM_STATUS.DATE):
                        bnt_Normal.BackColor = Constants.RomDate;
                        break;
                    default:
                        bnt_Normal.BackColor = Constants.RoomEmpty;
                        break;
                }
                fPanel_Room_Normal.Controls.Add(bnt_Normal);
            }
            foreach (Room room in roomVIPs)
            {
                ToolTip tt = new ToolTip() { ToolTipTitle = "Hướng dẫn:", ToolTipIcon = ToolTipIcon.Info };
                RoundedButton bnt_VIP = new RoundedButton() { Width = RoomWidth, Height = RoomHeight };
                tt.SetToolTip(bnt_VIP, "\"Double Click\" để đặt phòng!");
                bnt_VIP.Text = room.Name + Environment.NewLine + room.RoomStatus;
                bnt_VIP.Tag = room;
                bnt_VIP.DoubleClick += Bnt_VIP_Double_Click;
                bnt_VIP.Click += Bnt_VIP_Click;
                bnt_VIP.LostFocus += bnt_VIP_LostFocus;
                switch (room.RoomStatus)
                {
                    case nameof(Constants.ROOM_STATUS.FULL):
                        bnt_VIP.BackColor = Constants.RoomFull;
                        break;
                    case nameof(Constants.ROOM_STATUS.DATE):
                        bnt_VIP.BackColor = Constants.RomDate;
                        break;
                    default:
                        bnt_VIP.BackColor = Constants.RoomEmpty;
                        break;
                }
                fPanel_Room_VIP.Controls.Add(bnt_VIP);
            }
        }

        private void bnt_VIP_LostFocus(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
            bntAddFood.Enabled = false;
            bnt_deleFood.Enabled = false;
        }

        private void bnt_Normal_LostFocus(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
            bntAddFood.Enabled = false;
            bnt_deleFood.Enabled = false;
        }

        private void Bnt_VIP_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Constants.RomSelect;
            bntAddFood.Enabled = true;
            bnt_deleFood.Enabled = true;
        }

        private void Bnt_Normal_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Constants.RomSelect;
            bntAddFood.Enabled = true;
            bnt_deleFood.Enabled = true;
        }

        private void Bnt_VIP_Double_Click(object sender, EventArgs e)
        {
            Manage_Room manage = new Manage_Room((sender as Button).Tag as Room);
            manage.FormClosed += Manage_FormClosed;
            manage.ShowDialog();
        }

        private void Bnt_Normal_Double_Click(object sender, EventArgs e)
        {
            Manage_Room manage = new Manage_Room((sender as Button).Tag as Room);
            manage.FormClosed += Manage_FormClosed;
            manage.ShowDialog();
        }

        private void Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRoom();
        }

        private void controlRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduct.Text.Equals("Thức ăn"))
            {
                cbNameProduct.Items.Clear();
                var foods = FoodDAO.Instance.GetFoods();
                foreach (Food food in foods)
                {
                    cbNameProduct.Items.Add(food.Name);
                }
            }
            if (cbProduct.Text.Equals("Nước uống"))
            {
                cbNameProduct.Items.Clear();
                var foods = FoodDAO.Instance.GetDrinks();
                foreach (Food drink in foods)
                {
                    cbNameProduct.Items.Add(drink.Name);
                }
            }
        }

        private void bntAddFood_Click(object sender, EventArgs e)
        {
            var food = FoodDAO.Instance.GetFoodByName(cbNameProduct.Text);
            if (food != null)
            {
                lvBill.
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
