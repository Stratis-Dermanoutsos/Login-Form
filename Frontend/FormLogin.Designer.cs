namespace LoginForm
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxPasswordIcon = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.textBoxEmail.Location = new System.Drawing.Point(100, 180);
            this.textBoxEmail.MaxLength = 1000;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 29);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.textBoxPassword.Location = new System.Drawing.Point(100, 255);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 29);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(100, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 5);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(100, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 5);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxPasswordIcon
            // 
            this.pictureBoxPasswordIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPasswordIcon.BackgroundImage")));
            this.pictureBoxPasswordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPasswordIcon.ErrorImage = null;
            this.pictureBoxPasswordIcon.InitialImage = null;
            this.pictureBoxPasswordIcon.Location = new System.Drawing.Point(50, 250);
            this.pictureBoxPasswordIcon.Name = "pictureBoxPasswordIcon";
            this.pictureBoxPasswordIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPasswordIcon.TabIndex = 2;
            this.pictureBoxPasswordIcon.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(380, 53);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
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
            this.buttonExit.Location = new System.Drawing.Point(327, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(53, 53);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonLogin.Location = new System.Drawing.Point(100, 350);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 50);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSignup
            // 
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonSignup.Location = new System.Drawing.Point(100, 450);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(180, 50);
            this.buttonSignup.TabIndex = 4;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(242)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(178, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "or";
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserIcon.BackgroundImage")));
            this.pictureBoxUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserIcon.ErrorImage = null;
            this.pictureBoxUserIcon.InitialImage = null;
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(50, 175);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserIcon.TabIndex = 2;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(380, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBoxPasswordIcon);
            this.Controls.Add(this.pictureBoxUserIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.PictureBox pictureBoxPasswordIcon;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
    }
}

