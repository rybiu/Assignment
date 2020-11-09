namespace DeviceManagement
{
    partial class FormRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.plMain = new System.Windows.Forms.Panel();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.lbRoomId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFeature = new System.Windows.Forms.ComboBox();
            this.lbRightTableTitle = new System.Windows.Forms.Label();
            this.dgvRightTable = new System.Windows.Forms.DataGridView();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.lbLeftTableTitle = new System.Windows.Forms.Label();
            this.dgvLeftTable = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRightTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.PowderBlue;
            this.plMain.Controls.Add(this.lbRoomName);
            this.plMain.Controls.Add(this.lbRoomId);
            this.plMain.Controls.Add(this.label3);
            this.plMain.Controls.Add(this.cboFeature);
            this.plMain.Controls.Add(this.lbRightTableTitle);
            this.plMain.Controls.Add(this.dgvRightTable);
            this.plMain.Controls.Add(this.btnMove);
            this.plMain.Controls.Add(this.btnDrop);
            this.plMain.Controls.Add(this.lbLeftTableTitle);
            this.plMain.Controls.Add(this.dgvLeftTable);
            this.plMain.Controls.Add(this.btnSave);
            this.plMain.Controls.Add(this.btnUpdate);
            this.plMain.Controls.Add(this.btnNextPage);
            this.plMain.Controls.Add(this.btnDelete);
            this.plMain.Controls.Add(this.btnPrePage);
            this.plMain.Controls.Add(this.btnNew);
            this.plMain.Controls.Add(this.dgvRoom);
            this.plMain.Location = new System.Drawing.Point(0, 50);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(860, 750);
            this.plMain.TabIndex = 0;
            // 
            // lbRoomName
            // 
            this.lbRoomName.AutoSize = true;
            this.lbRoomName.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbRoomName.Location = new System.Drawing.Point(369, 235);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(46, 17);
            this.lbRoomName.TabIndex = 60;
            this.lbRoomName.Text = "label2";
            // 
            // lbRoomId
            // 
            this.lbRoomId.AutoSize = true;
            this.lbRoomId.ForeColor = System.Drawing.Color.PowderBlue;
            this.lbRoomId.Location = new System.Drawing.Point(274, 235);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(16, 17);
            this.lbRoomId.TabIndex = 59;
            this.lbRoomId.Text = "0";
            this.lbRoomId.TextChanged += new System.EventHandler(this.lbRoomId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Feature";
            // 
            // cboFeature
            // 
            this.cboFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFeature.FormattingEnabled = true;
            this.cboFeature.Items.AddRange(new object[] {
            "",
            "ACCOUNT",
            "DEVICE"});
            this.cboFeature.Location = new System.Drawing.Point(675, 311);
            this.cboFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFeature.Name = "cboFeature";
            this.cboFeature.Size = new System.Drawing.Size(113, 28);
            this.cboFeature.TabIndex = 57;
            this.cboFeature.SelectedIndexChanged += new System.EventHandler(this.cboFeature_SelectedIndexChanged);
            // 
            // lbRightTableTitle
            // 
            this.lbRightTableTitle.AutoSize = true;
            this.lbRightTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightTableTitle.Location = new System.Drawing.Point(338, 296);
            this.lbRightTableTitle.Name = "lbRightTableTitle";
            this.lbRightTableTitle.Size = new System.Drawing.Size(64, 20);
            this.lbRightTableTitle.TabIndex = 56;
            this.lbRightTableTitle.Text = "INSIDE";
            // 
            // dgvRightTable
            // 
            this.dgvRightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRightTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRightTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRightTable.Location = new System.Drawing.Point(342, 327);
            this.dgvRightTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRightTable.MultiSelect = false;
            this.dgvRightTable.Name = "dgvRightTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRightTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRightTable.RowHeadersWidth = 51;
            this.dgvRightTable.RowTemplate.Height = 24;
            this.dgvRightTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRightTable.Size = new System.Drawing.Size(230, 300);
            this.dgvRightTable.TabIndex = 55;
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMove.Location = new System.Drawing.Point(263, 499);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(72, 30);
            this.btnMove.TabIndex = 54;
            this.btnMove.Text = ">>";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDrop.Location = new System.Drawing.Point(263, 444);
            this.btnDrop.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(72, 30);
            this.btnDrop.TabIndex = 53;
            this.btnDrop.Text = "<<";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // lbLeftTableTitle
            // 
            this.lbLeftTableTitle.AutoSize = true;
            this.lbLeftTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftTableTitle.Location = new System.Drawing.Point(22, 296);
            this.lbLeftTableTitle.Name = "lbLeftTableTitle";
            this.lbLeftTableTitle.Size = new System.Drawing.Size(83, 20);
            this.lbLeftTableTitle.TabIndex = 52;
            this.lbLeftTableTitle.Text = "OUTSIDE";
            // 
            // dgvLeftTable
            // 
            this.dgvLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeftTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeftTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLeftTable.Location = new System.Drawing.Point(26, 327);
            this.dgvLeftTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLeftTable.MultiSelect = false;
            this.dgvLeftTable.Name = "dgvLeftTable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeftTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLeftTable.RowHeadersWidth = 51;
            this.dgvLeftTable.RowTemplate.Height = 24;
            this.dgvLeftTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeftTable.Size = new System.Drawing.Size(230, 300);
            this.dgvLeftTable.TabIndex = 51;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(618, 544);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 43);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(618, 462);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 43);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextPage.Location = new System.Drawing.Point(605, 227);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(72, 30);
            this.btnNextPage.TabIndex = 48;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(618, 378);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 47);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnPrePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrePage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrePage.Location = new System.Drawing.Point(525, 227);
            this.btnPrePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(72, 30);
            this.btnPrePage.TabIndex = 46;
            this.btnPrePage.Text = "<<";
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(46, 227);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(146, 52);
            this.btnNew.TabIndex = 45;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(93, 32);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoom.MultiSelect = false;
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(608, 185);
            this.dgvRoom.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(750, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 25);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "   ";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(530, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 27);
            this.txtSearch.TabIndex = 18;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room Layout";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRightTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeftTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbRoomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFeature;
        private System.Windows.Forms.Label lbRightTableTitle;
        private System.Windows.Forms.DataGridView dgvRightTable;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Label lbLeftTableTitle;
        private System.Windows.Forms.DataGridView dgvLeftTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}