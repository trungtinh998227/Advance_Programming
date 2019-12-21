using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KaraokeApp.Views
{
    public partial class Bill_Infor : Form
    {
        private BillInfor bill;
        private int endprice = 0;
        private static Boolean pay = true;
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
        public Bill_Infor(BillInfor bill)
        {
            this.bill = bill;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }

        private void Bill_Infor_Load(object sender, EventArgs e)
        {
            accountName.Text = bill.AccountName;
            txtCheckin.Text = bill.checkIn.ToString();
            txbCheckout.Text = bill.checkOut.ToString();
            txbRoomName.Text = bill.RoomName;
            txbDiscount.Text = bill.DisCount.ToString();
            txbTotalTime.Text = ((bill.checkOut - bill.checkIn).Value.TotalMinutes/60).ToString("0.00");
            Console.WriteLine(txbTotalTime.Text);
            var totalRoomPrice = Convert.ToDouble(txbTotalTime.Text) * RoomDAO.Instance.GetRoomPrice(bill.RoomName);
            if (bill.DisCount != 0)
            {
                totalRoomPrice = Convert.ToInt32((totalRoomPrice * (1 - bill.DisCount/100)));
                lbTotalRoom.Text = totalRoomPrice.ToString("###,###") + " VNĐ";
            }
            else lbTotalRoom.Text = totalRoomPrice.ToString("###,###");
            LoadBillOder(bill.food_Rooms);
            endprice += Convert.ToInt32(totalRoomPrice);
            txbTotalPrice.Text = endprice.ToString("###,###");
            //---------------------------------------------------------------------------------------------------------
            switch (bill.PayType)
            {
                case "CASH":
                    cbTypePay.Text = "Tiền Mặt";
                    break;
                case "CARD":
                    cbTypePay.Text = "Chuyển Khoản";
                    break;
                case "SAMSUNGPAY":
                    cbTypePay.Text = "Samsung Pay";
                    break;
                case ".MOMO":
                    cbTypePay.Text = "Momo";
                    break;
                default:
                    break;
            }
            pay = true;

        }
        private void LoadBillOder(List<Food_Room> food_Rooms)
        {
            int totalprice = 0;
            lvOrder.Items.Clear();
            foreach (Food_Room fr in food_Rooms)
            {
                ListViewItem lvitems = new ListViewItem(FoodDAO.Instance.GetFoodNameByID(fr.Food.ID));
                lvitems.SubItems.Add(fr.Amount.ToString());
                lvitems.SubItems.Add(fr.TotalPrice.ToString("###,###"));
                totalprice += fr.TotalPrice;
                lvOrder.Items.Add(lvitems);
            }
            endprice += totalprice;
            lbTotalBill.Text = totalprice.ToString("###,###") + " VNĐ";
        }
        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbGuessPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bill.GuessPay = Convert.ToInt32(Convert.ToDouble(txbGuessPay.Text));
                txbGuessPay.Text = Convert.ToDouble(txbGuessPay.Text).ToString("###,###");
                txbGuessPay.SelectionStart = txbGuessPay.Text.Length;
                txbGuessPay.SelectionLength = 0;
                bill.ExcessCash = Convert.ToInt32(Convert.ToDouble(txbGuessPay.Text) - Convert.ToDouble(txbTotalPrice.Text));
                txbExcessCash.Text = (Convert.ToDouble(txbGuessPay.Text) - Convert.ToDouble(txbTotalPrice.Text)).ToString("###,###");
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void bntPay_Click(object sender, EventArgs e)
        {
            /*

            */
            Main.isPay = true;
            if (pay)
            {
                try
                {
                    foreach (Food_Room fr in bill.food_Rooms)
                    {
                        fr.BillInfor_ID = bill.ID;
                        fr.PayStatus = Constants.BILL_TYPE.PAY;
                        KaraokeContext.Instance.SaveChanges();
                    }
                }
                catch (Exception exx)
                {
                    exx.ToString();
                }
                bill.Payment = endprice;
                BillInforDAO.Instance.AddBillInfor(bill);
            }
            pay = false;
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
