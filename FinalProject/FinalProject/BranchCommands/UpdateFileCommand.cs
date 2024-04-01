using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands
{
    public class UpdateFileCommand : BranchCommand
    {
        public ItemContext item { get; set; }
        public UpdateFileCommand(Branch branch,ItemContext item) : base(branch)
        {
this.item = item;
        }

        public override string Execute()
        {
            Branch.UpdateFile(item);
            return $"The item {item.Name} updated";
        }
    }
}
