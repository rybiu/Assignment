namespace Demo
{
    partial class FrmDevice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewDevice = new System.Windows.Forms.Button();
            this.btnHistoryRepair = new System.Windows.Forms.Button();
            this.btnNextPre = new System.Windows.Forms.Button();
            this.btnPreDevide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWarrantyDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoughtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeviceDescription = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeviceAdd = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnDeviceUpdate = new System.Windows.Forms.Button();
            this.btnDeviceDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 115);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewDevice
            // 
            this.btnNewDevice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewDevice.Location = new System.Drawing.Point(20, 134);
            this.btnNewDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewDevice.Name = "btnNewDevice";
            this.btnNewDevice.Size = new System.Drawing.Size(100, 38);
            this.btnNewDevice.TabIndex = 1;
            this.btnNewDevice.Text = "NEW";
            this.btnNewDevice.UseVisualStyleBackColor = false;
            this.btnNewDevice.Click += new System.EventHandler(this.btnNewDevice_Click);
            // 
            // btnHistoryRepair
            // 
            this.btnHistoryRepair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistoryRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryRepair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistoryRepair.Location = new System.Drawing.Point(137, 134);
            this.btnHistoryRepair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistoryRepair.Name = "btnHistoryRepair";
            this.btnHistoryRepair.Size = new System.Drawing.Size(157, 38);
            this.btnHistoryRepair.TabIndex = 2;
            this.btnHistoryRepair.Text = "REPAIR HISTORY";
            this.btnHistoryRepair.UseVisualStyleBackColor = false;
            this.btnHistoryRepair.Click += new System.EventHandler(this.btnHistoryRepair_Click);
            // 
            // btnNextPre
            // 
            this.btnNextPre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextPre.Location = new System.Drawing.Point(511, 134);
            this.btnNextPre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextPre.Name = "btnNextPre";
            this.btnNextPre.Size = new System.Drawing.Size(60, 22);
            this.btnNextPre.TabIndex = 10;
            this.btnNextPre.Text = ">>";
            this.btnNextPre.UseVisualStyleBackColor = false;
            // 
            // btnPreDevide
            // 
            this.btnPreDevide.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPreDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreDevide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreDevide.Location = new System.Drawing.Point(442, 134);
            this.btnPreDevide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreDevide.Name = "btnPreDevide";
            this.btnPreDevide.Size = new System.Drawing.Size(60, 22);
            this.btnPreDevide.TabIndex = 9;
            this.btnPreDevide.Text = "<<";
            this.btnPreDevide.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWarrantyDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBoughtDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDeviceDescription);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.txtDeviceType);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.txtDeviceID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeviceAdd);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Controls.Add(this.btnDeviceUpdate);
            this.panel1.Controls.Add(this.btnDeviceDelete);
            this.panel1.Location = new System.Drawing.Point(2, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 238);
            this.panel1.TabIndex = 11;
            // 
            // txtWarrantyDate
            // 
            this.txtWarrantyDate.Location = new System.Drawing.Point(318, 200);
            this.txtWarrantyDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWarrantyDate.Name = "txtWarrantyDate";
            this.txtWarrantyDate.Size = new System.Drawing.Size(97, 27);
            this.txtWarrantyDate.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Warranty Date";
            // 
            // txtBoughtDate
            // 
            this.txtBoughtDate.Location = new System.Drawing.Point(107, 200);
            this.txtBoughtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoughtDate.Name = "txtBoughtDate";
            this.txtBoughtDate.Size = new System.Drawing.Size(89, 27);
            this.txtBoughtDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bought Date";
            // 
            // txtDeviceDescription
            // 
            this.txtDeviceDescription.Location = new System.Drawing.Point(107, 102);
            this.txtDeviceDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeviceDescription.Multiline = true;
            this.txtDeviceDescription.Name = "txtDeviceDescription";
            this.txtDeviceDescription.Size = new System.Drawing.Size(311, 89);
            this.txtDeviceDescription.TabIndex = 14;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(280, 70);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(53, 20);
            this.Status.TabIndex = 13;
            this.Status.Text = "label5";
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.Location = new System.Drawing.Point(107, 67);
            this.txtDeviceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.Size = new System.Drawing.Size(171, 27);
            this.txtDeviceType.TabIndex = 12;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(107, 40);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(311, 27);
            this.txtDeviceName.TabIndex = 11;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(107, 7);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(311, 27);
            this.txtDeviceID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Device ID";
            // 
            // btnDeviceAdd
            // 
            this.btnDeviceAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeviceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeviceAdd.Location = new System.Drawing.Point(431, 150);
            this.btnDeviceAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeviceAdd.Name = "btnDeviceAdd";
            this.btnDeviceAdd.Size = new System.Drawing.Size(148, 38);
            this.btnDeviceAdd.TabIndex = 5;
            this.btnDeviceAdd.Text = "ADD";
            this.btnDeviceAdd.UseVisualStyleBackColor = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseImage.Location = new System.Drawing.Point(431, 102);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(148, 38);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "CHOOSE IMAGE";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            // 
            // btnDeviceUpdate
            // 
            this.btnDeviceUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeviceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeviceUpdate.Location = new System.Drawing.Point(431, 56);
            this.btnDeviceUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeviceUpdate.Name = "btnDeviceUpdate";
            this.btnDeviceUpdate.Size = new System.Drawing.Size(148, 38);
            this.btnDeviceUpdate.TabIndex = 3;
            this.btnDeviceUpdate.Text = "UPDATE";
            this.btnDeviceUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDeviceDelete
            // 
            this.btnDeviceDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeviceDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeviceDelete.Location = new System.Drawing.Point(431, 10);
            this.btnDeviceDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeviceDelete.Name = "btnDeviceDelete";
            this.btnDeviceDelete.Size = new System.Drawing.Size(148, 38);
            this.btnDeviceDelete.TabIndex = 2;
            this.btnDeviceDelete.Text = "DELETE";
            this.btnDeviceDelete.UseVisualStyleBackColor = false;
            // 
            // FrmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(600, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNextPre);
            this.Controls.Add(this.btnPreDevide);
            this.Controls.Add(this.btnHistoryRepair);
            this.Controls.Add(this.btnNewDevice);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDevide";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewDevice;
        private System.Windows.Forms.Button btnHistoryRepair;
        private System.Windows.Forms.Button btnNextPre;
        private System.Windows.Forms.Button btnPreDevide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWarrantyDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoughtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeviceDescription;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeviceAdd;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnDeviceUpdate;
        private System.Windows.Forms.Button btnDeviceDelete;
    }
}