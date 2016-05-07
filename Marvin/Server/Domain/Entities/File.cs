using Marvin.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Entities
{
    class File
    {
        protected String Path;

        protected String Name;

        protected long Size;

        protected String Checksum;

        protected Chunk[] Chunks;

        public File(String Filepath, String Basename)
        {
            Path = Filepath;
            Name = Basename;

            this.DetermineFileSize();
            this.DetermineFileChecksum();
        }

        private void DetermineFileChecksum()
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(Path))
                {
                    Checksum = md5.ComputeHash(stream).ToString();
                }
            }
        }

        private void DetermineFileSize()
        {
            Size = (new System.IO.FileInfo(Path)).Length;
        }

        override public String ToString()
        {
            return String.Format("{0} ({1})", Name, new FileSize(Size, FileSize.Unit.MB).ToString());
        }
    }
}
