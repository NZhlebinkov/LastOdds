using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace LastOdds_Desktop_Client
{
    class CommunicationHandlingClass
    {
        public static string ReadServerData()
        {
            StringBuilder clientStr = new StringBuilder();


            byte[] buffer = new byte[2048];
            int bytesRead = 0;

            if (GlobalVariablesClass.clientNetworkStream.CanRead)
            {
                do
                {
                    bytesRead = GlobalVariablesClass.clientNetworkStream.Read(buffer, 0, 2048);

                    clientStr.AppendFormat("{0}", Encoding.ASCII.GetString(buffer, 0, bytesRead));

                } while (GlobalVariablesClass.clientNetworkStream.DataAvailable);

                return clientStr.ToString();
            }
            return "";
        }
        public static void SendToServer(string data)
        {
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(data);
            GlobalVariablesClass.clientNetworkStream.Write(buffer, 0, buffer.Length);
        }
    }
}
