namespace Demo
{
    partial class FrmWorker
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
            this.detailPanel = new System.Windows.Forms.Panel();
            this.btnWorkerAdd = new System.Windows.Forms.Button();
            this.btnWorkerUpdate = new System.Windows.Forms.Button();
            this.btnWorkerDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtWorkerPass = new System.Windows.Forms.TextBox();
            this.txtWorkerID = new System.Windows.Forms.TextBox();
            this.txtWorkerInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextWorker = new System.Windows.Forms.Button();
            this.btnPreWorker = new System.Windows.Forms.Button();
            this.btnNewWorker = new System.Windows.Forms.Button();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.detailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.btnWorkerAdd);
            this.detailPanel.Controls.Add(this.btnWorkerUpdate);
            this.detailPanel.Controls.Add(this.btnWorkerDelete);
            this.detailPanel.Controls.Add(this.panel1);
            this.detailPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPanel.Location = new System.Drawing.Point(25, 254);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(694, 258);
            this.detailPanel.TabIndex = 9;
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWorkerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkerAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWorkerAdd.Location = new System.Drawing.Point(423, 188);
            this.btnWorkerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Size = new System.Drawing.Size(170, 43);
            this.btnWorkerAdd.TabIndex = 4;
            this.btnWorkerAdd.Text = "Add";
            this.btnWorkerAdd.UseVisualStyleBackColor = false;
            // 
            // btnWorkerUpdate
            // 
            this.btnWorkerUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWorkerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkerUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWorkerUpdate.Location = new System.Drawing.Point(423, 106);
            this.btnWorkerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkerUpdate.Name = "btnWorkerUpdate";
            this.btnWorkerUpdate.Size = new System.Drawing.Size(170, 43);
            this.btnWorkerUpdate.TabIndex = 3;
            this.btnWorkerUpdate.Text = "Update";
            this.btnWorkerUpdate.UseVisualStyleBackColor = false;
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWorkerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkerDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWorkerDelete.Location = new System.Drawing.Point(423, 31);
            this.btnWorkerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Size = new System.Drawing.Size(170, 43);
            this.btnWorkerDelete.TabIndex = 2;
            this.btnWorkerDelete.Text = "Delete";
            this.btnWorkerDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtWorkerPass);
            this.panel1.Controls.Add(this.txtWorkerID);
            this.panel1.Controls.Add(this.txtWorkerInfo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 258);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(118, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = " Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtWorkerPass
            // 
            this.txtWorkerPass.Location = new System.Drawing.Point(118, 152);
            this.txtWorkerPass.Name = "txtWorkerPass";
            this.txtWorkerPass.Size = new System.Drawing.Size(205, 30);
            this.txtWorkerPass.TabIndex = 7;
            // 
            // txtWorkerID
            // 
            this.txtWorkerID.Location = new System.Drawing.Point(118, 97);
            this.txtWorkerID.Name = "txtWorkerID";
            this.txtWorkerID.Size = new System.Drawing.Size(205, 30);
            this.txtWorkerID.TabIndex = 6;
            // 
            // txtWorkerInfo
            // 
            this.txtWorkerInfo.Location = new System.Drawing.Point(118, 44);
            this.txtWorkerInfo.Name = "txtWorkerInfo";
            this.txtWorkerInfo.Size = new System.Drawing.Size(205, 30);
            this.txtWorkerInfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Worker ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // btnNextWorker
            // 
            this.btnNextWorker.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextWorker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextWorker.Location = new System.Drawing.Point(587, 196);
            this.btnNextWorker.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextWorker.Name = "btnNextWorker";
            this.btnNextWorker.Size = new System.Drawing.Size(72, 28);
            this.btnNextWorker.TabIndex = 8;
            this.btnNextWorker.Text = ">>";
            this.btnNextWorker.UseVisualStyleBackColor = false;
            // 
            // btnPreWorker
            // 
            this.btnPreWorker.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPreWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreWorker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreWorker.Location = new System.Drawing.Point(507, 196);
            this.btnPreWorker.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreWorker.Name = "btnPreWorker";
            this.btnPreWorker.Size = new System.Drawing.Size(72, 28);
            this.btnPreWorker.TabIndex = 7;
            this.btnPreWorker.Text = "<<";
            this.btnPreWorker.UseVisualStyleBackColor = false;
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWorker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewWorker.Location = new System.Drawing.Point(25, 195);
            this.btnNewWorker.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(184, 52);
            this.btnNewWorker.TabIndex = 6;
            this.btnNewWorker.Text = "New";
            this.btnNewWorker.UseVisualStyleBackColor = false;
            // 
            // dgvWorker
            // 
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Location = new System.Drawing.Point(15, 12);
            this.dgvWorker.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.RowHeadersWidth = 51;
            this.dgvWorker.Size = new System.Drawing.Size(704, 175);
            this.dgvWorker.TabIndex = 5;
            // 
            // FrmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(733, 534);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.btnNextWorker);
            this.Controls.Add(this.btnPreWorker);
            this.Controls.Add(this.btnNewWorker);
            this.Controls.Add(this.dgvWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWorker";
            this.Text = "FrmWorker";
            this.detailPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Button btnWorkerAdd;
        private System.Windows.Forms.Button btnWorkerUpdate;
        private System.Windows.Forms.Button btnWorkerDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtWorkerPass;
        private System.Windows.Forms.TextBox txtWorkerID;
        private System.Windows.Forms.TextBox txtWorkerInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNextWorker;
        private System.Windows.Forms.Button btnPreWorker;
        private System.Windows.Forms.Button btnNewWorker;
        private System.Windows.Forms.DataGridView dgvWorker;
    }
}