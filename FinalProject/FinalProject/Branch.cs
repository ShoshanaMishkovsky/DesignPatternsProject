using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class Branch
{
    public List<ItemContext> items;
    public string Type { get; set; }

    public string Name { get; set; }


    public Branch(string name)
    {
        items = new List<ItemContext>();
        Name = name;
    }
    public Branch(string name, List<ItemContext> items, string type)
    {
        this.items = items;
        Name = name;
        Type = type;

    }

    public string BranchDetails()
    {
        string bT;
        bT = $"Branch Name: {Name}\n";
        for (int i = 0; i < items.Count; i++)
        {
            bT += items[i].ShowDetails("");
        }
        return bT;
    }

    public Branch Clone(string name, string type)
    {
        return new Branch(name, items, type);
    }
    public string Merge(Branch branch)
    {
        items = branch.items;
        return $"branch {Name} has been merged";
    }
    public string Add()
    {
        string add = "";
        for (int i = 0; i < items.Count; i++)
        {
            add += items[i].State.Stage(items[i]);
        }
        return add;
    }

    public string Commit()
    {
        string commit = "";
        for (int i = 0; i < items.Count; i++)
        {
            commit += items[i].State.Commit(items[i]);
        }
        return commit;
    }

    public void Review()
    {
        for (int i = 0;i < items.Count; i++)
        {
            items[i].State.Review(items[i]);
        }
    }

    public string ReadyToMerge()
    {
        string merge = "";
        for (int i = 0;i<items.Count;i++)
        {
            merge += items[i].State.Merge(items[i]);
        }
        return merge;
    }

    public string Merge()
    {
        string merge = "";
        for (int i = 0; i < items.Count; i++)
        {
            merge += items[i].State.Merge(items[i]);
        }
        return merge;
    }
}

