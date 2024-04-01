using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FileStates
{
    public class ReadyToMergeState : ItemState
    {
        public ReadyToMergeState(ItemContext folder) : base(folder)
        {
        }

        public override string Commit(ItemContext itemContext)
        {
            return folder.ErrorMessage();
        }

        public override string Merge(ItemContext itemContext)
        {
            itemContext.State = new MergeState(itemContext);
            return $"{itemContext.Name} has been merged";
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
