using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Sodium;

namespace LastOdds_Server
{
    class CryptoSecurityClass
    {

        public static void HashPassword(string password, string hash)
        {
            Console.WriteLine(PasswordHash.ArgonHashString(password, PasswordHash.StrengthArgon.Interactive));

        }
    }
}
