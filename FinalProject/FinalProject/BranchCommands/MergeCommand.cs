using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands;

internal class MergeCommand : BranchCommand
{
    public Branch BranchForMerge { get; set; }
    public MergeCommand(Branch branch, Branch branchForMerge) : base(branch)
    {
        BranchForMerge = branchForMerge;

    }

    public override string Execute()
    {
        return Branch.Merge(BranchForMerge);
       
    }
}
