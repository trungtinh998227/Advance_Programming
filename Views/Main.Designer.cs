namespace KaraokeApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlRoom = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvBill = new System.Windows.Forms.ListView();
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fPanel_Room_VIP = new System.Windows.Forms.FlowLayoutPanel();
            this.fPanel_Room_Normal = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTypePay = new System.Windows.Forms.ComboBox();
            this.cbChooseRoom = new System.Windows.Forms.ComboBox();
            this.bntChangeRoom = new KaraokeApp.RoundedButton();
            this.bntPrintBill = new KaraokeApp.RoundedButton();
            this.bntPay = new KaraokeApp.RoundedButton();
            this.roundPanel1 = new KaraokeApp.Custom_UI.RoundPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bnt_deleFood = new KaraokeApp.RoundedButton();
            this.bntAddFood = new KaraokeApp.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbNameProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.billPrintItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDetailItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            bnt_Exit = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.controlRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            bnt_Exit.Location = new System.Drawing.Point(1121, 3);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new System.Drawing.Size(23, 20);
            bnt_Exit.TabIndex = 12;
            bnt_Exit.UseCompatibleTextRendering = true;
            bnt_Exit.UseMnemonic = false;
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += new System.EventHandler(this.bnt_Exit_Click);
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
            button1.Location = new System.Drawing.Point(1092, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(23, 20);
            button1.TabIndex = 12;
            button1.UseCompatibleTextRendering = true;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
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
            button2.Location = new System.Drawing.Point(1063, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(23, 20);
            button2.TabIndex = 12;
            button2.UseCompatibleTextRendering = true;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.controlRoom);
            this.panel1.Controls.Add(bnt_Exit);
            this.panel1.Controls.Add(button2);
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 713);
            this.panel1.TabIndex = 13;
            // 
            // controlRoom
            // 
            this.controlRoom.Controls.Add(this.numericUpDown2);
            this.controlRoom.Controls.Add(this.label4);
            this.controlRoom.Controls.Add(this.label2);
            this.controlRoom.Controls.Add(this.lvBill);
            this.controlRoom.Controls.Add(this.fPanel_Room_VIP);
            this.controlRoom.Controls.Add(this.fPanel_Room_Normal);
            this.controlRoom.Controls.Add(this.cbTypePay);
            this.controlRoom.Controls.Add(this.cbChooseRoom);
            this.controlRoom.Controls.Add(this.bntChangeRoom);
            this.controlRoom.Controls.Add(this.bntPrintBill);
            this.controlRoom.Controls.Add(this.bntPay);
            this.controlRoom.Controls.Add(this.roundPanel1);
            this.controlRoom.Controls.Add(this.label3);
            this.controlRoom.Controls.Add(this.label1);
            this.controlRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlRoom.Location = new System.Drawing.Point(1, 31);
            this.controlRoom.Name = "controlRoom";
            this.controlRoom.Size = new System.Drawing.Size(1144, 682);
            this.controlRoom.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(866, 571);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Thông tin đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Giảm giá";
            // 
            // lvBill
            // 
            this.lvBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(191)))), ((int)(((byte)(190)))));
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodName,
            this.count,
            this.price,
            this.totalPrice});
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(582, 198);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(521, 352);
            this.lvBill.TabIndex = 15;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // foodName
            // 
            this.foodName.Text = "Tên món";
            this.foodName.Width = 244;
            // 
            // count
            // 
            this.count.Text = "Số lượng";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.count.Width = 76;
            // 
            // price
            // 
            this.price.Text = "Giá tiền";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 83;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Tổng tiền";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalPrice.Width = 114;
            // 
            // fPanel_Room_VIP
            // 
            this.fPanel_Room_VIP.AutoScroll = true;
            this.fPanel_Room_VIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(207)))));
            this.fPanel_Room_VIP.Location = new System.Drawing.Point(34, 383);
            this.fPanel_Room_VIP.Name = "fPanel_Room_VIP";
            this.fPanel_Room_VIP.Size = new System.Drawing.Size(527, 279);
            this.fPanel_Room_VIP.TabIndex = 14;
            // 
            // fPanel_Room_Normal
            // 
            this.fPanel_Room_Normal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fPanel_Room_Normal.AutoScroll = true;
            this.fPanel_Room_Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.fPanel_Room_Normal.Location = new System.Drawing.Point(34, 32);
            this.fPanel_Room_Normal.Name = "fPanel_Room_Normal";
            this.fPanel_Room_Normal.Size = new System.Drawing.Size(527, 316);
            this.fPanel_Room_Normal.TabIndex = 13;
            // 
            // cbTypePay
            // 
            this.cbTypePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTypePay.FormattingEnabled = true;
            this.cbTypePay.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Chuyển Khoản",
            "Samsung Pay"});
            this.cbTypePay.Location = new System.Drawing.Point(934, 571);
            this.cbTypePay.Name = "cbTypePay";
            this.cbTypePay.Size = new System.Drawing.Size(144, 21);
            this.cbTypePay.TabIndex = 12;
            this.cbTypePay.Text = "Hình thức thanh toán";
            // 
            // cbChooseRoom
            // 
            this.cbChooseRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbChooseRoom.FormattingEnabled = true;
            this.cbChooseRoom.IntegralHeight = false;
            this.cbChooseRoom.Location = new System.Drawing.Point(640, 570);
            this.cbChooseRoom.Name = "cbChooseRoom";
            this.cbChooseRoom.Size = new System.Drawing.Size(121, 21);
            this.cbChooseRoom.TabIndex = 11;
            this.cbChooseRoom.Text = "Chọn phòng";
            // 
            // bntChangeRoom
            // 
            this.bntChangeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntChangeRoom.Enabled = false;
            this.bntChangeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChangeRoom.Location = new System.Drawing.Point(631, 606);
            this.bntChangeRoom.Name = "bntChangeRoom";
            this.bntChangeRoom.Size = new System.Drawing.Size(139, 48);
            this.bntChangeRoom.TabIndex = 8;
            this.bntChangeRoom.Text = "Đổi phòng";
            this.bntChangeRoom.UseVisualStyleBackColor = true;
            // 
            // bntPrintBill
            // 
            this.bntPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPrintBill.Enabled = false;
            this.bntPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPrintBill.Location = new System.Drawing.Point(792, 606);
            this.bntPrintBill.Name = "bntPrintBill";
            this.bntPrintBill.Size = new System.Drawing.Size(134, 48);
            this.bntPrintBill.TabIndex = 7;
            this.bntPrintBill.Text = "In hóa đơn";
            this.bntPrintBill.UseVisualStyleBackColor = true;
            // 
            // bntPay
            // 
            this.bntPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPay.Enabled = false;
            this.bntPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntPay.Location = new System.Drawing.Point(944, 606);
            this.bntPay.Name = "bntPay";
            this.bntPay.Size = new System.Drawing.Size(134, 48);
            this.bntPay.TabIndex = 7;
            this.bntPay.Text = "Thanh toán";
            this.bntPay.UseVisualStyleBackColor = true;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.roundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Controls.Add(this.numericUpDown1);
            this.roundPanel1.Controls.Add(this.bnt_deleFood);
            this.roundPanel1.Controls.Add(this.bntAddFood);
            this.roundPanel1.Controls.Add(this.label5);
            this.roundPanel1.Controls.Add(this.cbProduct);
            this.roundPanel1.Controls.Add(this.cbNameProduct);
            this.roundPanel1.Edge = 20;
            this.roundPanel1.Location = new System.Drawing.Point(582, 32);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(521, 124);
            this.roundPanel1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(372, 53);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bnt_deleFood
            // 
            this.bnt_deleFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_deleFood.Enabled = false;
            this.bnt_deleFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_deleFood.Location = new System.Drawing.Point(424, 63);
            this.bnt_deleFood.Name = "bnt_deleFood";
            this.bnt_deleFood.Size = new System.Drawing.Size(77, 43);
            this.bnt_deleFood.TabIndex = 3;
            this.bnt_deleFood.Text = "Xóa";
            this.bnt_deleFood.UseVisualStyleBackColor = true;
            // 
            // bntAddFood
            // 
            this.bntAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAddFood.Enabled = false;
            this.bntAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddFood.Location = new System.Drawing.Point(424, 14);
            this.bntAddFood.Name = "bntAddFood";
            this.bntAddFood.Size = new System.Drawing.Size(77, 43);
            this.bntAddFood.TabIndex = 3;
            this.bntAddFood.Text = "Thêm";
            this.bntAddFood.UseVisualStyleBackColor = true;
            this.bntAddFood.Click += new System.EventHandler(this.bntAddFood_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // cbProduct
            // 
            this.cbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Items.AddRange(new object[] {
            "Thức ăn",
            "Nước uống"});
            this.cbProduct.Location = new System.Drawing.Point(22, 31);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(269, 21);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.Text = "Sản phẩm";
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // cbNameProduct
            // 
            this.cbNameProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNameProduct.FormattingEnabled = true;
            this.cbNameProduct.Location = new System.Drawing.Point(22, 73);
            this.cbNameProduct.Name = "cbNameProduct";
            this.cbNameProduct.Size = new System.Drawing.Size(269, 21);
            this.cbNameProduct.TabIndex = 1;
            this.cbNameProduct.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách phòng VIP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phòng thường";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionMenu,
            this.accountMenu,
            this.logOutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(3, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(223, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionMenu
            // 
            this.optionMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionMenu.BackgroundImage")));
            this.optionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billPrintItem,
            this.manageRoomItem,
            this.manageMenuItem,
            this.accountingItem});
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(68, 20);
            this.optionMenu.Text = "Tùy chọn";
            // 
            // billPrintItem
            // 
            this.billPrintItem.Name = "billPrintItem";
            this.billPrintItem.Size = new System.Drawing.Size(170, 22);
            this.billPrintItem.Text = "Trang chủ";
            // 
            // manageRoomItem
            // 
            this.manageRoomItem.Name = "manageRoomItem";
            this.manageRoomItem.Size = new System.Drawing.Size(170, 22);
            this.manageRoomItem.Text = "Quản lý phòng";
            // 
            // manageMenuItem
            // 
            this.manageMenuItem.Name = "manageMenuItem";
            this.manageMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageMenuItem.Text = "Quản lý thực đơn";
            // 
            // accountingItem
            // 
            this.accountingItem.Name = "accountingItem";
            this.accountingItem.Size = new System.Drawing.Size(170, 22);
            this.accountingItem.Text = "Thống kê";
            // 
            // accountMenu
            // 
            this.accountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountDetailItem,
            this.addAccountItem,
            this.staffListItem});
            this.accountMenu.Name = "accountMenu";
            this.accountMenu.Size = new System.Drawing.Size(71, 20);
            this.accountMenu.Text = "Tài khoản";
            // 
            // accountDetailItem
            // 
            this.accountDetailItem.Name = "accountDetailItem";
            this.accountDetailItem.Size = new System.Drawing.Size(187, 22);
            this.accountDetailItem.Text = "Thông tin tài khoản";
            // 
            // addAccountItem
            // 
            this.addAccountItem.Name = "addAccountItem";
            this.addAccountItem.Size = new System.Drawing.Size(187, 22);
            this.addAccountItem.Text = "Thêm tài khoản";
            // 
            // staffListItem
            // 
            this.staffListItem.Name = "staffListItem";
            this.staffListItem.Size = new System.Drawing.Size(187, 22);
            this.staffListItem.Text = "Danh sách nhân viên";
            // 
            // logOutMenu
            // 
            this.logOutMenu.Name = "logOutMenu";
            this.logOutMenu.Size = new System.Drawing.Size(76, 20);
            this.logOutMenu.Text = "Đăng xuất";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1171, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.controlRoom.ResumeLayout(false);
            this.controlRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionMenu;
        private System.Windows.Forms.ToolStripMenuItem accountMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutMenu;
        private System.Windows.Forms.ToolStripMenuItem manageRoomItem;
        private System.Windows.Forms.ToolStripMenuItem manageMenuItem;
        private System.Windows.Forms.Panel controlRoom;
        private System.Windows.Forms.ToolStripMenuItem accountingItem;
        private System.Windows.Forms.ToolStripMenuItem billPrintItem;
        private System.Windows.Forms.ToolStripMenuItem accountDetailItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountItem;
        private System.Windows.Forms.ToolStripMenuItem staffListItem;
        private System.Windows.Forms.Label label1;
        private RoundedButton bntAddFood;
        private System.Windows.Forms.ComboBox cbNameProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label5;
        private Custom_UI.RoundPanel roundPanel1;
        private RoundedButton bnt_deleFood;
        private RoundedButton bntChangeRoom;
        private RoundedButton bntPay;
        private System.Windows.Forms.ComboBox cbChooseRoom;
        private System.Windows.Forms.ComboBox cbTypePay;
        private RoundedButton bntPrintBill;
        private System.Windows.Forms.FlowLayoutPanel fPanel_Room_Normal;
        private System.Windows.Forms.FlowLayoutPanel fPanel_Room_VIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}