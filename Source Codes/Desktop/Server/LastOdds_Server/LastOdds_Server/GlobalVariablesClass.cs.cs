﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace LastOdds_Server
{
    class GlobalVariablesClass
    {
        public static int connectedClientsCounter = 0;
        public static int totalLoadCounter = 0;
        public static List<ConnectedClient> connectedClients = new List<ConnectedClient>();
        public static List<int> clientsCachedIDs = new List<int>();
        public static RSAParameters serverPrivateKey;
        public static string serverPublicKeyXML;
        public static string serverPublicKey = String.Empty;
    }
}
