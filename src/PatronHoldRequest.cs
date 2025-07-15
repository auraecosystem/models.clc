namespace Clc.Api.Models
{
    public class PatronHoldRequest
    {
        public string Barcode { get; set; }
        public string Title { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public int PickupBranchId { get; set; }
        public bool IsIllRequest { get; set; }
    }
}
