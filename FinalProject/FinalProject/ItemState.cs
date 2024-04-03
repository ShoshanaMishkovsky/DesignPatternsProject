using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class ItemState
    {
        protected ItemContext folder;
        public ItemState(ItemContext folder)
        {
            this.folder = folder;  
        }
        public abstract string Merge(ItemContext itemContext);
        public abstract string  Commit(ItemContext itemContext);
        public abstract string Stage(ItemContext itemContext);
        public abstract string Review(ItemContext itemContext);
        public abstract string Push(ItemContext itemContext);
    }
}
