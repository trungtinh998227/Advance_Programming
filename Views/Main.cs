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
        private static string foodType;
        static int RoomWidth = 160;
        static int RoomHeight = 90;
        static Boolean timed = true;
        private Room room { get; set; }
        private int updateRoomID { get; set; }
        private int updateFoodID { get; set; }
        private Account_Room acc_r { get; set; }
        private BillInfor bill = new BillInfor();
        private Producer producer { get; set; }
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
            (sender as Button).ForeColor = Color.Black;
        }

        private void bnt_Normal_LostFocus(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
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
            Console.WriteLine("aaa");
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
                LoadRoom();
                lvBill.Items.Clear();
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
            manageMenu.Visible = false;
        }

 

        private void manageRoom_VisibleChanged(object sender, EventArgs e)
        {
            if (manageRoom.Visible)
                LoadDataRoom();
        }
        private void LoadDataRoom()
        {
            lvRoom.Items.Clear();
            var roomData = RoomDAO.Instance.GetRooms();
            foreach (Room fr in roomData)
            {
                ListViewItem lvitems = new ListViewItem(fr.Name);
                lvitems.SubItems.Add(fr.RoomType);
                lvitems.SubItems.Add(fr.RoomStatus);
                lvitems.SubItems.Add(fr.Price.ToString("###,###"));
                lvRoom.Items.Add(lvitems);
            }
        }

        private void bntAddRoom_Click(object sender, EventArgs e)
        {
            if (RoomDAO.Instance.GetRoom(txbNameRoom.Text) == null)
            {
                Room r = new Room(txbNameRoom.Text, Constants.ROOM_STATUS.EMPTY, cbRoom_Type.Text, Convert.ToInt32(Convert.ToDouble(txbRoomPrice.Text)));
                RoomDAO.Instance.AddRoom(r);
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNameRoom.Text = "";
                cbRoom_Type.Text = "";
                txbRoomPrice.Text = "";
                LoadDataRoom();
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Phòng đã tồn tại\n Vui lòng nhập lại thông tin phòng", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoom.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRoom.SelectedItems[0];
                if (item.SubItems[2].Text == "FULL" || item.SubItems[2].Text == "DATE")
                {
                    bntDeleteRoom.Enabled = false;
                    bntEditRoom.Enabled = false;
                }
                else
                {
                    bntDeleteRoom.Enabled = true;
                    bntEditRoom.Enabled = true;
                }
                txbNameRoom.Text = item.SubItems[0].Text;
                updateRoomID = RoomDAO.Instance.GetRoom(item.SubItems[0].Text).ID;
                cbRoom_Type.Text = item.SubItems[1].Text;
                txbRoomPrice.Text = item.SubItems[3].Text;
            }
        }

        private void billPrintItem_Click(object sender, EventArgs e)
        {
            manageRoom.Visible = false;
            manageMenu.Visible = false;
        }

        private void bntEditRoom_Click(object sender, EventArgs e)
        {
            var updateRoom = RoomDAO.Instance.GetRoom(updateRoomID);
            if(updateRoom != null)
            {
                updateRoom.Name = txbNameRoom.Text;
                updateRoom.RoomStatus = Constants.ROOM_STATUS.EMPTY;
                updateRoom.RoomType = cbRoom_Type.Text;
                updateRoom.Price = Convert.ToInt32(Convert.ToDouble(txbRoomPrice.Text));
                KaraokeContext.Instance.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNameRoom.Text = "";
                cbRoom_Type.Text = "";
                txbRoomPrice.Text = "";
                LoadDataRoom();
                LoadRoom();
            }
        }

        private void txbRoomPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbRoomPrice.Text != "")
                {
                    txbRoomPrice.Text = Convert.ToDouble(txbRoomPrice.Text).ToString("###,###");
                    txbRoomPrice.SelectionStart = txbRoomPrice.Text.Length;
                    txbRoomPrice.SelectionLength = 0;
                }
            }
            catch (Exception exx)
            {
                exx.ToString();
            }
            
        }

        private void txbNameRoom_TextChanged(object sender, EventArgs e)
        {
            if (txbNameRoom.Text != "" && RoomDAO.Instance.GetRoom(txbNameRoom.Text) == null)
            {
                bntAddRoom.Enabled = true;
                bntDeleteRoom.Enabled = false;
                bntEditRoom.Enabled = false;
            }
            else
            {
                bntAddRoom.Enabled = false;
                bntDeleteRoom.Enabled = true;
                bntEditRoom.Enabled = true;
            }
        }

        private void bntDeleteRoom_Click(object sender, EventArgs e)
        {
            var room_dele = RoomDAO.Instance.GetRoom(txbNameRoom.Text);
            if (room_dele!= null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    RoomDAO.Instance.deleteRoom(room_dele);
                    txbNameRoom.Text = "";
                    cbRoom_Type.Text = "";
                    txbRoomPrice.Text = "";
                    LoadDataRoom();
                    LoadRoom();
                }
            }
        }

        private void manageMenuItem_Click(object sender, EventArgs e)
        {
            manageMenu.Visible = true;
            manageRoom.Visible = false;
        }

        private void manageMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (manageMenu.Visible)
            {
                LoadMenuData();
                var pro = ProducerDAO.Instance.GetProducers();
                foreach (Producer pr in pro)
                {
                    cbProducer.Items.Add(pr.Name);
                }
            }
        }
        private void LoadMenuData()
        {
            // Load Food data
            lvFoodList.Items.Clear();
            var foodData = FoodDAO.Instance.GetFoods();
            foreach (Food f in foodData)
            {
                ListViewItem lvitems = new ListViewItem(f.Name);
                lvitems.SubItems.Add(f.Inventory.ToString());
                lvitems.SubItems.Add(f.Unit);
                lvitems.SubItems.Add(f.Price.ToString("###,###"));
                lvitems.SubItems.Add(ProducerDAO.Instance.GetProducerName(f.producers.ID));
                lvFoodList.Items.Add(lvitems);
            }
            // Load Drink data
            lvDrinkList.Items.Clear();
            var drinkData = FoodDAO.Instance.GetDrinks();
            foreach (Food f in drinkData)
            {
                ListViewItem lvitems = new ListViewItem(f.Name);
                lvitems.SubItems.Add(f.Inventory.ToString());
                lvitems.SubItems.Add(f.Unit);
                lvitems.SubItems.Add(f.Price.ToString("###,###"));
                lvitems.SubItems.Add(ProducerDAO.Instance.GetProducerName(f.producers.ID));
                lvDrinkList.Items.Add(lvitems);
            }
        }

        private void lvFoodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodType = "FOOD";
            if (lvFoodList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvFoodList.SelectedItems[0];
                txbNameFood.Text = item.SubItems[0].Text.ToString();
                updateRoomID = FoodDAO.Instance.GetFoodByName(item.SubItems[0].Text).ID;
                UD_Amount.Value = Convert.ToInt32(item.SubItems[1].Text);
                txbUnit.Text = item.SubItems[2].Text;
                cbProducer.Text =  item.SubItems[4].Text;
                txbFoodPrice.Text = item.SubItems[3].Text;
            }
        }
        private void lvDrinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodType = "DRINK";
            if (lvDrinkList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDrinkList.SelectedItems[0];
                txbNameFood.Text = item.SubItems[0].Text;
                updateRoomID = FoodDAO.Instance.GetFoodByName(item.SubItems[0].Text).ID;
                UD_Amount.Value = Convert.ToInt32(item.SubItems[1].Text);
                txbUnit.Text = item.SubItems[2].Text;
                cbProducer.Text = item.SubItems[4].Text;
                txbFoodPrice.Text = item.SubItems[3].Text;
            }
        }

        private void bntAddNewFood_Click(object sender, EventArgs e)
        {
            Food f = new Food(txbNameFood.Text, Convert.ToInt32(UD_Amount.Value), txbUnit.Text, Convert.ToInt32(Convert.ToDouble(txbFoodPrice.Text)), foodType);
            f.producers = producer;
            FoodDAO.Instance.AddFood(f);
            MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbNameFood.Text = "";
            txbUnit.Text = "";
            UD_Amount.Value = 1;
            cbProducer.Text = "";
            txbFoodPrice.Text = "";
            LoadMenuData();
}

        private void bntDeleteFood_Click(object sender, EventArgs e)
        {
            var food_dele = FoodDAO.Instance.GetFoodByName(txbNameRoom.Text);
            if (food_dele != null)
            {
                
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    FoodDAO.Instance.deleteFood(food_dele);
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbNameFood.Text = "";
                    txbUnit.Text = "";
                    UD_Amount.Value = 1;
                    cbProducer.Text = "";
                    txbFoodPrice.Text = "";
                    LoadMenuData();
                }
            }
        }

        private void bntEditFood_Click(object sender, EventArgs e)
        {
            var updateFood = FoodDAO.Instance.GetFoodByID(updateRoomID);
            if (updateFood != null)
            {
                updateFood.Name = txbNameFood.Text;
                updateFood.Inventory = Convert.ToInt32(UD_Amount.Value);
                updateFood.producers = producer;
                updateFood.Price = Convert.ToInt32(Convert.ToDouble(txbFoodPrice.Text));
                updateFood.Unit = txbUnit.Text;
                KaraokeContext.Instance.SaveChanges();

                MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNameFood.Text = "";
                txbUnit.Text = "";
                UD_Amount.Value = 1;
                cbProducer.Text = "";
                txbFoodPrice.Text = "";
                LoadMenuData();
            }
        }

        private void txbNameFood_TextChanged(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.GetFoodByName(txbNameFood.Text)!=null)
            {
                bntAddNewFood.Enabled = false;
                bntDeleteFood.Enabled = true;
                bntEditFood.Enabled = true;
            }
            else
            {
                bntAddNewFood.Enabled = true;
                bntDeleteFood.Enabled = false;
                bntEditFood.Enabled = false;
            }
        }

        private void txbFoodPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbFoodPrice.Text != "")
                {
                    txbFoodPrice.Text = Convert.ToDouble(txbFoodPrice.Text).ToString("###,###");
                    txbFoodPrice.SelectionStart = txbFoodPrice.Text.Length;
                    txbFoodPrice.SelectionLength = 0;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            
        }

        private void cbProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProducer.Text)
            {
                case "Red Bull GmbH":
                    producer = ProducerDAO.Instance.GetProducerByName("Red Bull GmbH");
                    break;
                case "Tân Hiệp Phát":
                    producer = ProducerDAO.Instance.GetProducerByName("Tân Hiệp Phát");
                    break;
                case "Bách Hóa Xanh":
                    producer = ProducerDAO.Instance.GetProducerByName("Bách Hóa Xanh");
                    break;
                case "The Coffe House":
                    producer = ProducerDAO.Instance.GetProducerByName("The Coffe House");
                    break;
                default:
                    break;
            }
        }

        private void accountDetailItem_Click(object sender, EventArgs e)
        {
            Account_Infor ac_i = new Account_Infor();
            ac_i.ShowDialog();
        }

        private void staffListItem_Click(object sender, EventArgs e)
        {

        }
    }
}