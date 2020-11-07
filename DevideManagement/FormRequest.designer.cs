namespace DevideManagement
{
    partial class FormRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequest));
            this.plMain = new System.Windows.Forms.Panel();
            this.lbRequestStatus = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.plEdge = new System.Windows.Forms.Panel();
            this.lbBack = new System.Windows.Forms.Label();
            this.lbBackIcon = new System.Windows.Forms.PictureBox();
            this.txtRequestId = new System.Windows.Forms.TextBox();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepairDescription = new System.Windows.Forms.TextBox();
            this.txtRequestDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFinishDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequestDate = new System.Windows.Forms.TextBox();
            this.plMain.SuspendLayout();
            this.plEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbBackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.PowderBlue;
            this.plMain.Controls.Add(this.lbRequestStatus);
            this.plMain.Controls.Add(this.btnFinish);
            this.plMain.Controls.Add(this.btnFix);
            this.plMain.Controls.Add(this.btnNew);
            this.plMain.Controls.Add(this.plEdge);
            this.plMain.Controls.Add(this.txtRequestId);
            this.plMain.Controls.Add(this.dgvRequest);
            this.plMain.Controls.Add(this.btnPrePage);
            this.plMain.Controls.Add(this.btnNextPage);
            this.plMain.Controls.Add(this.label2);
            this.plMain.Controls.Add(this.label3);
            this.plMain.Controls.Add(this.txtUserId);
            this.plMain.Controls.Add(this.label4);
            this.plMain.Controls.Add(this.txtRepairDescription);
            this.plMain.Controls.Add(this.txtRequestDescription);
            this.plMain.Controls.Add(this.label9);
            this.plMain.Controls.Add(this.label8);
            this.plMain.Controls.Add(this.txtFinishDate);
            this.plMain.Controls.Add(this.label5);
            this.plMain.Controls.Add(this.txtStartDate);
            this.plMain.Controls.Add(this.label6);
            this.plMain.Controls.Add(this.txtWorkerId);
            this.plMain.Controls.Add(this.label7);
            this.plMain.Controls.Add(this.txtRequestDate);
            this.plMain.Location = new System.Drawing.Point(2, 2);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1040, 700);
            this.plMain.TabIndex = 0;
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            // 
            // lbRequestStatus
            // 
            this.lbRequestStatus.AutoSize = true;
            this.lbRequestStatus.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbRequestStatus.Location = new System.Drawing.Point(686, 296);
            this.lbRequestStatus.Name = "lbRequestStatus";
            this.lbRequestStatus.Size = new System.Drawing.Size(48, 17);
            this.lbRequestStatus.TabIndex = 93;
            this.lbRequestStatus.Text = "Status";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinish.Location = new System.Drawing.Point(484, 261);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(146, 52);
            this.btnFinish.TabIndex = 92;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFix.Location = new System.Drawing.Point(346, 261);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(112, 52);
            this.btnFix.TabIndex = 91;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(144, 261);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(179, 52);
            this.btnNew.TabIndex = 90;
            this.btnNew.Text = "Make Request";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // plEdge
            // 
            this.plEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.plEdge.Controls.Add(this.lbBack);
            this.plEdge.Controls.Add(this.lbBackIcon);
            this.plEdge.Location = new System.Drawing.Point(0, 0);
            this.plEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plEdge.Name = "plEdge";
            this.plEdge.Size = new System.Drawing.Size(122, 700);
            this.plEdge.TabIndex = 67;
            this.plEdge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plEdge_MouseDown);
            this.plEdge.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plEdge_MouseMove);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbBack.Location = new System.Drawing.Point(52, 40);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(47, 20);
            this.lbBack.TabIndex = 1;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // lbBackIcon
            // 
            this.lbBackIcon.Image = ((System.Drawing.Image)(resources.GetObject("lbBackIcon.Image")));
            this.lbBackIcon.Location = new System.Drawing.Point(16, 33);
            this.lbBackIcon.Name = "lbBackIcon";
            this.lbBackIcon.Size = new System.Drawing.Size(34, 33);
            this.lbBackIcon.TabIndex = 0;
            this.lbBackIcon.TabStop = false;
            this.lbBackIcon.Click += new System.EventHandler(this.lbBackIcon_Click);
            // 
            // txtRequestId
            // 
            this.txtRequestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestId.Location = new System.Drawing.Point(317, 343);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.ReadOnly = true;
            this.txtRequestId.Size = new System.Drawing.Size(216, 27);
            this.txtRequestId.TabIndex = 74;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(196, 34);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersWidth = 51;
            this.dgvRequest.RowTemplate.Height = 24;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(782, 185);
            this.dgvRequest.TabIndex = 68;
            this.dgvRequest.SelectionChanged += new System.EventHandler(this.dgvRequest_SelectionChanged);
            // 
            // btnPrePage
            // 
            this.btnPrePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnPrePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrePage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrePage.Location = new System.Drawing.Point(818, 252);
            this.btnPrePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(66, 30);
            this.btnPrePage.TabIndex = 71;
            this.btnPrePage.Text = "<<";
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextPage.Location = new System.Drawing.Point(898, 252);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(66, 30);
            this.btnNextPage.TabIndex = 72;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Request ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(317, 399);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(216, 27);
            this.txtUserId.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Request Date";
            // 
            // txtRepairDescription
            // 
            this.txtRepairDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairDescription.Location = new System.Drawing.Point(650, 549);
            this.txtRepairDescription.Multiline = true;
            this.txtRepairDescription.Name = "txtRepairDescription";
            this.txtRepairDescription.ReadOnly = true;
            this.txtRepairDescription.Size = new System.Drawing.Size(328, 117);
            this.txtRepairDescription.TabIndex = 88;
            // 
            // txtRequestDescription
            // 
            this.txtRequestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDescription.Location = new System.Drawing.Point(190, 549);
            this.txtRequestDescription.Multiline = true;
            this.txtRequestDescription.Name = "txtRequestDescription";
            this.txtRequestDescription.ReadOnly = true;
            this.txtRequestDescription.Size = new System.Drawing.Size(343, 117);
            this.txtRequestDescription.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(646, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 86;
            this.label9.Text = "Repair Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Request Description";
            // 
            // txtFinishDate
            // 
            this.txtFinishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishDate.Location = new System.Drawing.Point(762, 448);
            this.txtFinishDate.Name = "txtFinishDate";
            this.txtFinishDate.ReadOnly = true;
            this.txtFinishDate.Size = new System.Drawing.Size(216, 27);
            this.txtFinishDate.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(646, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Finish Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(762, 395);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(216, 27);
            this.txtStartDate.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(646, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Start Date";
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkerId.Location = new System.Drawing.Point(762, 339);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.ReadOnly = true;
            this.txtWorkerId.Size = new System.Drawing.Size(216, 27);
            this.txtWorkerId.TabIndex = 80;
            this.txtWorkerId.TextChanged += new System.EventHandler(this.txtWorkerId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(646, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Worker ID";
            // 
            // txtRequestDate
            // 
            this.txtRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDate.Location = new System.Drawing.Point(317, 452);
            this.txtRequestDate.Name = "txtRequestDate";
            this.txtRequestDate.ReadOnly = true;
            this.txtRequestDate.Size = new System.Drawing.Size(216, 27);
            this.txtRequestDate.TabIndex = 78;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1044, 704);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRequest";
            this.Text = "Request History";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            this.plEdge.ResumeLayout(false);
            this.plEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbBackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plEdge;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.PictureBox lbBackIcon;
        private System.Windows.Forms.TextBox txtRequestId;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepairDescription;
        private System.Windows.Forms.TextBox txtRequestDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFinishDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequestDate;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbRequestStatus;
    }
}