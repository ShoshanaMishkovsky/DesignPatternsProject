using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FileStates
{
    public class CommitedState : ItemState
    {
        public CommitedState(ItemContext folder) : base(folder)
        {
        }

        public override string Commit(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }

        public override string Merge(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }

        public override void Review(ItemContext itemContext)
        {
            itemContext.State = new UnderReviewState(itemContext);

        }

        public override string Stage(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }
    }
}
