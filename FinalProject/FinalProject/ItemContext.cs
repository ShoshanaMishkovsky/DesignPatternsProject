using FinalProject.FileStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public abstract class ItemContext
{

    public string Name { get; set; }
    public ItemState State { get; set; }

    public ItemContext(string name)
    {
        this.Name = name;
        this.State = new DraftState(this);
    }

    public void ChangeState(ItemState fileState)
    {
     
    }
    public abstract string ShowDetails(string indent);
}
