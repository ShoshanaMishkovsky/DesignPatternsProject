using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FileStates
{
    public class StagedState : FileState
    {
        public StagedState(FolderItemContext folder) : base(folder)
        {
        }

        public override void Commit()
        {
            throw new NotImplementedException();
        }

        public override void Merge()
        {
            throw new NotImplementedException();
        }

        public override void Review()
        {
            throw new NotImplementedException();
        }

        public override void Stage()
        {
            throw new NotImplementedException();
        }
    }
}
