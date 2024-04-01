using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento
{
    public interface IMemento
    {
        string GetName();
        ItemContext GetLastInitialState();
        DateTime GetDate();
    }
}
