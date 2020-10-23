namespace DeviceManagement
{
    partial class MenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItem));
            this.lbIndicator = new System.Windows.Forms.Label();
            this.lbMenuItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIndicator
            // 
            resources.ApplyResources(this.lbIndicator, "lbIndicator");
            this.lbIndicator.BackColor = System.Drawing.Color.White;
            this.lbIndicator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIndicator.Name = "lbIndicator";
            // 
            // lbMenuItem
            // 
            resources.ApplyResources(this.lbMenuItem, "lbMenuItem");
            this.lbMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.lbMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMenuItem.Name = "lbMenuItem";
            // 
            // MenuItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lbIndicator);
            this.Controls.Add(this.lbMenuItem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIndicator;
        private System.Windows.Forms.Label lbMenuItem;
    }
}
