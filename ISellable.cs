using System;
using System.Collections.Generic;
using System.Text;

namespace Gruppe14
{
    public interface ISellable
    {
        double Price { get; }
        string GetSalesSummary();
    }
}
