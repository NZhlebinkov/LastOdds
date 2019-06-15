using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace LastOdds_Server
{
    public class ConnectedClient
    {
        int _id;
        TcpClient _client;
        bool _isActive;

        public ConnectedClient(int id, TcpClient client, bool isActive)
        {
            _id = id;
            _client = client;
            _isActive = IsActive;
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
