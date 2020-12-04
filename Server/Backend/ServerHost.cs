using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Backend
{
    class ServerHost
    {
        #region Member Variables
        private string ip;
        private int port;

        private TcpListener tcpListener;
        Socket s;

        private bool serverRunning;
        #endregion

        // Constructor
        public ServerHost(string ip, int port)
        {
            this.ip = ip;
            this.port = port;

            StartServer();
        }

        #region Server status
        public void StartServer()
        {
            try {
                IPAddress ipAd = IPAddress.Parse(this.ip); //IPv4

                this.tcpListener = new TcpListener(ipAd, this.port); // Initializes the Listener

                this.tcpListener.Start(); // Start Listeneting at the specified port
                this.serverRunning = true;

                _ = AwaitConnection();
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Error..... {0}", ex.StackTrace));
            }
        }

        public void ShutDown()
        {
            string log = string.Format("Server closed");
            DataHandler.WriteLogs(log);

            // Clean up
            if (this.serverRunning) {
                this.serverRunning = false;

                if (this.s != null) this.s.Close();
                if (this.tcpListener != null) this.tcpListener.Stop();
            }
        }
        #endregion

        #region Handling connections
        private async Task AwaitConnection()
        {
            string log = string.Format("Server started at {0}:{1}", this.ip, this.port);
            DataHandler.WriteLogs(log);

            while (this.serverRunning) {
                this.s = await this.tcpListener.AcceptSocketAsync();

                OnServerConnected();
            }
        }

        private void OnServerConnected()
        {
            try {
                byte[] b = new byte[256];
                int k = this.s.Receive(b);

                string received = Encoding.ASCII.GetString(b, 0, k);

                ASCIIEncoding asen = new ASCIIEncoding();
                this.s.Send(asen.GetBytes(Response(received).ToString()));
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Error: {0}", ex.StackTrace));
            }
        }
        #endregion

        /* 
         * Method to communicate with the client. 
         * returns 'y' for positive
         * returns 'n' for negative
         */
        private char Response(string str)
        {
            char requestDigit = str[str.Length-1]; // 0 for Login, 1 for Register
            string cltIP = ((IPEndPoint)this.s.RemoteEndPoint).Address.ToString();
            string log;

            if (requestDigit == '0') { // Login
                if (DataHandler.EmailExistsInDatabase(str) && DataHandler.PasswordMatchesEmail(str)) {
                    log = string.Format("Successful login from {0}", cltIP);
                    DataHandler.WriteLogs(log);

                    return 'y';
                }

                log = string.Format("Unsuccessful login from {0}", cltIP);
                DataHandler.WriteLogs(log);
            } else { // Register
                if (!DataHandler.EmailExistsInDatabase(str) && DataHandler.SaveNewAccount(str)) {
                    log = string.Format("Successful registration from {0}", cltIP);
                    DataHandler.WriteLogs(log);

                    return 'y';
                }

                log = string.Format("Unsuccessful registration from {0}", cltIP);
                DataHandler.WriteLogs(log);
            }

            return 'n';
        }
    }
}
