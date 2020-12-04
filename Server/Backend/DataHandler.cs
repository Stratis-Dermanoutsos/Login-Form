using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Server.Backend
{
    public static class DataHandler
    {
        #region Member Variables
        static string connectionString = @"Server=myServerAddress; Database=myDatabase; Trusted_Connection=True;";

        static string emailPattern = @"\w+\@\w+\.\w+";

        private static string logsPath = "..\\..\\..\\Backend\\Logs.json";
        #endregion

        // Create a connection to the Database and get the Data from our table
        public static void ShowEmailsTo(ListBox listBox)
        {
            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = "SELECT * FROM Account";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con)) {
                    DataTable emailTable = new DataTable();

                    adapter.Fill(emailTable);

                    listBox.DisplayMember = "email";
                    listBox.SelectedValue = "Id";
                    listBox.DataSource = emailTable.DefaultView;
                }

                con.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // Takes a string as a parameter and returns it hashed
        public static string HashedString(string str)
        {
            var data = Encoding.UTF8.GetBytes(str);
            var hashData = new SHA512Managed().ComputeHash(data);
            var hash = string.Empty;

            foreach (var b in hashData)
                hash += b.ToString("X2");

            return hash;
        }

        #region Credential Checking
        public static bool EmailExistsInDatabase(string str)
        {
            string email = Regex.Match(str, emailPattern).Value;

            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = "SELECT Email FROM Account WHERE Email = @0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@0", email);

                con.Open();

                var firstColumn = cmd.ExecuteScalar();

                con.Close();

                return firstColumn != null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool PasswordMatchesEmail(string str)
        {
            string email = Regex.Match(str, emailPattern).Value;
            string temp = Regex.Replace(str, emailPattern + @"\s", string.Empty);
            string password = Regex.Replace(temp, @"\s0", string.Empty);

            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = "SELECT Password FROM Account WHERE Email = @0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@0", email);

                con.Open();

                var firstColumn = cmd.ExecuteScalar();

                con.Close();

                return firstColumn != null && HashedString(password).Equals(firstColumn.ToString());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Edit our Database
        public static bool SaveNewAccount(string str)
        {
            string email = Regex.Match(str, emailPattern).Value;
            string temp = Regex.Replace(str, emailPattern + @"\s", string.Empty);
            string password = Regex.Replace(temp, @"\s1", string.Empty);

            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = "INSERT INTO Account VALUES (@0, @1);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@0", email);
                cmd.Parameters.AddWithValue("@1", HashedString(password));

                con.Open();

                var firstColumn = cmd.ExecuteScalar();

                con.Close();

                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void UpdatePassword(string email, string newPassword)
        {
            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = "UPDATE Account SET Password = @1 WHERE Email = @0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@0", email);
                cmd.Parameters.AddWithValue("@1", HashedString(newPassword));

                con.Open();

                var firstColumn = cmd.ExecuteScalar();

                con.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteAccount(string email)
        {
            try {
                SqlConnection con = new SqlConnection(connectionString);

                String query = string.Format("DELETE FROM Account WHERE Email = @0");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@0", email);

                con.Open();

                var firstColumn = cmd.ExecuteScalar();

                con.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Saves the specified string to the logs
        public static void WriteLogs(string str)
        {
            try {
                using (StreamWriter logs = new StreamWriter(logsPath, true))
                    logs.WriteLine(string.Format("{0} - {1}", DateTime.Now, str));
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Error: {0}", ex.StackTrace));
            }
        }
    }
}
