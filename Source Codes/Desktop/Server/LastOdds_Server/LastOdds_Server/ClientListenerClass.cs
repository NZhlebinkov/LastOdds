using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LastOdds_Server
{
    class ClientListenerClass
    {
        private static TcpListener clientListeningServer;
        private static readonly IPAddress clientListeningServerIP = IPAddress.Parse("127.0.0.1");
        public static void SetupClientsServer()
        {
            clientListeningServer = new TcpListener(clientListeningServerIP, 1054);
            clientListeningServer.Start();

            Console.WriteLine(">> The clients listening server has started");

            while (true)
            {
                TcpClient client = clientListeningServer.AcceptTcpClient();
             

                bool hasCached = GlobalVariablesClass.clientsCachedIDs.Any();

                GlobalVariablesClass.totalLoadCounter++;

                if (hasCached == true)
                {
                    Thread acceptConnThread = new Thread(() => AcceptConnectionRequest(
                    client,
                    GlobalVariablesClass.clientsCachedIDs[0], true));

                    acceptConnThread.Start();
                }
                else
                {

                    Thread acceptConnThread = new Thread(() => AcceptConnectionRequest(
                    client,
                    GlobalVariablesClass.connectedClientsCounter++, false));

                    
                    acceptConnThread.Start();
                }
            }
        }
        public static void AcceptConnectionRequest(TcpClient clientConnection, int id, bool isCached)
        {
           
            if (isCached == true)
            {
                GlobalVariablesClass.clientsCachedIDs.RemoveAt(0);
                Console.WriteLine(">> Cached value was given to CLIENT with ID: " + id);
            }

            Console.WriteLine(">> CLIENT was connected: " + id);

           
            ConnectedClient client = new ConnectedClient(
                id,
                clientConnection,
                false
            );

            GlobalVariablesClass.connectedClients.Add(client);

            for (int i = 0; i < GlobalVariablesClass.connectedClients.Count; i++)
            {
                ConnectedClient currentClient = GlobalVariablesClass.connectedClients[i];
                Console.WriteLine(">> CLIENT loop");

                if (currentClient.IsActive == false)
                {
                    Console.WriteLine(">> Activating CLIENT: " + id);

                    Thread clientPrivateThread = new Thread(() => ClientPrivateThread.HandleClientRequest(clientConnection, id));
                    clientPrivateThread.Start();

                    GlobalVariablesClass.connectedClients[i].IsActive = true;
                    Console.WriteLine(">> CLIENT was activated");
                }
            }
        }
    }
}
