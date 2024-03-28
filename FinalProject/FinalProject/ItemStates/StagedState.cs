using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FileStates
{
    public class StagedState : ItemState
    {
        public StagedState(ItemContext folder) : base(folder)
        {
        }

        public override string Commit(ItemContext itemContext)
        {
            itemContext.State = new CommitedState(itemContext);
            return $"{itemContext.Name} has been commited";
        }

        public override string Merge(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }

        public override void Review(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }

        public override string Stage(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }
    }
}
