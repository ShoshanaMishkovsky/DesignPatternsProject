using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _name;
        private DateTime _date;
        private ItemContext _lastInitialState;
        public ConcreteMemento(string name, ItemContext lastInitialState)
        {
            this._name = name;
            this._date = DateTime.Now;
            this._lastInitialState = lastInitialState;
        }

        public DateTime GetDate()
        {
            return this._date;
        }

        public ItemContext GetLastInitialState()
        {
            return this._lastInitialState;
        }

        public string GetName()
        {
            return this._name;
        }
    }
}
