namespace Clc.Api.Models
{
    public class BibHolding
    {
        public int AssignedBranchID { get; set; }
        public string AssignedBranchName { get; set; }
        public int? CollectionID { get; set; }
        public string CollectionName { get; set; }
        public string Barcode { get; set; }
        public string PublicNote { get; set; }
        public string CallNumber { get; set; }
        public string Designation { get; set; }
        public string VolumeNumber { get; set; }
        public string ShelfLocation { get; set; }
        public int CircStatusID { get; set; }
        public string CircStatus { get; set; }
        public DateTime? LastCircDate { get; set; }
        public string MaterialType { get; set; }
        public string TextualHoldingsNote { get; set; }
        public string RetentionStatement { get; set; }
        public string HoldingsStatement { get; set; }
        public string HoldingsNote { get; set; }
        public int ItemsTotal { get; set; }
        public int ItemsIn { get; set; }
        public bool Holdable { get; set; }
        public DateTime? DueDate { get; set; }

        public override string ToString() => $"{Barcode} - {AssignedBranchName}";
    }
}
