using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LastOdds_Server
{
    class Starter
    {
        static void Main(string[] args)
        {
          
            Thread clientListenerThread = new Thread(() => ClientListenerClass.SetupClientsServer());
            clientListenerThread.Start();

            //CryptoSecurityClass.HashPassword("crypto", "f56fa1f965dc0ccb97cb1f137ba6238b834fbc4ba8d09d1c9a6df7676cf334e2");
        }
    }
}
