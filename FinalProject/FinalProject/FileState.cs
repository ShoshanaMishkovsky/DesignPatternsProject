using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class FileState
    {
        protected FolderItemContext folder;
        public FileState(FolderItemContext folder)
        {
            this.folder = folder;  
        }
        public abstract void Merge();
        public abstract void Commit();
        public abstract void Stage();
        public abstract void Review();
    }
}
