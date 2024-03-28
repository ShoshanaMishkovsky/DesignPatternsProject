using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FileStates
{
    public class UnderReviewState : ItemState
    {
        public UnderReviewState(ItemContext folder) : base(folder)
        {
        }

        public override string Commit(ItemContext itemContext)
        {
            throw new NotImplementedException();
        }

        public override string Merge(ItemContext itemContext)
        {
            itemContext.State = new ReadyToMergeState(itemContext);
            return $"{itemContext.Name} is ready to merge";
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
