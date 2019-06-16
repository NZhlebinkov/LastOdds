using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOdds_Desktop_Client
{
    class AccountOperationsClass
    {
        public static void Login(string username, string password)
        {

        }
        public static void Register(string username, string password)
        {
            string salt;
            string hashedUsername;
            string hashedPassword;

            //
            string outgoingCommand = String.Format("register<$command$>{0}<$sub data$>{1}<$sub data$>{2}",                
                username
                );
        }
    }
}
