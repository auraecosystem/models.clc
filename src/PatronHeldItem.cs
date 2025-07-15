namespace Clc.Api.Models
{
    public class PatronHeldItem
    {
        public string TrappedItemBarcode { get; set; } = string.Empty;
        public int? MaterialTypeID { get; set; }
        public string? MaterialTypeDescription { get; set; }
        public int? CollectionID { get; set; }
        public string? CollectionName { get; set; }
        public string Title { get; set; } = string.Empty;
        public int StatusID { get; set; }
        public string StatusDescription { get; set; } = string.Empty;
        public int PickupBranchID { get; set; }
        public string PickupBranchName { get; set; } = string.Empty;
        public int? HoldPickupAreaID { get; set; }
        public string? HoldPickupAreaDescription { get; set; }
        public DateTime? HoldTillDate { get; set; }
        public bool IsIllRequest { get; set; }
    }
}
