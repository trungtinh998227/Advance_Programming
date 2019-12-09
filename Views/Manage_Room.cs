using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KaraokeApp.Views
{
    public partial class Manage_Room : Form
    {
        private Room room;
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
        public Manage_Room(Room room)
        {
            this.room = room;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }

        private void Manage_Room_Load(object sender, EventArgs e)
        {
            txb_RoomID.Text = "Phòng " + room.ID.ToString();
            txb_RoomStyle.Text = room.RoomType;
            cb_Status.Text = room.RoomStatus;

            switch (cb_Status.Text)
            {
                case nameof(Constants.ROOM_STATUS.EMPTY):
                    txbTime.Text = Constants.GetCurrentDateTime;
                    break;
                case nameof(Constants.ROOM_STATUS.FULL):
                    bntBookRoom.Enabled = false;
                    break;
                case nameof(Constants.ROOM_STATUS.DATE):
                    bntBookRoom.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_Status.Text)
            {
                case nameof(Constants.ROOM_STATUS.EMPTY):
                    txbTime.Text = Constants.GetCurrentDateTime;
                    break;
                case nameof(Constants.ROOM_STATUS.DATE):
                    room.RoomStatus = Constants.ROOM_STATUS.DATE;
                    // Xử lý nhập ngày giờ hẹn
                    break;
                default:
                    break;
            }
        }

        private void bntBookRoom_Click(object sender, EventArgs e)
        {
            var ac_r = new Account_Room(DateTime.Parse(txbTime.Text), room.ID, Constants.userID);
            Account_RoomDAO.instance.AddAccount_Room(ac_r);
            room.RoomStatus = Constants.ROOM_STATUS.FULL;
            RoomDAO.Instance.UpdateRoom(room);
            this.Close();
        }
    }
}
