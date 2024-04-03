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
            return folder.ErrorMessage();
        }

        public override string Merge(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }

        public override string Push(ItemContext itemContext)
        {
            itemContext.State = new ReadyToMergeState(itemContext);
            return $"{itemContext.Name} is ready to merge";
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
