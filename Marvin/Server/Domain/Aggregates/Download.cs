using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Aggregates
{
    class Download
    {
        protected Client Client;
        protected File File;
        protected Boolean Status;
        protected DateTime CreatedAt;
        protected Int32 ChunksSent; // Valor inicial: Nulo. Primeiro pedaço é zero
    }
}
