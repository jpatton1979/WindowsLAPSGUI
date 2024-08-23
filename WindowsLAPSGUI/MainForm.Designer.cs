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
            this.lblNewExpiration = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSet = new System.Windows.Forms.Button();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.lstPwdHistory = new System.Windows.Forms.ListView();
            this.Expired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.grpComputer.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.grpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtComputerName
            // 
            this.edtComputerName.Location = new System.Drawing.Point(6, 19);
            this.edtComputerName.Name = "edtComputerName";
            this.edtComputerName.Size = new System.Drawing.Size(197, 20);
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
            this.edtExpiration.Enabled = false;
            this.edtExpiration.Location = new System.Drawing.Point(5, 97);
            this.edtExpiration.Name = "edtExpiration";
            this.edtExpiration.ReadOnly = true;
            this.edtExpiration.Size = new System.Drawing.Size(194, 20);
            this.edtExpiration.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 16);
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
            this.grpComputer.Size = new System.Drawing.Size(320, 57);
            this.grpComputer.TabIndex = 7;
            this.grpComputer.TabStop = false;
            this.grpComputer.Text = "Computer Name";
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.lblNewExpiration);
            this.grpPassword.Controls.Add(this.dateTimePicker1);
            this.grpPassword.Controls.Add(this.btnSet);
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.edtPassword);
            this.grpPassword.Controls.Add(this.edtExpiration);
            this.grpPassword.Controls.Add(this.lblExpiration);
            this.grpPassword.Location = new System.Drawing.Point(13, 88);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(319, 196);
            this.grpPassword.TabIndex = 8;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Current Password";
            // 
            // lblNewExpiration
            // 
            this.lblNewExpiration.AutoSize = true;
            this.lblNewExpiration.Location = new System.Drawing.Point(6, 138);
            this.lblNewExpiration.Name = "lblNewExpiration";
            this.lblNewExpiration.Size = new System.Drawing.Size(78, 13);
            this.lblNewExpiration.TabIndex = 12;
            this.lblNewExpiration.Text = "New Expiration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(228, 151);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Visible = false;
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.lstPwdHistory);
            this.grpHistory.Location = new System.Drawing.Point(12, 302);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(320, 158);
            this.grpHistory.TabIndex = 9;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Password History";
            // 
            // lstPwdHistory
            // 
            this.lstPwdHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Expired,
            this.Password});
            this.lstPwdHistory.FullRowSelect = true;
            this.lstPwdHistory.GridLines = true;
            this.lstPwdHistory.HideSelection = false;
            this.lstPwdHistory.Location = new System.Drawing.Point(5, 20);
            this.lstPwdHistory.MultiSelect = false;
            this.lstPwdHistory.Name = "lstPwdHistory";
            this.lstPwdHistory.Size = new System.Drawing.Size(308, 132);
            this.lstPwdHistory.TabIndex = 0;
            this.lstPwdHistory.UseCompatibleStateImageBehavior = false;
            this.lstPwdHistory.View = System.Windows.Forms.View.Details;
            // 
            // Expired
            // 
            this.Expired.Text = "Expired";
            this.Expired.Width = 135;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 150;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(128, 478);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 513);
            this.Controls.Add(this.btnExit);
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
        private System.Windows.Forms.ListView lstPwdHistory;
        private System.Windows.Forms.ColumnHeader Expired;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblNewExpiration;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExit;
    }
}

