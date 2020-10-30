using LoginForm.Backend;
using LoginForm.Frontend;
using LoginForm.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class FormLogin : Form
    {
        private List<User> users;

        public FormLogin()
        {
            InitializeComponent();

            // textBoxEmail
            this.ActiveControl = textBoxEmail; // Set active
            textBoxEmail.GotFocus += textBoxEmail_GotFocus;
            textBoxEmail.LostFocus += textBoxEmail_LostFocus;

            // textBoxPassword
            textBoxPassword.GotFocus += textBoxPassword_GotFocus;
            textBoxPassword.LostFocus += textBoxPassword_LostFocus;
            textBoxPassword.PasswordChar = '*';

            users = ListHandler.LoadList();
            #region Starting Test Accounts
            /*
             * oke@yahoo.gr
             * Potato69
             * 
             * idk42@gmail.com
             * IamPro91
             * 
             * xxxProplayerxxx@hotmail.com
             * saveMe74
             * 
             * whoMeIs@gmail.com
             * IneedHelp1
             * 
             * thisAppSucks@yahoo.com
             * iDkWhy345
             * 
             * johnIsClown@gmail.com
             * fullPepega69
             * 
             * xXdontBanYasuoXx@yahoo.pl
             * IneverFEED001
             * 
             * IhateLife@gmail.com
             * edgyTeen43
             * 
             * IneedAnOtterArmy@unipi.gr
             * Starting1010
             */
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
            bool validEmail = EmailIsValid(textBoxEmail.Text);
            bool validPassword = PasswordIsValid(textBoxPassword.Text);

            if (validEmail && validPassword && users.Count > 0) { // If both email and password are correct
                int index = ListHandler.BinaryRecursiveSearch(users, 0, users.Count - 1, textBoxEmail.Text);

                if (index != -1 && users[index].Password.Equals(PasswordHandler.GetSha512(textBoxPassword.Text))) {
                    FormMain mainForm = new FormMain();
                    this.Hide(); // Hide login form
                    mainForm.Show(); // Show main form
                    return;
                }
            }

            MessageBox.Show("Email or password not correct!");
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            bool validEmail = EmailIsValid(textBoxEmail.Text);
            bool validPassword = PasswordIsValid(textBoxPassword.Text);

            if (validEmail && validPassword) { // If both email and password are correct
                int index = (users.Count < 1) ? -1 : ListHandler.BinaryRecursiveSearch(users, 0, users.Count - 1, textBoxEmail.Text);

                if (index == -1) {
                    //Add the new user and re-sort the List
                    User newUser = new User(textBoxEmail.Text, PasswordHandler.GetSha512(textBoxPassword.Text), false);
                    users.Add(newUser);
                    users = ListHandler.QuickSort(users, 0, users.Count - 1);

                    ListHandler.SaveList(users); // Save to file

                    MessageBox.Show("You are good to go!");
                } else {
                    MessageBox.Show("Email is taken");
                }
            } else { // Else
                if (!validEmail) { // ...if email is invalid
                    MessageBox.Show("This is not a valid email.");
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
