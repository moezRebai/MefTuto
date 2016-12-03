using Mef.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.DataBaseManager
{
    public class DatabaseLogger : ILogger
    {
        public string LogType
        {
            get
            {
                return "Database Logger";
            }
        }

        public string LogMessage(string message)
        {
            return "Log To Database";
        }
    }
}
