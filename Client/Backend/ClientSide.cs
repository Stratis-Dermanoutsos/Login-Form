using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client.Backend
{
    static class ClientSide
    {
        public static char SendCredentials(string ip, int port, string credString)
        {
            try {
                TcpClient tcpClnt = new TcpClient();

                tcpClnt.Connect(ip, port);

                string str = credString;
                Stream stm = tcpClnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[1];
                int k = stm.Read(bb, 0, 1);

                tcpClnt.Close();

                return Convert.ToChar(bb[0]);
            } catch (Exception ex) {
                MessageBox.Show("Error..... " + ex.StackTrace);

                return 'n';
            }
        }
    }
}
