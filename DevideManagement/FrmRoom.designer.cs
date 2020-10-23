namespace DeviceManagement
{
    partial class FrmRoom
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
            this.btnNextRoom = new System.Windows.Forms.Button();
            this.btnPreRoom = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFeature = new System.Windows.Forms.ComboBox();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNextRoom
            // 
            this.btnNextRoom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextRoom.Location = new System.Drawing.Point(519, 144);
            this.btnNextRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextRoom.Name = "btnNextRoom";
            this.btnNextRoom.Size = new System.Drawing.Size(60, 22);
            this.btnNextRoom.TabIndex = 13;
            this.btnNextRoom.Text = ">>";
            this.btnNextRoom.UseVisualStyleBackColor = false;
            // 
            // btnPreRoom
            // 
            this.btnPreRoom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPreRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreRoom.Location = new System.Drawing.Point(452, 144);
            this.btnPreRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreRoom.Name = "btnPreRoom";
            this.btnPreRoom.Size = new System.Drawing.Size(60, 22);
            this.btnPreRoom.TabIndex = 12;
            this.btnPreRoom.Text = "<<";
            this.btnPreRoom.UseVisualStyleBackColor = false;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRoom.Location = new System.Drawing.Point(23, 144);
            this.btnNewRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(128, 31);
            this.btnNewRoom.TabIndex = 11;
            this.btnNewRoom.Text = "NEW";
            this.btnNewRoom.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboFeature);
            this.panel1.Controls.Add(this.btnRoomSave);
            this.panel1.Controls.Add(this.btnRoomUpdate);
            this.panel1.Controls.Add(this.btnDeleteRoom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 236);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Feature";
            // 
            // cboFeature
            // 
            this.cboFeature.FormattingEnabled = true;
            this.cboFeature.Items.AddRange(new object[] {
            "User",
            "Device"});
            this.cboFeature.Location = new System.Drawing.Point(478, 13);
            this.cboFeature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFeature.Name = "cboFeature";
            this.cboFeature.Size = new System.Drawing.Size(101, 28);
            this.cboFeature.TabIndex = 22;
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRoomSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoomSave.Location = new System.Drawing.Point(415, 177);
            this.btnRoomSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(147, 34);
            this.btnRoomSave.TabIndex = 21;
            this.btnRoomSave.Text = "SAVE CHANGE";
            this.btnRoomSave.UseVisualStyleBackColor = false;
            this.btnRoomSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRoomUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoomUpdate.Location = new System.Drawing.Point(415, 119);
            this.btnRoomUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(147, 34);
            this.btnRoomUpdate.TabIndex = 20;
            this.btnRoomUpdate.Text = "UPDATE";
            this.btnRoomUpdate.UseVisualStyleBackColor = false;
            this.btnRoomUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteRoom.Location = new System.Drawing.Point(415, 61);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(147, 34);
            this.btnDeleteRoom.TabIndex = 19;
            this.btnDeleteRoom.Text = "DELETE";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.btnMoveRight);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btnMoveLeft);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 234);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "INSIDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "OUTSIDE";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(238, 33);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(152, 198);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoveRight.Location = new System.Drawing.Point(172, 111);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(60, 22);
            this.btnMoveRight.TabIndex = 16;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = false;
            this.btnMoveRight.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 33);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(152, 198);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoveLeft.Location = new System.Drawing.Point(172, 82);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(60, 22);
            this.btnMoveLeft.TabIndex = 15;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = false;
            this.btnMoveLeft.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(593, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNextRoom);
            this.Controls.Add(this.btnPreRoom);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRoom";
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNextRoom;
        private System.Windows.Forms.Button btnPreRoom;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoomSave;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFeature;
    }
}