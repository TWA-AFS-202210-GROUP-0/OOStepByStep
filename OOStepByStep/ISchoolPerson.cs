using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public interface ISchoolPerson : IPerson
    {
        string Job { get; set; }
    }
}
