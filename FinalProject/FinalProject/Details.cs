using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Details
    {
        public User User { get; set; }
        public string BranchName { get; set; }

        public Details(User user, string branchName)
        {
            User = user;
            BranchName = branchName;
        }
    }
}
