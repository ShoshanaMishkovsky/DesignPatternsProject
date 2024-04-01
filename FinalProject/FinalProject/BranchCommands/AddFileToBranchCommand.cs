using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands
{
    public class AddFileToBranchCommand : BranchCommand
    {
        public ItemContext item { get; set; }
        public AddFileToBranchCommand(Branch branch,ItemContext item) : base(branch)
        {
            this.item = item;
        }

        public override string Execute()
        {
           
           Branch.AddFile(item);
            return $"The item {item.Name} added";
        }
    }
}
