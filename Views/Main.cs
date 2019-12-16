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
        public static Boolean isPay = false;
        static int RoomWidth = 160;
        static int RoomHeight = 90;
        static Boolean timed = true;
        private Room room { get; set; }
        private Account_Room acc_r { get; set; }
        private BillInfor bill = new BillInfor();
        //private Food_Room Food_Room { get; set; }
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
            if (!bntAddFood.Focused)
            {
                (sender as Button).ForeColor = Color.Black;
            }
        }

        private void bnt_Normal_LostFocus(object sender, EventArgs e)
        {
            if (fPanel_Room_Normal.Focused)
            {
                (sender as Button).ForeColor = Color.Black;
            }
            
        }

        private void Bnt_VIP_Click(object sender, EventArgs e)
        {
            room = (sender as Button).Tag as Room;
            cbProduct.Text = "Sản phẩm";
            cbNameProduct.Text = "Tên sản phẩm";
            UD_numberic.Value = 1;
            reloadBillInf();
            LoadListEmptyRoom(room.RoomType);
            (sender as Button).ForeColor = Constants.RomSelect;
        }

        private void Bnt_Normal_Click(object sender, EventArgs e)
        {
            room = (sender as Button).Tag as Room;
            cbProduct.Text = "Sản phẩm";
            cbNameProduct.Text = "Tên sản phẩm";
            UD_numberic.Value = 1;
            reloadBillInf();
            LoadListEmptyRoom(room.RoomType);
            (sender as Button).ForeColor = Constants.RomSelect;
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
                UD_numberic.Value = 1;
                cbNameProduct.Items.Clear();
                var foods = FoodDAO.Instance.GetFoods();
                foreach (Food food in foods)
                {
                    cbNameProduct.Items.Add(food.Name);
                }
            }
            if (cbProduct.Text.Equals("Nước uống"))
            {
                UD_numberic.Value = 1;
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
            if (timed)
            {
                var food = FoodDAO.Instance.GetFoodByName(cbNameProduct.Text);
                if (food != null && room.RoomStatus != Constants.ROOM_STATUS.EMPTY)
                {
                    var food_room = Food_RoomDAO.Instance.GetFood_RoomByID(room.ID, food.ID);
                    if (food_room != null)
                    {
                        int newValue = food_room.Amount + Convert.ToInt32(UD_numberic.Value);
                        Food_RoomDAO.Instance.UpdateFoodRoom(food_room.ID, newValue, newValue * food.Price);
                    }
                    else
                    {
                        Food_Room fr = new Food_Room(Convert.ToInt32(UD_numberic.Value), Convert.ToInt32(UD_numberic.Value) * food.Price);
                        fr.room = room;
                        fr.Food = food;
                        Food_RoomDAO.Instance.AddFood_Room(fr);
                    }
                }
                else if (room.RoomStatus == Constants.ROOM_STATUS.EMPTY)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn phải đặt phòng trước", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.ActiveControl = null;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Vui lòng chọn món", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.ActiveControl = null;
                    }
                }
                reloadBillInf();
            }
            timed = false;
        }
        private void reloadBillInf()
        {
            int totalprice = 0;
            lvBill.Items.Clear();
            var dataListView = Food_RoomDAO.Instance.GetFood_RoomByRoomID(room.ID);
            foreach (Food_Room fr in dataListView)
            {
                ListViewItem lvitems = new ListViewItem(FoodDAO.Instance.GetFoodNameByID(fr.Food.ID));
                lvitems.SubItems.Add(fr.Amount.ToString());
                lvitems.SubItems.Add(fr.TotalPrice.ToString("###,###"));
                totalprice += fr.TotalPrice;
                lvBill.Items.Add(lvitems);
            }
            txbTotalPrice.Text = totalprice.ToString("###,###") + " VNĐ";
        }

        private void cbNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            timed = true;
            UD_numberic.Value = 1;
            ToolTip toolTip = new ToolTip() { ToolTipTitle = "Giá tiền:", ToolTipIcon = ToolTipIcon.Info };
            toolTip.SetToolTip(sender as ComboBox, FoodDAO.Instance.GetFoodByName(cbNameProduct.SelectedItem.ToString()).Price.ToString("###,###"));
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            timed = true;
            if (lvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lvBill.SelectedItems[0];
                cbNameProduct.Text = item.SubItems[0].Text;
                if (FoodDAO.Instance.getStyleOfFoodByName(item.SubItems[0].Text) == Constants.FOOD_TYPE.DRINK)
                {
                    cbProduct.Text = cbProduct.Items[1].ToString();
                } else cbProduct.Text = cbProduct.Items[0].ToString();

                UD_numberic.Value = Convert.ToInt32(item.SubItems[1].Text);
            }
        }

        private void bnt_deleFood_Click(object sender, EventArgs e)
        {
            if (timed)
            {
                var food = FoodDAO.Instance.GetFoodByName(cbNameProduct.Text);
                var food_room = Food_RoomDAO.Instance.GetFood_RoomByID(room.ID, food.ID);
                if (food_room != null)
                {
                    if (UD_numberic.Value < food_room.Amount)
                    {
                        int newValue = food_room.Amount - Convert.ToInt32(UD_numberic.Value);
                        Food_RoomDAO.Instance.UpdateFoodRoom(food_room.ID, newValue, newValue * food.Price);
                        reloadBillInf();
                    }
                    else
                    {
                        Food_RoomDAO.Instance.DeleteFoodRoom(food_room);
                        reloadBillInf();
                    }
                }
                timed = false;
            }
        }

        private void UD_numberic_ValueChanged(object sender, EventArgs e)
        {
            timed = true;
        }

        private void LoadListEmptyRoom(String RoomType)
        {
            cbChooseRoom.Items.Clear();
            if (RoomType == Constants.RoomType.NORMAL)
            {
                foreach (Room r in RoomDAO.Instance.GetEmptyRoom(Constants.RoomType.NORMAL))
                {
                    cbChooseRoom.Items.Add(r.Name);
                }
            }
            else
            {
                foreach (Room r in RoomDAO.Instance.GetEmptyRoom(Constants.RoomType.VIP))
                {
                    cbChooseRoom.Items.Add(r.Name);
                }
            }
        }

        private void bntChangeRoom_Click(object sender, EventArgs e)
        {
            /*
            Tạo ra 1 phòng mới :newRoom
            - Lấy Account_room phòng hiện tại -> đổi roomID thành newRoomID
            - Lấy các Food_room phòng hiện tại -> đổi roomID thành newRoomID
            - Update trạng thái phòng hiện tại -> EMPTY
            - Set trạng thái phòng mới thành FULL 
            */
            Room newRoom = RoomDAO.Instance.GetRoom(cbChooseRoom.Text);
            Account_RoomDAO.instance.updateAccR(room.ID, newRoom.ID);

            List<Food_Room> lsiFR = Food_RoomDAO.Instance.GetFood_RoomByRoomID(room.ID);
            foreach (Food_Room fr in lsiFR)
            {
                Food_RoomDAO.Instance.UpdateFoodRoom(fr, newRoom);
            }
            RoomDAO.Instance.UpdateRoom(room.ID, Constants.ROOM_STATUS.EMPTY);
            newRoom.RoomStatus = Constants.ROOM_STATUS.FULL;
            KaraokeContext.Instance.SaveChanges();
            LoadRoom();
        }

        private void bntPay_Click(object sender, EventArgs e)
        {
            /*
                Lấy time hiện tại gắn vào checkOut
                Tính tổng giá phòng bằng cách (checkOut - checkInt) * roomPrice * (100-discount) + Acc_room.totalPrice
                Tạo BillInfor gửi sang Form Bill_infor hiển thị chi tiết cho nhân viên check
                -------------------------------------------------------------------------------------------------------
                Form Bill_Infor close -> Cập nhật lại trạng thái phòng
             */
            //------------Get Account_room----------------
            if (RoomDAO.Instance.CheckValidRoom(room.ID) != null)
            {
                var checkOut = DateTime.Now;
                acc_r = Account_RoomDAO.instance.GetAccount_Room(room.ID);
                acc_r.CheckOut = checkOut;
                acc_r.Discount = Convert.ToInt32(UD_Discount.Value);
                acc_r.TotalPrice = Convert.ToInt32((checkOut - acc_r.CheckIn).TotalMinutes * room.Price / 60);
                //------------Get Food_room-------------------
                var fr = Food_RoomDAO.Instance.GetFood_RoomByRoomID(room.ID);
                //------------Create Bill Infor---------------
                bill.AccountName = AccountDAO.Instance.GetAccountByID(Constants.userID).Name;
                bill.RoomName = room.Name;
                bill.food_Rooms = fr;
                bill.checkIn = acc_r.CheckIn;
                bill.checkOut = acc_r.CheckOut;
                bill.DisCount = acc_r.Discount;

                bill.food_Rooms = fr;

                Bill_Infor bi = new Bill_Infor(bill);
                bi.FormClosed += BillForm_Close;
                bi.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn đang chọn thanh toán phòng trống", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    this.ActiveControl = null;
                }
            }
        }

        private void BillForm_Close(object sender, FormClosedEventArgs e)
        {
            if (isPay)
            {
                acc_r.PayStatus = Constants.BILL_TYPE.PAY;
                Account_RoomDAO.instance.UpdateAccountRoom(acc_r);
                room.RoomStatus = Constants.ROOM_STATUS.EMPTY;
                RoomDAO.Instance.UpdateRoom(room);
            }
        }

        private void cbTypePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypePay.Text)
            {
                case "Tiền Mặt":
                    bill.PayType = Constants.PAY_TYPE.CASH;
                    break;
                case "Chuyển Khoản":
                    bill.PayType = Constants.PAY_TYPE.CARD;
                    break;
                case "Samsung Pay":
                    bill.PayType = Constants.PAY_TYPE.SAMSUNGPAY;
                    break;
                case "Momo":
                    bill.PayType = Constants.PAY_TYPE.MOMO;
                    break;
                default:
                    break;
            }
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageRoomItem_Click(object sender, EventArgs e)
        {
            manageRoom.Visible = true;
        }

        private void manageMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountingItem_Click(object sender, EventArgs e)
        {

        }

        private void accountDetailItem_Click(object sender, EventArgs e)
        {

        }

        private void addAccountItem_Click(object sender, EventArgs e)
        {

        }

        private void staffListItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutMenu_Click(object sender, EventArgs e)
        {

        }
    }
}