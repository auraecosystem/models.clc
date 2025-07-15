using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clc.Api.Models
{
    public class CatalogItemCopy
    {
        public int AssignedBranchID { get; set; }
        public string AssignedBranchName { get; set; } = string.Empty;
        public int ItemStatusID { get; set; }
        public string ItemStatusDescription { get; set; } = string.Empty;
        public int ItemRecordID { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public DateTime? FirstAvailableDate { get; set; }
        public DateTime? LastCkoDate { get; set; }

        public int YTDInHouseUseCount { get; set; }
        public int YTDCircCount { get; set; }
        public int PrevYTDInHouseUseCount { get; set; }
        public int PrevYTDCircCount { get; set; }

        public int LifetimeInHouseUseCount { get; set; }
        public int LifetimeCircCount { get; set; }
    }
}
