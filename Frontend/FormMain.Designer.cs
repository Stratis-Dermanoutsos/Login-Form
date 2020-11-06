namespace LoginForm.Frontend
{
    partial class FormMain
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonProfilePic = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBetween = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.openFileDialogProfilePic = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.buttonProfilePic);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 53);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // buttonProfilePic
            // 
            this.buttonProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfilePic.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProfilePic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonProfilePic.Location = new System.Drawing.Point(653, 5);
            this.buttonProfilePic.Name = "buttonProfilePic";
            this.buttonProfilePic.Size = new System.Drawing.Size(45, 45);
            this.buttonProfilePic.TabIndex = 2;
            this.buttonProfilePic.Text = "Your Picture";
            this.buttonProfilePic.UseVisualStyleBackColor = false;
            this.buttonProfilePic.Click += new System.EventHandler(this.buttonProfilePic_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 48);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Program\'s Title";
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonExit.Location = new System.Drawing.Point(747, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(53, 53);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelBetween
            // 
            this.panelBetween.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panelBetween.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBetween.Location = new System.Drawing.Point(0, 53);
            this.panelBetween.Name = "panelBetween";
            this.panelBetween.Size = new System.Drawing.Size(800, 3);
            this.panelBetween.TabIndex = 1;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.AutoScroll = true;
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 56);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(175, 394);
            this.panelSubmenu.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(175, 56);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(625, 394);
            this.panelMain.TabIndex = 3;
            // 
            // openFileDialogProfilePic
            // 
            this.openFileDialogProfilePic.FileName = "openFileDialogProfilePic";
            this.openFileDialogProfilePic.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            this.openFileDialogProfilePic.InitialDirectory = "D:\\myFiles\\Photos";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSubmenu);
            this.Controls.Add(this.panelBetween);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBetween;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonProfilePic;
        private System.Windows.Forms.OpenFileDialog openFileDialogProfilePic;
    }
}