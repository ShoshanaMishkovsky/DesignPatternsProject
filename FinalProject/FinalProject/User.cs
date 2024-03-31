using FinalProject.BranchCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class User : ICollaborator
{
    public string Name { get; set; }
    private int Password { get; set; }
    public List<Branch> BranchItem { get; set; }
    public BranchInvoke Invoker { get; set; }


    public User(string name, int password)
    {
        this.Name = name;
        this.Password = password;
        this.BranchItem = new List<Branch>();
    }
    public void DeleteABranch(string name)
    {
        Branch branch = BranchItem.Find(b => b.Name == name);
        BranchItem.Remove(branch);

    }
    public void CreateABranch(string BranchName, string name, string type)
    {
        Branch branch = BranchItem.Find(b => b.Name == BranchName);
        BranchItem.Add(branch.Clone(name, type));
    }

    public void Merge(string name)
    {
        Branch branch = BranchItem.Find(b => b.Name == name);
        Branch branch1 = BranchItem.Find(b => b.Name == name && b.Type == "main");

        Invoker.AddJob(new MergeCommand(branch1,branch));
    }

    public void Commit(string name)
    {
       
        for (int i = 0; i < BranchItem.Count; i++)
        {
            Invoker.AddJob(new CommitCommand(BranchItem[i]));
        }
       
    }


    public void RequestAReview(string name)
    {
        int count = 0;
        Branch branch = BranchItem.Find(b => b.Name == name);
        for (int i = 0; i < branch.Collaborators.Count; i++)
        {
            bool response = branch.Collaborators[i].Review(new Details() { BranchName = name, User = this });
            if (response)
            {
                count++;
            }
        }
        if (count > 2)
        {
            Invoker.AddJob(new ReviewCommand(branch));
        }
    }

    public bool Review(Details details)
    {
        Console.WriteLine($" {Name}, you got a request to review branch {details.BranchName} of {details.User.Name} \ndo yo approve?t/f");
        string answer = Console.ReadLine();
        if (answer == "t")
        {
            return true;
        }
        return false;
    }
}
