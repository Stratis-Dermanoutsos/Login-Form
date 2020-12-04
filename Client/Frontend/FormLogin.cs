using Client.Backend;
using Client.Properties;
using System;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Client.Frontend
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            #region <textBoxEmail>
            this.ActiveControl = textBoxEmail; // Set active
            textBoxEmail.GotFocus += textBoxEmail_GotFocus;
            textBoxEmail.LostFocus += textBoxEmail_LostFocus;
            #endregion

            #region <textBoxPassword>
            textBoxPassword.GotFocus += textBoxPassword_GotFocus;
            textBoxPassword.LostFocus += textBoxPassword_LostFocus;
            textBoxPassword.PasswordChar = '*';
            #endregion
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

        #region textBoxEmail
        private void textBoxEmail_GotFocus(object sender, EventArgs e)
        {
            panel1.BackColor = GlobalVariables.blueberry;
            pictureBoxUserIcon.BackgroundImage = Resources.user1;

            if (textBoxEmail.Text.Equals("Email"))
                textBoxEmail.Text = string.Empty;
        }

        private void textBoxEmail_LostFocus(object sender, EventArgs e)
        {
            panel1.BackColor = GlobalVariables.periwinkle;
            pictureBoxUserIcon.BackgroundImage = Resources.user0;

            if (textBoxEmail.Text.Equals(string.Empty))
                textBoxEmail.Text = "Email";
        }
        #endregion

        #region textBoxPassword
        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
            panel2.BackColor = GlobalVariables.blueberry;
            pictureBoxPasswordIcon.BackgroundImage = Resources.password1;

            if (textBoxPassword.Text.Equals("Password"))
                textBoxPassword.Text = string.Empty;
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            panel2.BackColor = GlobalVariables.periwinkle;
            pictureBoxPasswordIcon.BackgroundImage = Resources.password0;

            if (textBoxPassword.Text.Equals(string.Empty))
                textBoxPassword.Text = "Password";
        }
        #endregion

        #region Check email & password regex
        private bool EmailIsValid(string emailaddress)
        {
            try {
                MailAddress m = new MailAddress(emailaddress); // Makes a <MailAddress> instance based on the input

                return true; // Returns true if the format is true
            } catch (FormatException) {
                return false; // Else, false
            }
        }

        private bool PasswordIsValid(string password)
        {
            /* 
             * Minimum eight characters, 
             * at least one uppercase letter, 
             * one lowercase letter and
             * one number
             */
            Regex passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");

            return passwordPattern.IsMatch(password);
        }
        #endregion

        #region Login and Sign Up buttons
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            #region Local Variables
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            bool validEmail = EmailIsValid(email);
            bool validPassword = PasswordIsValid(password);
            #endregion

            // If our credentials are valid, run the code
            if (validEmail && validPassword) {
                try {
                    char isOke = ClientSide.SendCredentials("Server's IP", 8001, string.Format("{0} {1} 0", email, password));

                    if (isOke == 'y') {
                        // =>> Code to execute <<=
                    } else
                        MessageBox.Show("Email or password not correct!");
                } catch (Exception) {
                    MessageBox.Show("Error: Could not communicate with the Server!");
                }

                return;
            }

            MessageBox.Show("Email or password not valid.");
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            #region Local Variables
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            bool validEmail = EmailIsValid(email);
            bool validPassword = PasswordIsValid(password);
            #endregion

            if (validEmail && validPassword) {
                try {
                    char isOke = ClientSide.SendCredentials("Server's IP", 8001, string.Format("{0} {1} 1", email, password));

                    // If the signup is successful
                    if (isOke == 'y')
                        MessageBox.Show("Your account has been registered successfully.\nYou can now login with your credentials.");
                    else
                        MessageBox.Show("Email is taken");
                } catch (Exception) {
                    MessageBox.Show("We were unable to connect you to the server.");
                }
            } else {
                if (!validEmail) { // ...if email is not invalid
                    MessageBox.Show("This is not a valid email format.");
                } else { // ...if password is invalid
                    string errorMessage = "This is not a valid password.\n" +
                        "Please, use a password with:\n" +
                        "\t* minimum 8 characters,\n" +
                        "\t* at least 1 uppercase letter,\n" +
                        "\t* at least 1 lowercase letter and\n" +
                        "\t* at least 1 number.";
                    MessageBox.Show(errorMessage);
                }
            }
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
