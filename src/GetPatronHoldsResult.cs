using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clc.Api.Models
{
    public class GetPatronHoldsResult : ClcApiResult
    {
        public List<PatronHeldItem> Holds { get; set; } = new();
    }
}
