using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args); //anything can be sent to object type. used proper event conventions (sender, other params)
    

}