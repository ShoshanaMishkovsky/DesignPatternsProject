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
            return folder.ErrorMessage();
        }

        public override string Review(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }

        public override string Stage(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }
    }
}
