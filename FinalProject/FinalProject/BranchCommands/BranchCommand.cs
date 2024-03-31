using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands
{
    public abstract class BranchCommand
    {
        protected Branch Branch { get; set; }
        protected BranchCommand(Branch branch)
        {
            Branch = branch;
        }

        public abstract string Execute();
    }
}
