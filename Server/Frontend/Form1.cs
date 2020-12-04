using Server.Backend;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Server.Frontend
{
    public partial class Form1 : Form
    {
        private ServerHost myServer; // A simple server object

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.myServer = new ServerHost("Your IP", 8001);
        }

        #region Window Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region ChildForm Panel
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (this.activeForm != null) // If a form is already open, close it
                this.activeForm.Close();

            this.activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Submenu buttons
        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            FormUsers usersForm = new FormUsers();
            OpenChildForm(usersForm);
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            FormLogs logsForm = new FormLogs();
            OpenChildForm(logsForm);
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.myServer.ShutDown();
            Environment.Exit(0);
        }
    }
}
