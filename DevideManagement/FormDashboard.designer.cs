namespace DeviceManagement
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.plEdge = new System.Windows.Forms.Panel();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.plContent = new System.Windows.Forms.Panel();
            this.plEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plEdge
            // 
            this.plEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.plEdge.Controls.Add(this.lblStatistic);
            this.plEdge.Controls.Add(this.lblHome);
            this.plEdge.Controls.Add(this.lblWorker);
            this.plEdge.Controls.Add(this.lblRoom);
            this.plEdge.Controls.Add(this.lblDevice);
            this.plEdge.Controls.Add(this.lblUser);
            this.plEdge.Location = new System.Drawing.Point(0, 0);
            this.plEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plEdge.Name = "plEdge";
            this.plEdge.Size = new System.Drawing.Size(150, 700);
            this.plEdge.TabIndex = 0;
            this.plEdge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEdge_MouseDown);
            this.plEdge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEdge_MouseMove);
            // 
            // lblStatistic
            // 
            this.lblStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatistic.Location = new System.Drawing.Point(0, 350);
            this.lblStatistic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(150, 50);
            this.lblStatistic.TabIndex = 5;
            this.lblStatistic.Text = "Statistic";
            this.lblStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatistic.Click += new System.EventHandler(this.lblStatistic_Click);
            // 
            // lblHome
            // 
            this.lblHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHome.Location = new System.Drawing.Point(0, 100);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHome.Size = new System.Drawing.Size(150, 50);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblWorker
            // 
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorker.Location = new System.Drawing.Point(4, 250);
            this.lblWorker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(150, 50);
            this.lblWorker.TabIndex = 2;
            this.lblWorker.Text = "Worker";
            this.lblWorker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWorker.Click += new System.EventHandler(this.lblWorker_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoom.Location = new System.Drawing.Point(0, 300);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(150, 50);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Room";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // lblDevice
            // 
            this.lblDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDevice.Location = new System.Drawing.Point(0, 150);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(150, 50);
            this.lblDevice.TabIndex = 3;
            this.lblDevice.Text = "Device";
            this.lblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDevice.Click += new System.EventHandler(this.lblDevice_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(0, 200);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(150, 50);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogOut.Location = new System.Drawing.Point(242, 392);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(65, 20);
            this.lblLogOut.TabIndex = 4;
            this.lblLogOut.Text = "Log out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(212, 388);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(187, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(155, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "password";
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(232, 217);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(150, 35);
            this.lbRole.TabIndex = 10;
            this.lbRole.Text = "ADMIN";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(234, 259);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(150, 35);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "ADMIN";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(234, 310);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(150, 35);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "******";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plContent.Location = new System.Drawing.Point(400, 0);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(800, 700);
            this.plContent.TabIndex = 13;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.plContent);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.plEdge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDashboard_MouseMove);
            this.plEdge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plEdge;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel plContent;
    }
}

