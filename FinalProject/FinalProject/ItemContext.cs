using FinalProject.FileStates;
using FinalProject.Memento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public string ErrorMessage()
    {
        return $"You can't do this action, you're in {State}";
    }
    public abstract string ShowDetails(string indent);
   

    internal Stack<IMemento> Mementos = new Stack<IMemento>();

    public void Backup(string name)
    {
        Console.WriteLine("\nCaretaker: Saving Originator's state...");
        var temp = this.Clone();
        this.Mementos.Push(new ConcreteMemento(name, temp));
    }

    public virtual void Undo()
    {
        if (this.Mementos.Count > 0)
        {
            var memento = this.Mementos.Pop().GetLastInitialState();

            this.State = memento.State;
        }
        else
        {
            Console.WriteLine("no history");
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: Here's the list of mementos:");
        foreach (var item in this.Mementos)
        {
            Console.WriteLine($"{item.GetName()} is in state {item.GetLastInitialState().State}");
        }
    }
    public abstract ItemContext Clone();
   
}