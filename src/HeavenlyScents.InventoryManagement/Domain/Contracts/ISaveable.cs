using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenlyScents.InventoryManagement.Domain.Contracts
{
    internal interface ISaveable
    {
        string ConvertToStringForSaving();
    }
}
