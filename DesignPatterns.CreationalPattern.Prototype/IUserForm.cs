using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Prototype
{
    public interface IUserForm : ICloneable
    {
        string UserName { get; set;  }
        string Email { get; set; }

        void ShowDetails();
    }
}
