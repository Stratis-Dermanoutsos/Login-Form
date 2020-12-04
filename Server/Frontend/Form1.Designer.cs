namespace Server.Frontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBetween = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.panelSubmenuGap1 = new System.Windows.Forms.Panel();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.panelSubmenuGap0 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 55);
            this.panelTop.TabIndex = 10;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelTitle
            // 
            this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(127, 48);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Server";
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonExit.Location = new System.Drawing.Point(751, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 55);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelBetween
            // 
            this.panelBetween.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panelBetween.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBetween.Location = new System.Drawing.Point(0, 55);
            this.panelBetween.Name = "panelBetween";
            this.panelBetween.Size = new System.Drawing.Size(800, 5);
            this.panelBetween.TabIndex = 11;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelSubmenu.Controls.Add(this.buttonLogs);
            this.panelSubmenu.Controls.Add(this.panelSubmenuGap1);
            this.panelSubmenu.Controls.Add(this.buttonManageUsers);
            this.panelSubmenu.Controls.Add(this.panelSubmenuGap0);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 60);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(220, 490);
            this.panelSubmenu.TabIndex = 13;
            // 
            // buttonLogs
            // 
            this.buttonLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogs.FlatAppearance.BorderSize = 0;
            this.buttonLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonLogs.Location = new System.Drawing.Point(0, 105);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonLogs.Size = new System.Drawing.Size(220, 54);
            this.buttonLogs.TabIndex = 0;
            this.buttonLogs.Text = "Logs";
            this.buttonLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogs.UseVisualStyleBackColor = true;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // panelSubmenuGap1
            // 
            this.panelSubmenuGap1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuGap1.Location = new System.Drawing.Point(0, 95);
            this.panelSubmenuGap1.Name = "panelSubmenuGap1";
            this.panelSubmenuGap1.Size = new System.Drawing.Size(220, 10);
            this.panelSubmenuGap1.TabIndex = 14;
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageUsers.FlatAppearance.BorderSize = 0;
            this.buttonManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageUsers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonManageUsers.Location = new System.Drawing.Point(0, 41);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonManageUsers.Size = new System.Drawing.Size(220, 54);
            this.buttonManageUsers.TabIndex = 0;
            this.buttonManageUsers.Text = "Manage Users";
            this.buttonManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // panelSubmenuGap0
            // 
            this.panelSubmenuGap0.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuGap0.Location = new System.Drawing.Point(0, 0);
            this.panelSubmenuGap0.Name = "panelSubmenuGap0";
            this.panelSubmenuGap0.Size = new System.Drawing.Size(220, 41);
            this.panelSubmenuGap0.TabIndex = 14;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 60);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(580, 490);
            this.panelChildForm.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelBetween);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelBetween;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Panel panelSubmenuGap0;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.Panel panelSubmenuGap1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

