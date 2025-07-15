using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clc.Api.Models
{
    public enum SysHoldStatuses
    {
        Suspended = 1,
        Requested = 3,
        Active = 4,
        Shipped = 5,
        Held = 6,
        NotSupplied = 7,
        Unclaimed = 8,
        RequestExpired = 9,
        Cancelled = 16,
        Out = 17,
        Located = 18,
    }
}
