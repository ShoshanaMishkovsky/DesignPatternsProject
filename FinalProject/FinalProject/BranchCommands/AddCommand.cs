using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands;

internal class AddCommand : BranchCommand
{
    public AddCommand(Branch branch) : base(branch)
    {
    }

    public override string Execute()
    {
        return Branch.Add();
    }
}
