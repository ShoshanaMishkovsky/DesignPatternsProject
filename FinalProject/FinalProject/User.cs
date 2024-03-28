using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class User
{
    public string Name { get; set; }
    private int Password { get; set; }
    public List<string> Messages { get; set; }
   
    public List<Branch> BranchItem { get; set; }

    public List<User> Collaborators { get; set; }
  

    public User(string name, int password)
    {
        this.Name = name;
        this.Password = password;
        this.BranchItem = new List<Branch>();
    }

    public void Merge()
    {

    }

    public void Commit(string name)
    {

        
    }

    public void RequestAReview(string name)
    {
        for (int i = 0;i<Collaborators.Count;i++)
        {
            Collaborators[i].Messages.Add($"requesting a review for branch {name}");
        }
        //צריך לשנות ולעשות את הפונקציה הזאת רק לbranch מסוים
        for (int i = 0; i < BranchItem.Count; i++)
        {
            BranchItem[i].Review();
        }
    }
}
