﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public interface ISchoolPersonWithClassNumber : ISchoolPerson
    {
        int ClassNumber { get; set; }
    }
}
