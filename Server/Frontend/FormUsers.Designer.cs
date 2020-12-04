
namespace Server.Frontend
{
    partial class FormUsers
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
            if (disposing && (components != null)) {
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelEditPassword = new System.Windows.Forms.Panel();
            this.buttonCancel1 = new System.Windows.Forms.Button();
            this.buttonConfirm1 = new System.Windows.Forms.Button();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.textBoxEmailNew = new System.Windows.Forms.TextBox();
            this.buttonCancel2 = new System.Windows.Forms.Button();
            this.buttonConfirm2 = new System.Windows.Forms.Button();
            this.textBoxPasswordNew = new System.Windows.Forms.TextBox();
            this.panelEditPassword.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.listBoxUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(60, 40);
            this.listBoxUsers.MinimumSize = new System.Drawing.Size(220, 410);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(220, 409);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonEdit.Location = new System.Drawing.Point(305, 410);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 40);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panelEditPassword
            // 
            this.panelEditPassword.Controls.Add(this.buttonCancel1);
            this.panelEditPassword.Controls.Add(this.buttonConfirm1);
            this.panelEditPassword.Controls.Add(this.textBoxNewPassword);
            this.panelEditPassword.Location = new System.Drawing.Point(300, 165);
            this.panelEditPassword.Name = "panelEditPassword";
            this.panelEditPassword.Size = new System.Drawing.Size(260, 129);
            this.panelEditPassword.TabIndex = 2;
            this.panelEditPassword.Visible = false;
            // 
            // buttonCancel1
            // 
            this.buttonCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonCancel1.FlatAppearance.BorderSize = 0;
            this.buttonCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonCancel1.Location = new System.Drawing.Point(140, 75);
            this.buttonCancel1.Name = "buttonCancel1";
            this.buttonCancel1.Size = new System.Drawing.Size(110, 40);
            this.buttonCancel1.TabIndex = 5;
            this.buttonCancel1.Text = "Cancel";
            this.buttonCancel1.UseVisualStyleBackColor = false;
            this.buttonCancel1.Click += new System.EventHandler(this.buttonCancel1_Click);
            // 
            // buttonConfirm1
            // 
            this.buttonConfirm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonConfirm1.FlatAppearance.BorderSize = 0;
            this.buttonConfirm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonConfirm1.Location = new System.Drawing.Point(10, 75);
            this.buttonConfirm1.Name = "buttonConfirm1";
            this.buttonConfirm1.Size = new System.Drawing.Size(110, 40);
            this.buttonConfirm1.TabIndex = 4;
            this.buttonConfirm1.Text = "Confirm";
            this.buttonConfirm1.UseVisualStyleBackColor = false;
            this.buttonConfirm1.Click += new System.EventHandler(this.buttonConfirm1_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.textBoxNewPassword.Location = new System.Drawing.Point(5, 25);
            this.textBoxNewPassword.MaxLength = 16;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PlaceholderText = "New password";
            this.textBoxNewPassword.Size = new System.Drawing.Size(250, 30);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonDelete.Location = new System.Drawing.Point(445, 410);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 40);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonAdd.Location = new System.Drawing.Point(305, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.textBoxEmailNew);
            this.panelAddUser.Controls.Add(this.buttonCancel2);
            this.panelAddUser.Controls.Add(this.buttonConfirm2);
            this.panelAddUser.Controls.Add(this.textBoxPasswordNew);
            this.panelAddUser.Location = new System.Drawing.Point(300, 124);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(260, 170);
            this.panelAddUser.TabIndex = 6;
            this.panelAddUser.Visible = false;
            // 
            // textBoxEmailNew
            // 
            this.textBoxEmailNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEmailNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.textBoxEmailNew.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.textBoxEmailNew.Location = new System.Drawing.Point(5, 21);
            this.textBoxEmailNew.MaxLength = 1000;
            this.textBoxEmailNew.Name = "textBoxEmailNew";
            this.textBoxEmailNew.PlaceholderText = "Email";
            this.textBoxEmailNew.Size = new System.Drawing.Size(250, 30);
            this.textBoxEmailNew.TabIndex = 6;
            // 
            // buttonCancel2
            // 
            this.buttonCancel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonCancel2.FlatAppearance.BorderSize = 0;
            this.buttonCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonCancel2.Location = new System.Drawing.Point(140, 116);
            this.buttonCancel2.Name = "buttonCancel2";
            this.buttonCancel2.Size = new System.Drawing.Size(110, 40);
            this.buttonCancel2.TabIndex = 5;
            this.buttonCancel2.Text = "Cancel";
            this.buttonCancel2.UseVisualStyleBackColor = false;
            this.buttonCancel2.Click += new System.EventHandler(this.buttonCancel2_Click);
            // 
            // buttonConfirm2
            // 
            this.buttonConfirm2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConfirm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(100)))), ((int)(((byte)(141)))));
            this.buttonConfirm2.FlatAppearance.BorderSize = 0;
            this.buttonConfirm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.buttonConfirm2.Location = new System.Drawing.Point(10, 116);
            this.buttonConfirm2.Name = "buttonConfirm2";
            this.buttonConfirm2.Size = new System.Drawing.Size(110, 40);
            this.buttonConfirm2.TabIndex = 4;
            this.buttonConfirm2.Text = "Confirm";
            this.buttonConfirm2.UseVisualStyleBackColor = false;
            this.buttonConfirm2.Click += new System.EventHandler(this.buttonConfirm2_Click);
            // 
            // textBoxPasswordNew
            // 
            this.textBoxPasswordNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPasswordNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.textBoxPasswordNew.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.textBoxPasswordNew.Location = new System.Drawing.Point(5, 66);
            this.textBoxPasswordNew.MaxLength = 16;
            this.textBoxPasswordNew.Name = "textBoxPasswordNew";
            this.textBoxPasswordNew.PlaceholderText = "Password";
            this.textBoxPasswordNew.Size = new System.Drawing.Size(250, 30);
            this.textBoxPasswordNew.TabIndex = 3;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelEditPassword);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panelEditPassword.ResumeLayout(false);
            this.panelEditPassword.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelEditPassword;
        private System.Windows.Forms.Button buttonConfirm1;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonCancel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.TextBox textBoxEmailNew;
        private System.Windows.Forms.Button buttonCancel2;
        private System.Windows.Forms.Button buttonConfirm2;
        private System.Windows.Forms.TextBox textBoxPasswordNew;
    }
}