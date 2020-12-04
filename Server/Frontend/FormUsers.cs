using Server.Backend;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Server.Frontend
{
    public partial class FormUsers : Form
    {
        #region Constructor and On-Load event
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DataHandler.ShowEmailsTo(listBoxUsers);
        }
        #endregion

        #region Form Buttons
        // Adds a new user to the database
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelEditPassword.Visible = false;
            panelAddUser.Visible = true;
        }

        // Edits the password of the selected user
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1) {
                panelAddUser.Visible = false;
                panelEditPassword.Visible = true;
            }
            else
                MessageBox.Show("You must first select a User!");
        }

        // Deletes the selected user
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1) {
                string email = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);

                // Delete and save it in the logs
                DataHandler.DeleteAccount(email);
                DataHandler.WriteLogs(string.Format("Deleted user {0}", email));

                RefreshListBox(); // Refresh the <listBoxUsers>
            } else
                MessageBox.Show("You must first select a User!");
        }
        #endregion

        #region <panelEditPassword> Buttons
        private void buttonConfirm1_Click(object sender, EventArgs e)
        {
            string email = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
            string newPassword = textBoxNewPassword.Text;

            if (PasswordIsValid(newPassword)) {
                DataHandler.UpdatePassword(email, newPassword);
                DataHandler.WriteLogs(string.Format("Changed password for user {0}", email));

                // Reset the <panelEditPassword>
                textBoxNewPassword.Text = string.Empty;
                panelEditPassword.Visible = false;
            } else
                MessageBox.Show("Not a valid password.");
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            // Clear the textBox'es
            textBoxNewPassword.Text = string.Empty;

            panelEditPassword.Visible = false; // Hide
        }
        #endregion

        #region <panelAddUser> Buttons
        private void buttonConfirm2_Click(object sender, EventArgs e)
        {
            string email = textBoxEmailNew.Text;
            string password = textBoxPasswordNew.Text;

            string log;

            // If the credentials have a valid format
            bool validEmail = EmailIsValid(email);
            if (validEmail && PasswordIsValid(password)) {
                string str = string.Format("{0} {1} 1", email, password);

                // If the email does not already exist and the new account was saved successfully
                if (!DataHandler.EmailExistsInDatabase(str) && DataHandler.SaveNewAccount(str)) {
                    // Write the logs
                    log = string.Format("Successfully registered user '{0}'", email);
                    DataHandler.WriteLogs(log);

                    RefreshListBox(); // Refresh the <listBoxUsers>

                    // Clear the textBox'es
                    textBoxEmailNew.Text = string.Empty;
                    textBoxPasswordNew.Text = string.Empty;

                    panelAddUser.Visible = false; // Hide the panel
                } else if (DataHandler.EmailExistsInDatabase(str)) { // If the email already exists
                    MessageBox.Show("Email is already registered."); // Let the Server's user know

                    // Write the logs
                    log = string.Format("Unsuccessful registration for user '{0}'", email);
                    DataHandler.WriteLogs(log);
                }
            } else if (!validEmail) { // If the email is not valid
                MessageBox.Show("Email is not valid."); // Let the Server's user know

                // Write the logs
                log = string.Format("Unsuccessful registration for user '{0}'", email);
                DataHandler.WriteLogs(log);
            } else { // If password is not valid
                // Let the Server's user know
                string errorMessage = "This is not a valid password.\n" +
                        "Please, use a password with:\n" +
                        "\t* minimum 8 characters,\n" +
                        "\t* at least 1 uppercase letter,\n" +
                        "\t* at least 1 lowercase letter and\n" +
                        "\t* at least 1 number.";
                MessageBox.Show(errorMessage); 

                // Write the logs
                log = string.Format("Unsuccessful registration for user '{0}'", email);
                DataHandler.WriteLogs(log);
            }
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            // Clear the textBox'es
            textBoxEmailNew.Text = string.Empty;
            textBoxPasswordNew.Text = string.Empty;

            panelAddUser.Visible = false; // Hide
        }
        #endregion

        #region <listBoxUsers>'s stuff
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEditPassword.Visible = false;
        }

        private void RefreshListBox()
        {
            listBoxUsers.DataSource = null;
            listBoxUsers.Items.Clear();
            DataHandler.ShowEmailsTo(listBoxUsers);
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
    }
}
