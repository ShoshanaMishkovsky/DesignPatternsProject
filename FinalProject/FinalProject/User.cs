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
    public List<Branch> BranchItems { get; set; }
    public BranchInvoke Invoker { get; set; }


    public User(string name, int password)
    {
        this.Name = name;
        this.Password = password;
        this.BranchItems = new List<Branch>();
    }
    public void AddFileToBranch(string name, ItemContext item)
    {
        Branch branch = BranchItems.Find(b => b.Name == name);
        Invoker.AddJob(new AddFileToBranchCommand(branch,item));

    }
    public void UppdateFile(string name, ItemContext item)
    {
        Branch branch = BranchItems.Find(b => b.Name == name);
        Invoker.AddJob(new UpdateFileCommand(branch, item));

    }
    public void DeleteABranch(string name)
    {
        Branch branch = BranchItems.Find(b => b.Name == name);
        BranchItems.Remove(branch);

    }
    public void CreateABranch(string BranchName, string name, string type)
    {
        Branch branch = BranchItems.Find(b => b.Name == BranchName);
        if (branch == null)
            BranchItems.Add(new(name, type));
        else BranchItems.Add(branch.Clone(name, type));
    }

    public void Merge(string name)
    {
        Branch branch = BranchItems.Find(b => b.Name == name);
        Branch branch1 = BranchItems.Find(b => b.Name == name && b.Type == "main");

        Invoker.AddJob(new MergeCommand(branch1,branch));
    }

    public void Commit(string name)
    {
       
        for (int i = 0; i < BranchItems.Count; i++)
        {
            Invoker.AddJob(new CommitCommand(BranchItems[i]));
        }
       
    }


    public void RequestAReview(string name)
    {
        int count = 0;
        Branch branch = BranchItems.Find(b => b.Name == name);
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
        Console.WriteLine($" {Name}, you got a request to review branch {details.BranchName} of {details.User.Name} \ndo yo approve?y/n");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            return true;
        }
        return false;
    }
}
