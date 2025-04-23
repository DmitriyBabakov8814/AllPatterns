using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Singleton
{
    public class Connection
    {
        private static Connection connection;

        public string Config { get; private set; }

        public Connection(string config)
        {
            Config = config;
        }

        public static Connection GetConnection(string server)
        {
            if (connection == null)
            {
                connection = new Connection(server);
            }
            return connection;
        }

    }
}
