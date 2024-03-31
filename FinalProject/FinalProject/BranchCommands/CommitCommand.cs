using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands;

internal class CommitCommand : BranchCommand
{
    public CommitCommand(Branch branch) : base(branch)
    {
    }

    public override string Execute()
    {
        return Branch.Commit();
      
    }
}
