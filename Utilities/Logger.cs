using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWzorce.Utilities
{
    public class Logger
    {
        private Logger() { }

        private static Logger _instance;

        private static readonly object _lock = new();

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }


        public void LogMessage(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Log", DateTime.Now.ToShortDateString());
            string filePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);

            StringBuilder sb = new();
            sb.Append(DateTime.Now.ToString());
            sb.Append(" :: ");
            sb.Append(message);
            sb.Append('\n');

            using StreamWriter writer = new(filePath, true);
            writer.Write(sb.ToString());
            writer.Flush();
        }
    }
}
