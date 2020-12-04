using System;
using System.IO;
using System.Windows.Forms;

namespace Server.Frontend
{
    public partial class FormLogs : Form
    {
        string logsPath = "..\\..\\..\\Backend\\Logs.json"; // Our logs file

        public FormLogs()
        {
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();

            timer1.Start();
        }

        // Refresh the logs every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadLogs();
        }

        // Load and show the Logs
        public void LoadLogs() 
        {
            try {
                using (StreamReader stream = new StreamReader(logsPath))
                    label1.Text = stream.ReadToEnd();
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Error: {0}", ex.StackTrace));
            }
        }
    }
}
