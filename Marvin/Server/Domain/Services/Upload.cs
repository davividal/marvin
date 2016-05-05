using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Services
{
    class Upload
    {
        protected Client Client;
        protected File File;

        public Upload(Client Client, File File)
        {
            this.Client = Client;
            this.File = File;

            GetChunks();
        }

        private void GetChunks()
        {
            //return File.GetChunks();
        }

        /*public SendFile()
        {
            Client.getSocket().Send();
        }*/
    }
}
