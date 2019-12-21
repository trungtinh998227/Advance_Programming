namespace KaraokeApp
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntForgetPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invalidAccount = new System.Windows.Forms.Label();
            this.invalidUser = new System.Windows.Forms.Label();
            this.InvalidPass = new System.Windows.Forms.Label();
            this.bnt_Login = new KaraokeApp.RoundedButton();
            this.txb_Pass = new KaraokeApp.RoundTextbox();
            this.txb_UserName = new KaraokeApp.RoundTextbox();
            bnt_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            bnt_Exit.Location = new System.Drawing.Point(355, 12);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new System.Drawing.Size(23, 20);
            bnt_Exit.TabIndex = 10;
            bnt_Exit.UseCompatibleTextRendering = true;
            bnt_Exit.UseMnemonic = false;
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += new System.EventHandler(this.bnt_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bntForgetPass
            // 
            this.bntForgetPass.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.bntForgetPass.AutoSize = true;
            this.bntForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntForgetPass.ForeColor = System.Drawing.Color.Red;
            this.bntForgetPass.Location = new System.Drawing.Point(119, 475);
            this.bntForgetPass.Name = "bntForgetPass";
            this.bntForgetPass.Size = new System.Drawing.Size(123, 16);
            this.bntForgetPass.TabIndex = 9;
            this.bntForgetPass.Text = "Forget  Password ?";
            this.bntForgetPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invalidAccount);
            this.panel1.Controls.Add(this.invalidUser);
            this.panel1.Controls.Add(this.InvalidPass);
            this.panel1.Controls.Add(this.bnt_Login);
            this.panel1.Controls.Add(this.txb_Pass);
            this.panel1.Controls.Add(this.txb_UserName);
            this.panel1.Controls.Add(this.bntForgetPass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 526);
            this.panel1.TabIndex = 10;
            // 
            // invalidAccount
            // 
            this.invalidAccount.AutoSize = true;
            this.invalidAccount.ForeColor = System.Drawing.Color.Red;
            this.invalidAccount.Location = new System.Drawing.Point(122, 225);
            this.invalidAccount.Name = "invalidAccount";
            this.invalidAccount.Size = new System.Drawing.Size(120, 13);
            this.invalidAccount.TabIndex = 14;
            this.invalidAccount.Text = "Tài khoản không hợp lệ";
            this.invalidAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invalidAccount.Visible = false;
            // 
            // invalidUser
            // 
            this.invalidUser.AutoSize = true;
            this.invalidUser.ForeColor = System.Drawing.Color.Red;
            this.invalidUser.Location = new System.Drawing.Point(58, 292);
            this.invalidUser.Name = "invalidUser";
            this.invalidUser.Size = new System.Drawing.Size(98, 13);
            this.invalidUser.TabIndex = 13;
            this.invalidUser.Text = "Warning userName";
            this.invalidUser.Visible = false;
            // 
            // InvalidPass
            // 
            this.InvalidPass.AutoSize = true;
            this.InvalidPass.ForeColor = System.Drawing.Color.Red;
            this.InvalidPass.Location = new System.Drawing.Point(57, 359);
            this.InvalidPass.Name = "InvalidPass";
            this.InvalidPass.Size = new System.Drawing.Size(95, 13);
            this.InvalidPass.TabIndex = 13;
            this.InvalidPass.Text = "Warning password";
            this.InvalidPass.Visible = false;
            // 
            // bnt_Login
            // 
            this.bnt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Login.ForeColor = System.Drawing.Color.Navy;
            this.bnt_Login.Location = new System.Drawing.Point(113, 381);
            this.bnt_Login.Name = "bnt_Login";
            this.bnt_Login.Size = new System.Drawing.Size(129, 49);
            this.bnt_Login.TabIndex = 3;
            this.bnt_Login.Text = "Đăng nhập";
            this.bnt_Login.UseVisualStyleBackColor = true;
            this.bnt_Login.Click += new System.EventHandler(this.bnt_Login_Click);
            // 
            // txb_Pass
            // 
            this.txb_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_Pass.BackColor = System.Drawing.Color.Transparent;
            this.txb_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txb_Pass.Br = System.Drawing.Color.White;
            this.txb_Pass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txb_Pass.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txb_Pass.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Pass.Location = new System.Drawing.Point(50, 317);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.Size = new System.Drawing.Size(259, 33);
            this.txb_Pass.TabIndex = 2;
            this.txb_Pass.Text = "Mật khẩu";
            this.txb_Pass.TextChanged += new System.EventHandler(this.txb_Pass_TextChanged);
            this.txb_Pass.Enter += new System.EventHandler(this.txb_Pass_Enter);
            this.txb_Pass.Leave += new System.EventHandler(this.txb_Pass_Leave);
            // 
            // txb_UserName
            // 
            this.txb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_UserName.BackColor = System.Drawing.Color.Transparent;
            this.txb_UserName.Br = System.Drawing.Color.White;
            this.txb_UserName.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txb_UserName.ForeColor = System.Drawing.Color.DimGray;
            this.txb_UserName.Location = new System.Drawing.Point(50, 253);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(259, 33);
            this.txb_UserName.TabIndex = 1;
            this.txb_UserName.Text = "Tên đăng nhập";
            this.txb_UserName.Enter += new System.EventHandler(this.txb_UserName_Enter);
            this.txb_UserName.Leave += new System.EventHandler(this.txb_UserName_Leave);
            // 
            // Login_Form
            // 
            this.AcceptButton = this.bnt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(390, 571);
            this.Controls.Add(bnt_Exit);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bntForgetPass;
        private System.Windows.Forms.Panel panel1;
        private RoundTextbox txb_UserName;
        private RoundTextbox txb_Pass;
        private RoundedButton bnt_Login;
        private System.Windows.Forms.Label invalidUser;
        private System.Windows.Forms.Label InvalidPass;
        private System.Windows.Forms.Label invalidAccount;
    }
}

