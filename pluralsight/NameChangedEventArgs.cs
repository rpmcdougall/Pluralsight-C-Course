using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class NameChangedEventArgs : EventArgs //inherit from EventArgs base class
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
