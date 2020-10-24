namespace DeviceManagement
{
    partial class FrmStatistic
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
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.plFixedTime = new System.Windows.Forms.Panel();
            this.btnFilterFixedTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTime = new System.Windows.Forms.TextBox();
            this.txtMinTime = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.rdByStatus = new System.Windows.Forms.RadioButton();
            this.rdByFixTime = new System.Windows.Forms.RadioButton();
            this.plStatus = new System.Windows.Forms.Panel();
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.plFixedTime.SuspendLayout();
            this.plStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevice
            // 
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Location = new System.Drawing.Point(60, 29);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(661, 255);
            this.dgvDevice.TabIndex = 0;
            // 
            // plFixedTime
            // 
            this.plFixedTime.Controls.Add(this.btnFilterFixedTime);
            this.plFixedTime.Controls.Add(this.label1);
            this.plFixedTime.Controls.Add(this.txtMaxTime);
            this.plFixedTime.Controls.Add(this.txtMinTime);
            this.plFixedTime.Controls.Add(this.lbTo);
            this.plFixedTime.Controls.Add(this.lbFrom);
            this.plFixedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plFixedTime.Location = new System.Drawing.Point(287, 336);
            this.plFixedTime.Name = "plFixedTime";
            this.plFixedTime.Size = new System.Drawing.Size(434, 224);
            this.plFixedTime.TabIndex = 5;
            // 
            // btnFilterFixedTime
            // 
            this.btnFilterFixedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnFilterFixedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterFixedTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterFixedTime.Location = new System.Drawing.Point(301, 143);
            this.btnFilterFixedTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterFixedTime.Name = "btnFilterFixedTime";
            this.btnFilterFixedTime.Size = new System.Drawing.Size(109, 47);
            this.btnFilterFixedTime.TabIndex = 8;
            this.btnFilterFixedTime.Text = "Go";
            this.btnFilterFixedTime.UseVisualStyleBackColor = false;
            this.btnFilterFixedTime.Click += new System.EventHandler(this.btnFilterFixedTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parameter";
            // 
            // txtMaxTime
            // 
            this.txtMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTime.Location = new System.Drawing.Point(151, 100);
            this.txtMaxTime.Name = "txtMaxTime";
            this.txtMaxTime.Size = new System.Drawing.Size(259, 27);
            this.txtMaxTime.TabIndex = 4;
            // 
            // txtMinTime
            // 
            this.txtMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTime.Location = new System.Drawing.Point(151, 56);
            this.txtMinTime.Name = "txtMinTime";
            this.txtMinTime.Size = new System.Drawing.Size(259, 27);
            this.txtMinTime.TabIndex = 3;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(30, 103);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(82, 20);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "Max Time";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(30, 59);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(78, 20);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "Min Time";
            // 
            // rdByStatus
            // 
            this.rdByStatus.AutoSize = true;
            this.rdByStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdByStatus.Location = new System.Drawing.Point(60, 396);
            this.rdByStatus.Name = "rdByStatus";
            this.rdByStatus.Size = new System.Drawing.Size(103, 24);
            this.rdByStatus.TabIndex = 4;
            this.rdByStatus.Text = "By Status";
            this.rdByStatus.UseVisualStyleBackColor = true;
            this.rdByStatus.CheckedChanged += new System.EventHandler(this.rdByStatus_CheckedChanged);
            // 
            // rdByFixTime
            // 
            this.rdByFixTime.AutoSize = true;
            this.rdByFixTime.Checked = true;
            this.rdByFixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdByFixTime.Location = new System.Drawing.Point(60, 347);
            this.rdByFixTime.Name = "rdByFixTime";
            this.rdByFixTime.Size = new System.Drawing.Size(137, 24);
            this.rdByFixTime.TabIndex = 3;
            this.rdByFixTime.TabStop = true;
            this.rdByFixTime.Text = "By Fixed Time";
            this.rdByFixTime.UseVisualStyleBackColor = true;
            this.rdByFixTime.CheckedChanged += new System.EventHandler(this.rdByFixTime_CheckedChanged);
            // 
            // plStatus
            // 
            this.plStatus.Controls.Add(this.btnFilterStatus);
            this.plStatus.Controls.Add(this.label2);
            this.plStatus.Controls.Add(this.cbStatus);
            this.plStatus.Controls.Add(this.txtToDate);
            this.plStatus.Controls.Add(this.txtFromDate);
            this.plStatus.Controls.Add(this.label3);
            this.plStatus.Controls.Add(this.label4);
            this.plStatus.Controls.Add(this.label5);
            this.plStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plStatus.Location = new System.Drawing.Point(287, 336);
            this.plStatus.Name = "plStatus";
            this.plStatus.Size = new System.Drawing.Size(434, 224);
            this.plStatus.TabIndex = 9;
            this.plStatus.Visible = false;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterStatus.Location = new System.Drawing.Point(301, 143);
            this.btnFilterStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(109, 47);
            this.btnFilterStatus.TabIndex = 8;
            this.btnFilterStatus.Text = "Go";
            this.btnFilterStatus.UseVisualStyleBackColor = false;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parameter";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "BROKEN"});
            this.cbStatus.Location = new System.Drawing.Point(151, 155);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbStatus.Size = new System.Drawing.Size(121, 28);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.Text = "ACTIVE";
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDate.Location = new System.Drawing.Point(151, 100);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(259, 27);
            this.txtToDate.TabIndex = 4;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromDate.Location = new System.Drawing.Point(151, 56);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(259, 27);
            this.txtFromDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "To Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "From Date";
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(755, 600);
            this.Controls.Add(this.plStatus);
            this.Controls.Add(this.plFixedTime);
            this.Controls.Add(this.rdByStatus);
            this.Controls.Add(this.rdByFixTime);
            this.Controls.Add(this.dgvDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.plFixedTime.ResumeLayout(false);
            this.plFixedTime.PerformLayout();
            this.plStatus.ResumeLayout(false);
            this.plStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Panel plFixedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxTime;
        private System.Windows.Forms.TextBox txtMinTime;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.RadioButton rdByStatus;
        private System.Windows.Forms.RadioButton rdByFixTime;
        private System.Windows.Forms.Button btnFilterFixedTime;
        private System.Windows.Forms.Panel plStatus;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}