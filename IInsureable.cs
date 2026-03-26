using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppe14
{
    public interface IInsurable
    {
        string RegistrationNumber { get; }
        double GetInsuranceRate();
    }
}
