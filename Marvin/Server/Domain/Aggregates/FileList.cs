using Marvin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvin.Domain.Aggregates
{
    class FileList
    {
        private static FileList instance;

        protected List<File> Files;

        private FileList()
        {
            Files = new List<File>();
        }

        public static FileList getInstance()
        {
            if (null == instance)
            {
                instance = new FileList();
            }

            return instance;
        }

        public void AddFile(File File)
        {
            Files.Add(File);
        }
    }
}
