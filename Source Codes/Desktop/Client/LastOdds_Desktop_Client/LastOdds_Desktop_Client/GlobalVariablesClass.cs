using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;

namespace LastOdds_Desktop_Client
{
    public class GlobalVariablesClass
    {
        public static TcpClient localClient = new TcpClient();
        public static NetworkStream clientNetworkStream;
        public static RSAParameters clientPrivateRSAKey;
        public static string clientPublicRSAKey;
        public static string serverPublicRSAKey;
    }
}
