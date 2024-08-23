namespace WindowsLAPSGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.edtComputerName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.edtExpiration = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpComputer = new System.Windows.Forms.GroupBox();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Expired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChange = new System.Windows.Forms.Button();
            this.grpComputer.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.grpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtComputerName
            // 
            this.edtComputerName.Location = new System.Drawing.Point(6, 19);
            this.edtComputerName.Name = "edtComputerName";
            this.edtComputerName.Size = new System.Drawing.Size(200, 20);
            this.edtComputerName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // edtPassword
            // 
            this.edtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtPassword.Location = new System.Drawing.Point(5, 41);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.ReadOnly = true;
            this.edtPassword.Size = new System.Drawing.Size(197, 20);
            this.edtPassword.TabIndex = 3;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(6, 81);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(53, 13);
            this.lblExpiration.TabIndex = 4;
            this.lblExpiration.Text = "Expiration";
            // 
            // edtExpiration
            // 
            this.edtExpiration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtExpiration.Location = new System.Drawing.Point(5, 97);
            this.edtExpiration.Name = "edtExpiration";
            this.edtExpiration.ReadOnly = true;
            this.edtExpiration.Size = new System.Drawing.Size(194, 20);
            this.edtExpiration.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(285, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpComputer
            // 
            this.grpComputer.Controls.Add(this.edtComputerName);
            this.grpComputer.Controls.Add(this.btnSearch);
            this.grpComputer.Location = new System.Drawing.Point(12, 12);
            this.grpComputer.Name = "grpComputer";
            this.grpComputer.Size = new System.Drawing.Size(366, 57);
            this.grpComputer.TabIndex = 7;
            this.grpComputer.TabStop = false;
            this.grpComputer.Text = "Computer Name";
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.btnChange);
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.edtPassword);
            this.grpPassword.Controls.Add(this.edtExpiration);
            this.grpPassword.Controls.Add(this.lblExpiration);
            this.grpPassword.Location = new System.Drawing.Point(13, 88);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(366, 135);
            this.grpPassword.TabIndex = 8;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Current Password";
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.listView1);
            this.grpHistory.Location = new System.Drawing.Point(13, 247);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(366, 158);
            this.grpHistory.TabIndex = 9;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Password History";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Expired,
            this.Password});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 132);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Expired
            // 
            this.Expired.Text = "Expired";
            this.Expired.Width = 120;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 230;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(284, 97);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpComputer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows LAPS GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpComputer.ResumeLayout(false);
            this.grpComputer.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox edtComputerName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.TextBox edtExpiration;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpComputer;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Expired;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.Button btnChange;
    }
}

