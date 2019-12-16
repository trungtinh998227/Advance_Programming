namespace KaraokeApp.Views
{
    partial class Bill_Infor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button bnt_Exit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Infor));
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbGuessPay = new System.Windows.Forms.MaskedTextBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTypePay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbExcessCash = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalRoom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckin = new System.Windows.Forms.TextBox();
            this.txbCheckout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTotalTime = new System.Windows.Forms.TextBox();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.txbRoomName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bntCancel = new KaraokeApp.RoundedButton();
            this.bntPay = new KaraokeApp.RoundedButton();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            bnt_Exit = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_Exit
            // 
            bnt_Exit.BackColor = System.Drawing.Color.Transparent;
            bnt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            bnt_Exit.CausesValidation = false;
            bnt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            bnt_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            bnt_Exit.FlatAppearance.BorderSize = 0;
            bnt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Exit.Image")));
            bnt_Exit.Location = new System.Drawing.Point(686, 3);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new System.Drawing.Size(23, 20);
            bnt_Exit.TabIndex = 13;
            bnt_Exit.UseCompatibleTextRendering = true;
            bnt_Exit.UseMnemonic = false;
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += new System.EventHandler(this.bnt_Exit_Click);
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button2.CausesValidation = false;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            button2.Location = new System.Drawing.Point(628, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(23, 20);
            button2.TabIndex = 14;
            button2.UseCompatibleTextRendering = true;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.CausesValidation = false;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(657, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(23, 20);
            button1.TabIndex = 15;
            button1.UseCompatibleTextRendering = true;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(87)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bntCancel);
            this.panel1.Controls.Add(this.bntPay);
            this.panel1.Controls.Add(this.lvOrder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.accountName);
            this.panel1.Controls.Add(this.lbTotalBill);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(bnt_Exit);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 532);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.txbGuessPay);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbTypePay);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txbExcessCash);
            this.panel3.Location = new System.Drawing.Point(369, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 167);
            this.panel3.TabIndex = 22;
            // 
            // txbGuessPay
            // 
            this.txbGuessPay.Location = new System.Drawing.Point(158, 56);
            this.txbGuessPay.Name = "txbGuessPay";
            this.txbGuessPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbGuessPay.Size = new System.Drawing.Size(158, 20);
            this.txbGuessPay.TabIndex = 23;
            this.txbGuessPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbGuessPay.TextChanged += new System.EventHandler(this.txbGuessPay_TextChanged);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.txbTotalPrice.Location = new System.Drawing.Point(159, 15);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(157, 20);
            this.txbTotalPrice.TabIndex = 18;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thanh toán:";
            // 
            // cbTypePay
            // 
            this.cbTypePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTypePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypePay.FormattingEnabled = true;
            this.cbTypePay.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Chuyển Khoản",
            "Samsung Pay",
            "Momo"});
            this.cbTypePay.Location = new System.Drawing.Point(159, 133);
            this.cbTypePay.Name = "cbTypePay";
            this.cbTypePay.Size = new System.Drawing.Size(157, 21);
            this.cbTypePay.TabIndex = 20;
            this.cbTypePay.Text = "Hình thức thanh toán";
            this.cbTypePay.SelectedIndexChanged += new System.EventHandler(this.cbTypePay_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lavender;
            this.label9.Location = new System.Drawing.Point(14, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tiền khách đưa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(14, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tiền thừa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lavender;
            this.label11.Location = new System.Drawing.Point(14, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Phương thức:";
            // 
            // txbExcessCash
            // 
            this.txbExcessCash.Cursor = System.Windows.Forms.Cursors.No;
            this.txbExcessCash.Location = new System.Drawing.Point(159, 94);
            this.txbExcessCash.Name = "txbExcessCash";
            this.txbExcessCash.ReadOnly = true;
            this.txbExcessCash.Size = new System.Drawing.Size(157, 20);
            this.txbExcessCash.TabIndex = 18;
            this.txbExcessCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.lbTotalRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCheckin);
            this.panel2.Controls.Add(this.txbCheckout);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbTotalTime);
            this.panel2.Controls.Add(this.txbDiscount);
            this.panel2.Controls.Add(this.txbRoomName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(369, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 197);
            this.panel2.TabIndex = 21;
            // 
            // lbTotalRoom
            // 
            this.lbTotalRoom.AutoSize = true;
            this.lbTotalRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRoom.ForeColor = System.Drawing.Color.Lavender;
            this.lbTotalRoom.Location = new System.Drawing.Point(189, 168);
            this.lbTotalRoom.Name = "lbTotalRoom";
            this.lbTotalRoom.Size = new System.Drawing.Size(127, 19);
            this.lbTotalRoom.TabIndex = 19;
            this.lbTotalRoom.Text = "1000000000 VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Check in:";
            // 
            // txtCheckin
            // 
            this.txtCheckin.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCheckin.Location = new System.Drawing.Point(119, 25);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.ReadOnly = true;
            this.txtCheckin.Size = new System.Drawing.Size(197, 20);
            this.txtCheckin.TabIndex = 18;
            this.txtCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbCheckout
            // 
            this.txbCheckout.Cursor = System.Windows.Forms.Cursors.No;
            this.txbCheckout.Location = new System.Drawing.Point(119, 66);
            this.txbCheckout.Name = "txbCheckout";
            this.txbCheckout.ReadOnly = true;
            this.txbCheckout.Size = new System.Drawing.Size(197, 20);
            this.txbCheckout.TabIndex = 18;
            this.txbCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Check out:";
            // 
            // txbTotalTime
            // 
            this.txbTotalTime.Cursor = System.Windows.Forms.Cursors.No;
            this.txbTotalTime.Location = new System.Drawing.Point(275, 102);
            this.txbTotalTime.Name = "txbTotalTime";
            this.txbTotalTime.ReadOnly = true;
            this.txbTotalTime.Size = new System.Drawing.Size(41, 20);
            this.txbTotalTime.TabIndex = 18;
            this.txbTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbDiscount
            // 
            this.txbDiscount.Location = new System.Drawing.Point(119, 136);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.ReadOnly = true;
            this.txbDiscount.Size = new System.Drawing.Size(63, 20);
            this.txbDiscount.TabIndex = 18;
            this.txbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbRoomName
            // 
            this.txbRoomName.Cursor = System.Windows.Forms.Cursors.No;
            this.txbRoomName.Location = new System.Drawing.Point(119, 103);
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.ReadOnly = true;
            this.txbRoomName.Size = new System.Drawing.Size(63, 20);
            this.txbRoomName.TabIndex = 18;
            this.txbRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(14, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giảm giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phòng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lavender;
            this.label13.Location = new System.Drawing.Point(202, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Số giờ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(99, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tổng tiền:";
            // 
            // bntCancel
            // 
            this.bntCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bntCancel.Location = new System.Drawing.Point(551, 478);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(134, 48);
            this.bntCancel.TabIndex = 19;
            this.bntCancel.Text = "Hủy";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntPay
            // 
            this.bntPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntPay.Location = new System.Drawing.Point(378, 478);
            this.bntPay.Name = "bntPay";
            this.bntPay.Size = new System.Drawing.Size(134, 48);
            this.bntPay.TabIndex = 19;
            this.bntPay.Text = "Thanh toán";
            this.bntPay.UseVisualStyleBackColor = true;
            this.bntPay.Click += new System.EventHandler(this.bntPay_Click);
            // 
            // lvOrder
            // 
            this.lvOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodName,
            this.amount,
            this.totalPrice});
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(14, 88);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(331, 379);
            this.lvOrder.TabIndex = 17;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // foodName
            // 
            this.foodName.Text = "Tên món";
            this.foodName.Width = 140;
            // 
            // amount
            // 
            this.amount.Text = "Số lượng";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Tổng tiền";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalPrice.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(140, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn hàng";
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.ForeColor = System.Drawing.Color.Black;
            this.accountName.Location = new System.Drawing.Point(526, 58);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(174, 18);
            this.accountName.TabIndex = 16;
            this.accountName.Text = "Nguyễn Hoàng Diệp Thảo";
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBill.ForeColor = System.Drawing.Color.Lavender;
            this.lbTotalBill.Location = new System.Drawing.Point(204, 483);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(127, 19);
            this.lbTotalBill.TabIndex = 16;
            this.lbTotalBill.Text = "1000000000 VNĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(121, 483);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tổng đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(453, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thu ngân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(218, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông tin thanh toán";
            // 
            // Bill_Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(87)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(739, 556);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill_Infor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Infor";
            this.Load += new System.EventHandler(this.Bill_Infor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCheckout;
        private System.Windows.Forms.TextBox txtCheckin;
        private System.Windows.Forms.TextBox txbRoomName;
        private System.Windows.Forms.TextBox txbTotalTime;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbExcessCash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private RoundedButton bntCancel;
        private RoundedButton bntPay;
        private System.Windows.Forms.ComboBox cbTypePay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotalRoom;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txbGuessPay;
    }
}