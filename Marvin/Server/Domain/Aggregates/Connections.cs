using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Aggregates
{
    class Connections
    {
        private static Connections instance;

        protected List<Client> Clients;

        private Connections()
        {
            Clients = new List<Client>();
        }

        public static Connections getInstance()
        {
            if (null == instance)
            {
                instance = new Connections();
            }

            return instance;
        }

        public void AddClient(Client Client)
        {
            Clients.Add(Client);
        }
    }
}
