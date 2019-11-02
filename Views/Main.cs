using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class Main : Form
    {
        static int RoomWidth = 160;
        static int RoomHeight = 90;
        static KaraokeContext context = new KaraokeContext();
        RoomDAO roomDAO = new RoomDAO(context);
        FoodDAO foodDAO = new FoodDAO(context);
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LoadRoom()
        {
            List<Room> roomNormals = roomDAO.GetRoomNormal();
            List<Room> roomVIPs = roomDAO.GetRoomVIP();
            foreach (Room room in roomNormals)
            {
                ToolTip tt = new ToolTip() { ToolTipTitle = "Hướng dẫn:", ToolTipIcon = ToolTipIcon.Info };
                RoundedButton bnt_Normal = new RoundedButton() { Width = RoomWidth, Height = RoomHeight };
                tt.SetToolTip(bnt_Normal, "\"Double Click\" để đặt phòng!");
                bnt_Normal.Text = room.Name + Environment.NewLine + room.RoomStatus;
                bnt_Normal.Tag = room;
                bnt_Normal.Click += Bnt_Normal_Click;
                switch (room.RoomStatus)
                {
                    case nameof(Constants.ROOM_STATUS.FULL):
                        bnt_Normal.BackColor = Constants.RoomSelected;
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
                bnt_VIP.Click += Bnt_VIP_Click;    
                switch (room.RoomStatus)
                {
                    case nameof(Constants.ROOM_STATUS.FULL):
                        bnt_VIP.BackColor = Constants.RoomSelected;
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

        private void Bnt_VIP_Click(object sender, EventArgs e)
        {

        }

        private void Bnt_Normal_Click(object sender, EventArgs e)
        {
            
        }

        private void controlRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduct.Text.Equals("Thức ăn"))
            {
                cbNameProduct.Items.Clear();
                var foods = foodDAO.GetFoods();
                foreach(Food food in foods)
                {
                    cbNameProduct.Items.Add(food.Name);
                }
            }
            if (cbProduct.Text.Equals("Nước uống"))
            {
                cbNameProduct.Items.Clear();
                var foods = foodDAO.GetDrinks();
                foreach (Food drink in foods)
                {
                    cbNameProduct.Items.Add(drink.Name);
                }
            }
        }
    }
}
