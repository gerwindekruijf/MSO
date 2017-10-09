using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Server
    {
        Database database;
        
        public Server()
        {
        }

        public void RequestTariefEeenheden()
        {
            database.GetTariefEenheden();
        }

        public void RequestPrice()
        {
            database.Prijs();
        }

        public void Store()
        {

        }
    }
}
