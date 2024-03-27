using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class File : FolderItemContext
    {
        public File(string name) : base(name)
        {

        }
        public override string ShowDetails(string indent)
        {
            indent += "\t";
            return $"{indent}{Name}";

        }
    }
}
