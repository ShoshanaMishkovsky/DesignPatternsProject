using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands;

internal class ReviewCommand : BranchCommand
{
    public ReviewCommand(Branch branch) : base(branch)
    {
    }

    public override string Execute()
    {
        Branch.Review();
        return "review";
    }
}
