namespace Clc.Api.Models
{
    public class BibInfo
    {
        public int BibliographicRecordID { get; set; }
        public string BrowseTitle { get; set; }
        public string BrowseAuthor { get; set; }
        public int SystemItemsTotal { get; set; }
        public int SystemItemsIn { get; set; }
        public int TotalHolds { get; set; }
        public List<BibHolding> Holdings { get; set; } = new List<BibHolding>();

        public override string ToString() => $"{BibliographicRecordID} - {BrowseTitle} - {Holdings.Count}";
    }
}
