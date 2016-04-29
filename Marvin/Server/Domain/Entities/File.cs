using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Entities
{
    class File
    {
        protected String Name;

        protected Int32 Size;

        protected String Checksum;

        protected Chunk[] Chunks;

        public File(String Filepath)
        {
            this.DetermineFileName();
            this.DetermineFileSize();
            this.DetermineFileChecksum();
        }

        private void DetermineFileChecksum()
        {
            throw new NotImplementedException();
        }

        private void DetermineFileSize()
        {
            throw new NotImplementedException();
        }

        private void DetermineFileName()
        {
            throw new NotImplementedException();
        }
    }
}
