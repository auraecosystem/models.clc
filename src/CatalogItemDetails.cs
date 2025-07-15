using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clc.Api.Models
{
    public class CatalogItemDetails
    {
        public List<string> Titles { get; set; } = [];
        public List<CatalogItemCopy> Items { get; set; } = [];
        public List<OrganizationInfo> Libraries { get; set; } = [];

        public string InputString { get; set; } = string.Empty;

        public int LibraryId { get; set; }
        public string LibraryName { get; set; } = string.Empty;
        public int CatalogLinkBranchId => LibraryId + 1;

        public int LocalItems { get; set; }
        public int ConsortiumItems { get; set; }
        public int TotalItems { get; set; }

        public int MyBranchHolds { get; set; }
        public int MyPatronHolds { get; set; }
        public int ConsortiumHolds { get; set; }
        public int TotalHolds { get; set; }

        public int YTDInHouseUseCount { get; set; }
        public int YTDCircCount { get; set; }
        public int PrevYTDInHouseUseCount { get; set; }
        public int PrevYTDCircCount { get; set; }

        public int LifetimeInHouseUseCount { get; set; }
        public int LifetimeCircCount { get; set; }
    }
}
