namespace DeviceManagement
{
    partial class FormHome
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add device");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update device");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete device");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("By name");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("By fixed times");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("By status");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Search device", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Manage device", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Add user");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Update user");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Delete user");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Search user");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Manage user", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Add room");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Update room");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Delete room");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Add user/ device into room");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Drop user/device from room");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Manage room", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Make request");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Fix device");
            this.label1 = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Device Management!";
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.PowderBlue;
            this.plMain.Controls.Add(this.label4);
            this.plMain.Controls.Add(this.label2);
            this.plMain.Controls.Add(this.treeView1);
            this.plMain.Controls.Add(this.label1);
            this.plMain.Location = new System.Drawing.Point(0, 50);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(860, 650);
            this.plMain.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Our members:  Hong Ngoc, The Nhan, Thanh Cong, Quoc Bao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Our functions";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(64, 198);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Add device";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Update device";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Delete device";
            treeNode4.Name = "Node5";
            treeNode4.Text = "By name";
            treeNode5.Name = "Node6";
            treeNode5.Text = "By fixed times";
            treeNode6.Name = "Node7";
            treeNode6.Text = "By status";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Search device";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Manage device";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Add user";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Update user";
            treeNode11.Name = "Node7";
            treeNode11.Text = "Delete user";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Search user";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Manage user";
            treeNode14.Name = "Node9";
            treeNode14.Text = "Add room";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Update room";
            treeNode16.Name = "Node11";
            treeNode16.Text = "Delete room";
            treeNode17.Name = "Node9";
            treeNode17.Text = "Add user/ device into room";
            treeNode18.Name = "Node10";
            treeNode18.Text = "Drop user/device from room";
            treeNode19.Name = "Node8";
            treeNode19.Text = "Manage room";
            treeNode20.Name = "Node12";
            treeNode20.Text = "Make request";
            treeNode21.Name = "Node14";
            treeNode21.Text = "Fix device";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode19,
            treeNode20,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(670, 232);
            this.treeView1.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home Layout";
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}