using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class FolderComposite : ItemContext
{
    public List<ItemContext> Items { get; private set; }
    public FolderComposite(string name) : base(name)
    {
        Items = new List<ItemContext>();
    }
    public void Add(ItemContext item)
    {
        Items.Add(item);

    }
    public void remove(ItemContext item)
    {
        var item1 = Items.Find(i => i.Name == item.Name);
        Items.Remove(item1);
    }


    public override string ShowDetails(string indent)
    {
        indent += "\t";
        string s = $"{indent}{Name}";
        foreach (var item in Items)
        {
            s += "\n";
            s += item.ShowDetails(indent);
        }
        return s;
    }

    public override ItemContext Clone()
    {
        FolderComposite folderComposite = new(this.Name);
        folderComposite.Items=this.Items;
        folderComposite.State = this.State;
        return folderComposite;

    }
}
