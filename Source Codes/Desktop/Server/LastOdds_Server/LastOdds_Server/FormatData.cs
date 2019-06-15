using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOdds_Server
{
    public class FormatData
    {
        public static string[] IncomingDataToArray(string data, string splitWord)
        {

            string[] commandSplitingKeywordChars = { splitWord };

            string[] incomingCommandArray = data.Split(commandSplitingKeywordChars, StringSplitOptions.RemoveEmptyEntries);

            return incomingCommandArray;

        }
    }
}
