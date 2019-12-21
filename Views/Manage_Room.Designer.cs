namespace KaraokeApp.Views
{
    partial class Manage_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Room));
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntDate = new KaraokeApp.RoundedButton();
            this.bntBookRoom = new KaraokeApp.RoundedButton();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txb_RoomStyle = new System.Windows.Forms.TextBox();
            this.txb_RoomID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            bnt_Exit = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            bnt_Exit.Location = new System.Drawing.Point(631, 3);
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
            button2.Location = new System.Drawing.Point(573, 3);
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
            button1.Location = new System.Drawing.Point(602, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(23, 20);
            button1.TabIndex = 15;
            button1.UseCompatibleTextRendering = true;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(117)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(bnt_Exit);
            this.panel1.Controls.Add(button2);
            this.panel1.Controls.Add(button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 296);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker_Date);
            this.panel2.Controls.Add(this.bntDate);
            this.panel2.Controls.Add(this.bntBookRoom);
            this.panel2.Controls.Add(this.cb_Status);
            this.panel2.Controls.Add(this.txbTime);
            this.panel2.Controls.Add(this.txb_RoomStyle);
            this.panel2.Controls.Add(this.txb_RoomID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 265);
            this.panel2.TabIndex = 16;
            // 
            // bntDate
            // 
            this.bntDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDate.ForeColor = System.Drawing.Color.Red;
            this.bntDate.Location = new System.Drawing.Point(465, 192);
            this.bntDate.Name = "bntDate";
            this.bntDate.Size = new System.Drawing.Size(128, 48);
            this.bntDate.TabIndex = 8;
            this.bntDate.Text = "Hẹn";
            this.bntDate.UseVisualStyleBackColor = true;
            this.bntDate.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntBookRoom
            // 
            this.bntBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBookRoom.Location = new System.Drawing.Point(309, 192);
            this.bntBookRoom.Name = "bntBookRoom";
            this.bntBookRoom.Size = new System.Drawing.Size(128, 48);
            this.bntBookRoom.TabIndex = 8;
            this.bntBookRoom.Text = "Đặt phòng";
            this.bntBookRoom.UseVisualStyleBackColor = true;
            this.bntBookRoom.Click += new System.EventHandler(this.bntBookRoom_Click);
            // 
            // cb_Status
            // 
            this.cb_Status.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "EMPTY",
            "DATE",
            "FULL"});
            this.cb_Status.Location = new System.Drawing.Point(469, 72);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(138, 22);
            this.cb_Status.TabIndex = 2;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // txbTime
            // 
            this.txbTime.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTime.Location = new System.Drawing.Point(469, 117);
            this.txbTime.Name = "txbTime";
            this.txbTime.ReadOnly = true;
            this.txbTime.Size = new System.Drawing.Size(138, 20);
            this.txbTime.TabIndex = 1;
            // 
            // txb_RoomStyle
            // 
            this.txb_RoomStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RoomStyle.Location = new System.Drawing.Point(185, 116);
            this.txb_RoomStyle.Name = "txb_RoomStyle";
            this.txb_RoomStyle.ReadOnly = true;
            this.txb_RoomStyle.Size = new System.Drawing.Size(100, 20);
            this.txb_RoomStyle.TabIndex = 1;
            // 
            // txb_RoomID
            // 
            this.txb_RoomID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RoomID.Location = new System.Drawing.Point(185, 74);
            this.txb_RoomID.Name = "txb_RoomID";
            this.txb_RoomID.ReadOnly = true;
            this.txb_RoomID.Size = new System.Drawing.Size(100, 20);
            this.txb_RoomID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(456, 118);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 10;
            this.dateTimePicker_Date.Visible = false;
            // 
            // Manage_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(117)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(682, 322);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Room";
            this.Load += new System.EventHandler(this.Manage_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_RoomID;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txb_RoomStyle;
        private RoundedButton bntDate;
        private RoundedButton bntBookRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
    }
}