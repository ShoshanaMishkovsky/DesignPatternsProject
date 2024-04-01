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
            return folder.ErrorMessage();
        }

        public override string Merge(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }

        public override string Review(ItemContext itemContext)
        {
            itemContext.State = new UnderReviewState(itemContext);
            return $"{itemContext.Name} has been reviewed";

        }

        public override string Stage(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }
    }
}
