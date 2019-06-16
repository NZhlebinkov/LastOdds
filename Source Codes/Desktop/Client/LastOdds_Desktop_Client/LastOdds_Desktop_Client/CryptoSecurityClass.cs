using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace LastOdds_Desktop_Client
{
    public class CryptoSecurityClass
    {
        public static string GenerateSalt()
        {
            return "";
        }

        public static string HashPassword(string data, string salt)
        {
            byte[] hashedDataBytes;
            string hashedDataPlaintext;
            string saltedData = data + salt;


            byte[] saltedDataBytes = Encoding.UTF8.GetBytes(saltedData);
            using (SHA512 shaHasher = new SHA512Managed())
            {
                hashedDataBytes = shaHasher.ComputeHash(saltedDataBytes);
            }

            hashedDataPlaintext = Encoding.UTF8.GetString(hashedDataBytes);

            return hashedDataPlaintext;
        }
    }
}
