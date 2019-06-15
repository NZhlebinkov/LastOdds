using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOdds_Server
{
    class ClientPrivateThread
    {
        public static void HandleClientRequest(TcpClient client, int id)
        {
            try
            {
                while (true)
                {
                    string receivedData = CommunicationHandling.ReadClientData(client);
                    Console.WriteLine("Received" + receivedData);
                    string receivedCommand = FormatData.IncomingDataToArray(receivedData, "<$command$>")[0];
                    string subData = FormatData.IncomingDataToArray(receivedData, "<$command$>")[1];

                    if (receivedCommand == "register")
                    {
                        string[] subDataArrguments = FormatData.IncomingDataToArray(subData, "<$sub data$>");
                        string username = subDataArrguments[0];
                        string password = subDataArrguments[1];
                        string clientCryptographyKey = subDataArrguments[2];

                    }
                    else if (receivedCommand == "login")
                    {

                    }
                    else if (receivedCommand == "list_tournaments")
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Client Disconencted");
                Console.WriteLine(ex);
            }
           
           
        }
    }
}
//cmd<$command$>1<$sub data$>2<$sub data$>3<$sub data$>