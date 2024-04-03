using FinalProject.BranchCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BranchInvoke
    {
        List<string> branchCommands;
        public BranchInvoke()
        {
            branchCommands=new List<string> ();
        }
        public void AddJob(BranchCommand command)
        {
            branchCommands.Add(command.Execute());
        }
        public void PrintActions()
        {
            foreach (string command in branchCommands)
            {
                Console.WriteLine(command);
            }
        }
    }
}
