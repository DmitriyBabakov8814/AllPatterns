using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Singleton
{
    public class App
    {
        public Connection connectionApp { get; set; }

        public void Launch(string server)
        {
            connectionApp = Connection.GetConnection(server);
        }
    }
}
