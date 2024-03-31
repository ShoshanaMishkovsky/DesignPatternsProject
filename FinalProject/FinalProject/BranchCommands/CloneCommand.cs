using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BranchCommands
{
    internal class CloneCommand : BranchCommand
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public CloneCommand(Branch branch, string name, string type) : base(branch)
        {
            Name = name;
            Type = type;
        }

        public override string Execute()
        {
            Branch.Clone(Name, Type);
            return $"New Branch {Name}";
        }
    }
}
